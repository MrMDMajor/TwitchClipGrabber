
namespace TwitchClipGrabber
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.helpFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.helpText2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.exampleText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.helpFlow.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formatText
            // 
            this.formatText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formatText.Location = new System.Drawing.Point(136, 4);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(390, 23);
            this.formatText.TabIndex = 0;
            this.formatText.TextChanged += new System.EventHandler(this.formatText_TextChanged);
            // 
            // formatLabel
            // 
            this.formatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formatLabel.Location = new System.Drawing.Point(3, 8);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(127, 15);
            this.formatLabel.TabIndex = 1;
            this.formatLabel.Text = "Download File Format";
            this.formatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.helpText.Size = new System.Drawing.Size(359, 137);
            this.helpText.TabIndex = 2;
            this.helpText.Text = resources.GetString("helpText.Text");
            // 
            // helpButton
            // 
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpButton.Location = new System.Drawing.Point(532, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 26);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.helpFlow);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(928, 509);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.helpButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.formatText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.formatLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 32);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // helpFlow
            // 
            this.helpFlow.Controls.Add(this.helpText);
            this.helpFlow.Controls.Add(this.helpText2);
            this.helpFlow.Controls.Add(this.textBox1);
            this.helpFlow.Location = new System.Drawing.Point(3, 41);
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
            this.helpText2.Location = new System.Drawing.Point(368, 3);
            this.helpText2.Multiline = true;
            this.helpText2.Name = "helpText2";
            this.helpText2.Size = new System.Drawing.Size(158, 137);
            this.helpText2.TabIndex = 4;
            this.helpText2.Text = resources.GetString("helpText2.Text");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(532, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 137);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.206799F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.7932F));
            this.tableLayoutPanel2.Controls.Add(this.exampleLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.exampleText, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 192);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(706, 36);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // exampleLabel
            // 
            this.exampleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exampleLabel.Location = new System.Drawing.Point(3, 10);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(59, 15);
            this.exampleLabel.TabIndex = 6;
            this.exampleLabel.Text = "Example:";
            this.exampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exampleText
            // 
            this.exampleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exampleText.BackColor = System.Drawing.SystemColors.Control;
            this.exampleText.Location = new System.Drawing.Point(68, 6);
            this.exampleText.Name = "exampleText";
            this.exampleText.ReadOnly = true;
            this.exampleText.Size = new System.Drawing.Size(635, 23);
            this.exampleText.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 234);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 509);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.helpFlow.ResumeLayout(false);
            this.helpFlow.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox formatText;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.TextBox helpText;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox exampleText;
        private System.Windows.Forms.FlowLayoutPanel helpFlow;
        private System.Windows.Forms.TextBox helpText2;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveButton;
    }
}