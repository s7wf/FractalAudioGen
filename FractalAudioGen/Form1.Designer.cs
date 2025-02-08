namespace FractalAudioGen
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.ComboBox cmbHealingFrequencies;
        private System.Windows.Forms.Label lblBinauralOffset;
        private System.Windows.Forms.TrackBar trackBinauralOffset;
        private System.Windows.Forms.ComboBox cmbWaveType;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlay = new System.Windows.Forms.Button();



            btnStop = new System.Windows.Forms.Button();
            lblFrequency = new System.Windows.Forms.Label();
            cmbHealingFrequencies = new System.Windows.Forms.ComboBox();
            lblBinauralOffset = new System.Windows.Forms.Label();
            trackBinauralOffset = new System.Windows.Forms.TrackBar();
            cmbWaveType = new System.Windows.Forms.ComboBox();
            waveType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)trackBinauralOffset).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new System.Drawing.Point(20, 20);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new System.Drawing.Size(80, 30);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.Click += BtnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new System.Drawing.Point(110, 20);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(80, 30);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.Click += BtnStop_Click;
            // 
            // lblFrequency
            // 
            lblFrequency.AutoSize = true;
            lblFrequency.Location = new System.Drawing.Point(20, 70);
            lblFrequency.Name = "lblFrequency";
            lblFrequency.Size = new System.Drawing.Size(79, 20);
            lblFrequency.TabIndex = 2;
            lblFrequency.Text = "Frequency:";
            // 
            // cmbHealingFrequencies
            // 
            cmbHealingFrequencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbHealingFrequencies.Items.AddRange(new object[] { "174 Hz - Pain Relief", "285 Hz - Tissue Healing", "396 Hz - Fear Reduction", "417 Hz - Negative Energy", "432 Hz - Natural Harmony", "528 Hz - DNA Repair", "639 Hz - Love & Connection", "741 Hz - Detox & Immunity", "852 Hz - Intuition Boost", "963 Hz - Pineal Gland" });
            cmbHealingFrequencies.Location = new System.Drawing.Point(120, 65);
            cmbHealingFrequencies.Name = "cmbHealingFrequencies";
            cmbHealingFrequencies.Size = new System.Drawing.Size(200, 28);
            cmbHealingFrequencies.TabIndex = 3;
            cmbHealingFrequencies.SelectedIndexChanged += CmbHealingFrequencies_SelectedIndexChanged;
            // 
            // lblBinauralOffset
            // 
            lblBinauralOffset.AutoSize = true;
            lblBinauralOffset.Location = new System.Drawing.Point(20, 120);
            lblBinauralOffset.Name = "lblBinauralOffset";
            lblBinauralOffset.Size = new System.Drawing.Size(144, 20);
            lblBinauralOffset.TabIndex = 4;
            lblBinauralOffset.Text = "Binaural Offset: 0 Hz";
            // 
            // trackBinauralOffset
            // 
            trackBinauralOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            trackBinauralOffset.Location = new System.Drawing.Point(20, 140);
            trackBinauralOffset.Maximum = 20;
            trackBinauralOffset.Name = "trackBinauralOffset";
            trackBinauralOffset.Size = new System.Drawing.Size(339, 56);
            trackBinauralOffset.TabIndex = 5;
            trackBinauralOffset.ValueChanged += TrackBinauralOffset_Scroll;
            // 
            // cmbWaveType
            // 
            cmbWaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbWaveType.Location = new System.Drawing.Point(121, 201);
            cmbWaveType.Name = "cmbWaveType";
            cmbWaveType.Size = new System.Drawing.Size(200, 28);
            cmbWaveType.TabIndex = 6;
            cmbWaveType.SelectedIndexChanged += CmbWaveType_SelectedIndexChanged;
            // 
            // waveType
            // 
            waveType.Location = new System.Drawing.Point(17, 198);
            waveType.Name = "waveType";
            waveType.Size = new System.Drawing.Size(98, 32);
            waveType.TabIndex = 7;
            waveType.Text = "Wave Type:";
            waveType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(371, 257);
            Controls.Add(waveType);
            Controls.Add(btnPlay);
            Controls.Add(btnStop);
            Controls.Add(lblFrequency);
            Controls.Add(cmbHealingFrequencies);
            Controls.Add(lblBinauralOffset);
            Controls.Add(trackBinauralOffset);
            Controls.Add(cmbWaveType);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "Healing Frequency Generator";
            ((System.ComponentModel.ISupportInitialize)trackBinauralOffset).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label waveType;
    }
}
