using System;
using System.Windows.Forms;

namespace TwitchClipGrabber
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.formatText.Text = Properties.Settings.Default.FilenameFormat;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (helpFlow.Visible) helpFlow.Hide();
            else helpFlow.Show();
        }

        private void formatText_TextChanged(object sender, EventArgs e)
        {
            exampleText.Text = UserSettings.FormatFilename(ExampleClip.clip, formatText.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FilenameFormat = formatText.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
