namespace Metronome
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMetronomeStep = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTick = new System.Windows.Forms.Button();
            this.btnTock = new System.Windows.Forms.Button();
            this.tbMetronomeErrorMs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubSteps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMarker = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMetronomeStep
            // 
            this.tbMetronomeStep.Location = new System.Drawing.Point(248, 26);
            this.tbMetronomeStep.Name = "tbMetronomeStep";
            this.tbMetronomeStep.Size = new System.Drawing.Size(100, 20);
            this.tbMetronomeStep.TabIndex = 0;
            this.tbMetronomeStep.Text = "240";
            this.tbMetronomeStep.TextChanged += new System.EventHandler(this.tbMetronomeStep_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(354, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start/Stop";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTick
            // 
            this.btnTick.Location = new System.Drawing.Point(435, 24);
            this.btnTick.Name = "btnTick";
            this.btnTick.Size = new System.Drawing.Size(75, 23);
            this.btnTick.TabIndex = 1;
            this.btnTick.Text = "Tick";
            this.btnTick.UseVisualStyleBackColor = true;
            this.btnTick.Click += new System.EventHandler(this.btnTick_Click);
            // 
            // btnTock
            // 
            this.btnTock.Location = new System.Drawing.Point(516, 24);
            this.btnTock.Name = "btnTock";
            this.btnTock.Size = new System.Drawing.Size(75, 23);
            this.btnTock.TabIndex = 1;
            this.btnTock.Text = "Tock";
            this.btnTock.UseVisualStyleBackColor = true;
            this.btnTock.Click += new System.EventHandler(this.btnTock_Click);
            // 
            // tbMetronomeErrorMs
            // 
            this.tbMetronomeErrorMs.Location = new System.Drawing.Point(248, 93);
            this.tbMetronomeErrorMs.Name = "tbMetronomeErrorMs";
            this.tbMetronomeErrorMs.ReadOnly = true;
            this.tbMetronomeErrorMs.Size = new System.Drawing.Size(100, 20);
            this.tbMetronomeErrorMs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ошибка метронома в мс";
            // 
            // tbSubSteps
            // 
            this.tbSubSteps.Location = new System.Drawing.Point(248, 52);
            this.tbSubSteps.Name = "tbSubSteps";
            this.tbSubSteps.Size = new System.Drawing.Size(100, 20);
            this.tbSubSteps.TabIndex = 0;
            this.tbSubSteps.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Шагов";
            // 
            // rbMarker
            // 
            this.rbMarker.AutoSize = true;
            this.rbMarker.Checked = true;
            this.rbMarker.Location = new System.Drawing.Point(265, 210);
            this.rbMarker.Name = "rbMarker";
            this.rbMarker.Size = new System.Drawing.Size(14, 13);
            this.rbMarker.TabIndex = 4;
            this.rbMarker.TabStop = true;
            this.rbMarker.UseVisualStyleBackColor = true;
            this.rbMarker.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metronome.Properties.Resources._16_16BtSmV2_001;
            this.pictureBox1.Location = new System.Drawing.Point(79, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 308);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 700);
            this.Controls.Add(this.rbMarker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMetronomeErrorMs);
            this.Controls.Add(this.btnTock);
            this.Controls.Add(this.btnTick);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbSubSteps);
            this.Controls.Add(this.tbMetronomeStep);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMetronomeStep;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTick;
        private System.Windows.Forms.Button btnTock;
        private System.Windows.Forms.TextBox tbMetronomeErrorMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMarker;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

