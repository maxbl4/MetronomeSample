using NAudio.Wave;
using System;

namespace Metronome
{
    internal class Sound: IDisposable
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public Sound(string fileName)
        {
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(fileName);
            outputDevice.Init(audioFile);
        }

        public void Play()
        {
            audioFile.Position = 0;
            outputDevice.Play();
        }

        public void Dispose()
        {
            audioFile.Dispose();
            outputDevice.Dispose();
        }
    }
}
