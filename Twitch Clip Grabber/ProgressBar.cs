using System.Windows.Forms;

namespace Twitch_Clip_Grabber
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        public void UpdateProgressBar(int value = 0)
        {
            this.loadingProgressBar.Value = value;
            this.progressBarPercent.Text = value.ToString() + "%";
        }
    }
}
