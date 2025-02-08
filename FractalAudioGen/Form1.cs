using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace FractalAudioGen
{
    public partial class Form1 : Form
    {
        private readonly WaveOutEvent waveOut;
        private readonly FractalWaveProvider waveProvider;

        private readonly IReadOnlyDictionary<int, string> supportedFrequencies = new Dictionary<int, string>
        {
            { 174, "Pain Relief" },
            { 285, "Tissue Healing" },
            { 396, "Fear Reduction" },
            { 417, "Negative Energy" },
            { 432, "Natural Harmony" },
            { 528, "DNA Repair" },
            { 639, "Love & Connection" },
            { 741, "Detox & Immunity" },
            { 852, "Intuition Boost" },
            { 963, "Pineal Gland" },
        };

        public Form1()
        {
            // Perform app init
            waveProvider = new FractalWaveProvider();
            waveOut = new WaveOutEvent();
            waveOut.Init(waveProvider);

            // Start UI
            InitializeComponent();

            // Bind controls
            cmbHealingFrequencies.DataSource = new BindingSource(supportedFrequencies, null);
            cmbHealingFrequencies.DisplayMember = "Value";
            cmbHealingFrequencies.ValueMember = "Key";
            cmbHealingFrequencies.FormattingEnabled = true;
            // Format list entries by listing both Hz and intent
            cmbHealingFrequencies.Format += (_, args) =>
            {
                var listItem = (KeyValuePair<int, string>)args.ListItem!;
                args.Value = $"{listItem.Key} Hz - {listItem.Value}";
            };

            // cmbHealingFrequencies.FormattingEnabled = true;
            // cmbHealingFrequencies.FormatString = "{0} Hz - {1}";

            // Set our default to DNA Repair
            cmbHealingFrequencies.SelectedIndex = 5;

            cmbWaveType.DataSource = Enum.GetValues<FractalWaveType>();

            // Stop is disabled by default, nothing is playing yet
            btnStop.Enabled = false;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (waveOut.PlaybackState != PlaybackState.Playing)
            {
                waveOut.Play();
                btnPlay.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Stop();
                btnPlay.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void CmbHealingFrequencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the control is first initialized, bindings are not set up yet - allow early term
            if (cmbHealingFrequencies.SelectedValue is not int selectedFrequency)
                return;

            waveProvider.Frequency = selectedFrequency;
        }

        private void TrackBinauralOffset_Scroll(object sender, EventArgs e)
        {
            waveProvider.BinauralOffset = trackBinauralOffset.Value;
            lblBinauralOffset.Text = $"Binaural Offset: {trackBinauralOffset.Value} Hz";
        }

        private void CmbWaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWaveType.SelectedItem is FractalWaveType waveType)
            {
                waveProvider.WaveType = waveType;
            }
        }
    }
}
