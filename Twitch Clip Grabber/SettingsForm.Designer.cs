
namespace Twitch_Clip_Grabber
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.formatText = new System.Windows.Forms.TextBox();
            this.formatLabel = new System.Windows.Forms.Label();
            this.helpText = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.exampleText = new System.Windows.Forms.TextBox();
            this.helpFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.helpText2 = new System.Windows.Forms.TextBox();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.helpFlow.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // formatText
            // 
            this.formatText.Location = new System.Drawing.Point(132, 3);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(378, 23);
            this.formatText.TabIndex = 0;
            this.formatText.TextChanged += new System.EventHandler(this.formatText_TextChanged);
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(3, 0);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(123, 15);
            this.formatLabel.TabIndex = 1;
            this.formatLabel.Text = "Download File Format";
            // 
            // helpText
            // 
            this.helpText.BackColor = System.Drawing.SystemColors.Control;
            this.helpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpText.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpText.Location = new System.Drawing.Point(3, 3);
            this.helpText.Multiline = true;
            this.helpText.Name = "helpText";
            this.helpText.ReadOnly = true;
            this.helpText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpText.Size = new System.Drawing.Size(405, 137);
            this.helpText.TabIndex = 2;
            this.helpText.Text = resources.GetString("helpText.Text");
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(516, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(29, 23);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.helpFlow);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(928, 509);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.formatLabel);
            this.flowLayoutPanel2.Controls.Add(this.formatText);
            this.flowLayoutPanel2.Controls.Add(this.helpButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(558, 34);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // exampleText
            // 
            this.exampleText.BackColor = System.Drawing.SystemColors.Control;
            this.exampleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exampleText.Location = new System.Drawing.Point(64, 3);
            this.exampleText.Name = "exampleText";
            this.exampleText.Size = new System.Drawing.Size(558, 16);
            this.exampleText.TabIndex = 3;
            // 
            // helpFlow
            // 
            this.helpFlow.Controls.Add(this.helpText);
            this.helpFlow.Controls.Add(this.helpText2);
            this.helpFlow.Location = new System.Drawing.Point(3, 43);
            this.helpFlow.Name = "helpFlow";
            this.helpFlow.Size = new System.Drawing.Size(865, 145);
            this.helpFlow.TabIndex = 5;
            this.helpFlow.Visible = false;
            // 
            // helpText2
            // 
            this.helpText2.BackColor = System.Drawing.SystemColors.Control;
            this.helpText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpText2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpText2.Location = new System.Drawing.Point(414, 3);
            this.helpText2.Multiline = true;
            this.helpText2.Name = "helpText2";
            this.helpText2.Size = new System.Drawing.Size(284, 196);
            this.helpText2.TabIndex = 4;
            this.helpText2.Text = resources.GetString("helpText2.Text");
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Location = new System.Drawing.Point(3, 0);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(55, 15);
            this.exampleLabel.TabIndex = 6;
            this.exampleLabel.Text = "Example:";
            this.exampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.exampleLabel);
            this.flowLayoutPanel3.Controls.Add(this.exampleText);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 194);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(706, 32);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 509);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.helpFlow.ResumeLayout(false);
            this.helpFlow.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox formatText;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.TextBox helpText;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox exampleText;
        private System.Windows.Forms.FlowLayoutPanel helpFlow;
        private System.Windows.Forms.TextBox helpText2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label exampleLabel;
    }
}