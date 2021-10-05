using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metronome
{
    public partial class Form1 : Form
    {
        private Sound tick;
        private Sound tock;
        private bool runMentronome;
        private long metronomeError;
        private int markerStartPosition;
        private int markerSteps = 15;
        private int markerStepSpacing = 640 / 15;
        private int markerCurrentStep = 0;

        public Form1()
        {
            InitializeComponent();

            tick = new Sound(@"resources\tick.ac3");
            tock = new Sound(@"resources\tock.ac3");
            markerStartPosition = rbMarker.Left;
        }

        private void btnTick_Click(object sender, System.EventArgs e)
        {
            tick.Play();
        }

        private void btnTock_Click(object sender, System.EventArgs e)
        {
            tock.Play();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            if (runMentronome)
            {
                runMentronome = false;
                rbMarker.Visible = false;
                rbMarker.Left = markerStartPosition;
            }
            else
            {
                markerCurrentStep = 0;
                rbMarker.Visible = true;
                runMentronome = true;
                metronomeError = 0;
                var metronnomeStep = int.Parse(tbMetronomeStep.Text);
                var subSteps = int.Parse(tbSubSteps.Text);
                _ = Task.Run(() => RunMetronome(metronnomeStep, subSteps));
            }
        }

        private void OnMetronomeTick()
        {
            tbMetronomeErrorMs.Text = metronomeError.ToString();
            markerCurrentStep++;
            if (markerCurrentStep > markerSteps)
                markerCurrentStep = 0;
            rbMarker.Left = markerStartPosition + markerCurrentStep * markerStepSpacing;
        }

        async Task RunMetronome(int metronomeStep, int subSteps)
        {
            await Task.Yield();
            tick.Play();
            var tickIntervalMs = 1000 * 60 / metronomeStep;
            var tickIndex = 0;
            long lastTick = 0;
            var sw = Stopwatch.StartNew();
            while (runMentronome)
            {
                var actualInterval = sw.ElapsedMilliseconds - lastTick;
                if (actualInterval > tickIntervalMs)
                {
                    tickIndex++;
                    if (tickIndex % subSteps == 0)
                        tick.Play();
                    else
                        tock.Play();
                    lastTick = sw.ElapsedMilliseconds / tickIntervalMs * tickIntervalMs;
                    metronomeError += (actualInterval - tickIntervalMs);
                    this.BeginInvoke(new Action(OnMetronomeTick));
                }
                await Task.Yield();
            }
        }

        private void tbMetronomeStep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
