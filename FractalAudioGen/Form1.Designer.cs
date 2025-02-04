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

        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.cmbHealingFrequencies = new System.Windows.Forms.ComboBox();
            this.lblBinauralOffset = new System.Windows.Forms.Label();
            this.trackBinauralOffset = new System.Windows.Forms.TrackBar();
            this.cmbWaveType = new System.Windows.Forms.ComboBox();

            this.SuspendLayout();

            // 
            // Form Properties
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300); // Adjust form size
            this.Text = "Healing Frequency Generator";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // 
            // btnPlay
            // 
            this.btnPlay.Text = "Play";
            this.btnPlay.Location = new System.Drawing.Point(20, 20);
            this.btnPlay.Size = new System.Drawing.Size(80, 30);
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            this.Controls.Add(this.btnPlay);

            // 
            // btnStop
            // 
            this.btnStop.Text = "Stop";
            this.btnStop.Location = new System.Drawing.Point(110, 20);
            this.btnStop.Size = new System.Drawing.Size(80, 30);
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            this.Controls.Add(this.btnStop);

            // 
            // lblFrequency
            // 
            this.lblFrequency.Text = "Frequency:";
            this.lblFrequency.Location = new System.Drawing.Point(20, 70);
            this.lblFrequency.AutoSize = true;
            this.Controls.Add(this.lblFrequency);

            // 
            // cmbHealingFrequencies
            // 
            this.cmbHealingFrequencies.Location = new System.Drawing.Point(120, 65);
            this.cmbHealingFrequencies.Size = new System.Drawing.Size(200, 25);
            this.cmbHealingFrequencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHealingFrequencies.Items.AddRange(new string[] {
                "174 Hz - Pain Relief",
                "285 Hz - Tissue Healing",
                "396 Hz - Fear Reduction",
                "417 Hz - Negative Energy",
                "432 Hz - Natural Harmony",
                "528 Hz - DNA Repair",
                "639 Hz - Love & Connection",
                "741 Hz - Detox & Immunity",
                "852 Hz - Intuition Boost",
                "963 Hz - Pineal Gland"
            });
            this.cmbHealingFrequencies.SelectedIndex = 5; // Default to 528 Hz
            this.cmbHealingFrequencies.SelectedIndexChanged += new System.EventHandler(this.CmbHealingFrequencies_SelectedIndexChanged);
            this.Controls.Add(this.cmbHealingFrequencies);

            // 
            // lblBinauralOffset
            // 
            this.lblBinauralOffset.Text = "Binaural Offset: 0 Hz";
            this.lblBinauralOffset.Location = new System.Drawing.Point(20, 120);
            this.lblBinauralOffset.AutoSize = true;
            this.Controls.Add(this.lblBinauralOffset);

            // 
            // trackBinauralOffset
            // 
            this.trackBinauralOffset.Location = new System.Drawing.Point(20, 140);
            this.trackBinauralOffset.Size = new System.Drawing.Size(300, 40);
            this.trackBinauralOffset.Minimum = 0;
            this.trackBinauralOffset.Maximum = 20;
            this.trackBinauralOffset.TickFrequency = 1;
            this.trackBinauralOffset.ValueChanged += new System.EventHandler(this.TrackBinauralOffset_Scroll);
            this.Controls.Add(this.trackBinauralOffset);

            // 
            // cmbWaveType
            // 
            this.cmbWaveType.Location = new System.Drawing.Point(20, 190);
            this.cmbWaveType.Size = new System.Drawing.Size(200, 25);
            this.cmbWaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaveType.Items.AddRange(new string[] {
                "Sine",
                "Square",
                "Triangle",
                "Sawtooth"
            });
            this.cmbWaveType.SelectedIndex = 0; // Default to Sine
            this.cmbWaveType.SelectedIndexChanged += new System.EventHandler(this.CmbWaveType_SelectedIndexChanged);
            this.Controls.Add(this.cmbWaveType);

            // 
            // Finalize Form
            // 
            this.ResumeLayout(false);
        }
    }
}
