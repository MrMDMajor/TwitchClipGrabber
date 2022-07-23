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
