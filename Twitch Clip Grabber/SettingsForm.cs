using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitch_Clip_Grabber
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
    }
}
