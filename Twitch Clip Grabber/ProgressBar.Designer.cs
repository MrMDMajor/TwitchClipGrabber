
namespace Twitch_Clip_Grabber
{
    partial class ProgressBar
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
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingProgressBar.Location = new System.Drawing.Point(0, 0);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.Size = new System.Drawing.Size(237, 26);
            this.loadingProgressBar.Step = 1;
            this.loadingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingProgressBar.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 26);
            this.ControlBox = false;
            this.Controls.Add(this.loadingProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar loadingProgressBar;
    }
}