using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace FractalAudioGen
{
    public partial class Form1 : Form
    {
        private WaveOutEvent waveOut;
        private FractalWaveProvider waveProvider;

        public Form1()
        {
            InitializeComponent();
            waveProvider = new FractalWaveProvider();
            waveOut = new WaveOutEvent();
            waveOut.Init(waveProvider);

            // Prevent null reference issues
            cmbHealingFrequencies.SelectedIndex = 0;
            cmbWaveType.SelectedIndex = 0;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (waveOut != null && waveOut.PlaybackState != PlaybackState.Playing)
            {
                waveOut.Play();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Stop();
            }
        }

        private void CmbHealingFrequencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHealingFrequencies.SelectedItem is string selection)
            {
                UpdateFrequency(selection);
            }
        }

        private void TrackBinauralOffset_Scroll(object sender, EventArgs e)
        {
            if (trackBinauralOffset != null && lblBinauralOffset != null)
            {
                waveProvider.BinauralOffset = trackBinauralOffset.Value;
                lblBinauralOffset.Text = $"Binaural Offset: {trackBinauralOffset.Value} Hz";
            }
        }

        private void CmbWaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWaveType.SelectedItem is string waveType)
            {
                waveProvider.WaveType = waveType;
            }
        }

        private void UpdateFrequency(string selection)
        {
            if (string.IsNullOrEmpty(selection)) return;

            switch (selection)
            {
                case "174 Hz - Pain Relief":
                    waveProvider.Frequency = 174;
                    break;
                case "285 Hz - Tissue Healing":
                    waveProvider.Frequency = 285;
                    break;
                case "396 Hz - Fear Reduction":
                    waveProvider.Frequency = 396;
                    break;
                case "417 Hz - Negative Energy":
                    waveProvider.Frequency = 417;
                    break;
                case "432 Hz - Natural Harmony":
                    waveProvider.Frequency = 432;
                    break;
                case "528 Hz - DNA Repair":
                    waveProvider.Frequency = 528;
                    break;
                case "639 Hz - Love & Connection":
                    waveProvider.Frequency = 639;
                    break;
                case "741 Hz - Detox & Immunity":
                    waveProvider.Frequency = 741;
                    break;
                case "852 Hz - Intuition Boost":
                    waveProvider.Frequency = 852;
                    break;
                case "963 Hz - Pineal Gland":
                    waveProvider.Frequency = 963;
                    break;
                default:
                    waveProvider.Frequency = 528; // Default to 528 Hz
                    break;
            }
        }
    }
}
