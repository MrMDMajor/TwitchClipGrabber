
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
            formatText = new System.Windows.Forms.TextBox();
            formatLabel = new System.Windows.Forms.Label();
            helpText = new System.Windows.Forms.TextBox();
            helpButton = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            downloadQuality = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            helpFlow = new System.Windows.Forms.FlowLayoutPanel();
            helpText2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            exampleLabel = new System.Windows.Forms.Label();
            exampleText = new System.Windows.Forms.TextBox();
            fieldsPanel = new System.Windows.Forms.TableLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            vodFieldsSourceBox = new System.Windows.Forms.ListBox();
            clipFieldsSourceBox = new System.Windows.Forms.ListBox();
            clipFieldsAddButton = new System.Windows.Forms.Button();
            vodFieldsAddButton = new System.Windows.Forms.Button();
            clipFieldsDownButton = new System.Windows.Forms.Button();
            vodFieldsDownButton = new System.Windows.Forms.Button();
            clipFieldsUpButton = new System.Windows.Forms.Button();
            vodClipsLabel = new System.Windows.Forms.Label();
            clipFieldsLabel = new System.Windows.Forms.Label();
            clipFieldsSelected = new System.Windows.Forms.ListBox();
            vodFieldsSelected = new System.Windows.Forms.ListBox();
            vodFieldsUpButton = new System.Windows.Forms.Button();
            vodFieldsRemoveButton = new System.Windows.Forms.Button();
            clipFieldsRemoveButton = new System.Windows.Forms.Button();
            saveButton = new System.Windows.Forms.Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            helpFlow.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            fieldsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // formatText
            // 
            formatText.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            formatText.Location = new System.Drawing.Point(115, 4);
            formatText.Name = "formatText";
            formatText.Size = new System.Drawing.Size(286, 23);
            formatText.TabIndex = 0;
            formatText.TextChanged += formatText_TextChanged;
            // 
            // formatLabel
            // 
            formatLabel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            formatLabel.Location = new System.Drawing.Point(3, 8);
            formatLabel.Name = "formatLabel";
            formatLabel.Size = new System.Drawing.Size(106, 15);
            formatLabel.TabIndex = 1;
            formatLabel.Text = "Download File Format";
            formatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpText
            // 
            helpText.BackColor = System.Drawing.SystemColors.Control;
            helpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            helpText.Font = new System.Drawing.Font("Segoe UI", 7F);
            helpText.Location = new System.Drawing.Point(3, 3);
            helpText.Multiline = true;
            helpText.Name = "helpText";
            helpText.ReadOnly = true;
            helpText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            helpText.Size = new System.Drawing.Size(359, 137);
            helpText.TabIndex = 2;
            helpText.Text = resources.GetString("helpText.Text");
            // 
            // helpButton
            // 
            helpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            helpButton.Location = new System.Drawing.Point(407, 3);
            helpButton.Name = "helpButton";
            helpButton.Size = new System.Drawing.Size(25, 26);
            helpButton.TabIndex = 3;
            helpButton.Text = "?";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(helpFlow);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Controls.Add(fieldsPanel);
            flowLayoutPanel1.Controls.Add(saveButton);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(928, 546);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel1.Controls.Add(helpButton, 2, 0);
            tableLayoutPanel1.Controls.Add(downloadQuality, 4, 0);
            tableLayoutPanel1.Controls.Add(formatText, 1, 0);
            tableLayoutPanel1.Controls.Add(formatLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 3, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(623, 32);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // downloadQuality
            // 
            downloadQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            downloadQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            downloadQuality.FormattingEnabled = true;
            downloadQuality.Items.AddRange(new object[] { "1080p", "720p", "480p", "360p" });
            downloadQuality.Location = new System.Drawing.Point(550, 3);
            downloadQuality.Name = "downloadQuality";
            downloadQuality.Size = new System.Drawing.Size(70, 23);
            downloadQuality.TabIndex = 12;
            downloadQuality.SelectedIndexChanged += downloadQuality_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(438, 8);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(106, 15);
            label5.TabIndex = 13;
            label5.Text = "Download Quality";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpFlow
            // 
            helpFlow.Controls.Add(helpText);
            helpFlow.Controls.Add(helpText2);
            helpFlow.Controls.Add(textBox1);
            helpFlow.Location = new System.Drawing.Point(3, 41);
            helpFlow.Name = "helpFlow";
            helpFlow.Size = new System.Drawing.Size(865, 145);
            helpFlow.TabIndex = 5;
            helpFlow.Visible = false;
            // 
            // helpText2
            // 
            helpText2.BackColor = System.Drawing.SystemColors.Control;
            helpText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            helpText2.Font = new System.Drawing.Font("Segoe UI", 7F);
            helpText2.Location = new System.Drawing.Point(368, 3);
            helpText2.Multiline = true;
            helpText2.Name = "helpText2";
            helpText2.Size = new System.Drawing.Size(158, 137);
            helpText2.TabIndex = 4;
            helpText2.Text = resources.GetString("helpText2.Text");
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Control;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 7F);
            textBox1.Location = new System.Drawing.Point(532, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(252, 137);
            textBox1.TabIndex = 5;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.206799F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.7932F));
            tableLayoutPanel2.Controls.Add(exampleLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(exampleText, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 192);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tableLayoutPanel2.Size = new System.Drawing.Size(706, 36);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // exampleLabel
            // 
            exampleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            exampleLabel.Location = new System.Drawing.Point(3, 10);
            exampleLabel.Name = "exampleLabel";
            exampleLabel.Size = new System.Drawing.Size(59, 15);
            exampleLabel.TabIndex = 6;
            exampleLabel.Text = "Example:";
            exampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exampleText
            // 
            exampleText.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            exampleText.BackColor = System.Drawing.SystemColors.Control;
            exampleText.Location = new System.Drawing.Point(68, 6);
            exampleText.Name = "exampleText";
            exampleText.ReadOnly = true;
            exampleText.Size = new System.Drawing.Size(635, 23);
            exampleText.TabIndex = 3;
            // 
            // fieldsPanel
            // 
            fieldsPanel.ColumnCount = 9;
            fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            fieldsPanel.Controls.Add(label4, 7, 1);
            fieldsPanel.Controls.Add(label3, 5, 0);
            fieldsPanel.Controls.Add(label2, 0, 0);
            fieldsPanel.Controls.Add(label1, 2, 1);
            fieldsPanel.Controls.Add(vodFieldsSourceBox, 0, 2);
            fieldsPanel.Controls.Add(clipFieldsSourceBox, 5, 2);
            fieldsPanel.Controls.Add(clipFieldsAddButton, 6, 2);
            fieldsPanel.Controls.Add(vodFieldsAddButton, 1, 2);
            fieldsPanel.Controls.Add(clipFieldsDownButton, 8, 4);
            fieldsPanel.Controls.Add(vodFieldsDownButton, 3, 4);
            fieldsPanel.Controls.Add(clipFieldsUpButton, 7, 4);
            fieldsPanel.Controls.Add(vodClipsLabel, 0, 1);
            fieldsPanel.Controls.Add(clipFieldsLabel, 5, 1);
            fieldsPanel.Controls.Add(clipFieldsSelected, 7, 2);
            fieldsPanel.Controls.Add(vodFieldsSelected, 2, 2);
            fieldsPanel.Controls.Add(vodFieldsUpButton, 2, 4);
            fieldsPanel.Controls.Add(vodFieldsRemoveButton, 1, 3);
            fieldsPanel.Controls.Add(clipFieldsRemoveButton, 6, 3);
            fieldsPanel.Location = new System.Drawing.Point(8, 231);
            fieldsPanel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            fieldsPanel.Name = "fieldsPanel";
            fieldsPanel.RowCount = 5;
            fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            fieldsPanel.Size = new System.Drawing.Size(593, 242);
            fieldsPanel.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            fieldsPanel.SetColumnSpan(label4, 2);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(467, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(123, 20);
            label4.TabIndex = 13;
            label4.Text = "Displayed Fields";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            fieldsPanel.SetColumnSpan(label3, 4);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(322, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(268, 20);
            label3.TabIndex = 12;
            label3.Text = "Clip";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            fieldsPanel.SetColumnSpan(label2, 4);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Margin = new System.Windows.Forms.Padding(0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(269, 20);
            label2.TabIndex = 11;
            label2.Text = "VOD";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            fieldsPanel.SetColumnSpan(label1, 2);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(145, 20);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 20);
            label1.TabIndex = 10;
            label1.Text = "Displayed Fields";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vodFieldsSourceBox
            // 
            vodFieldsSourceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            vodFieldsSourceBox.FormattingEnabled = true;
            vodFieldsSourceBox.IntegralHeight = false;
            vodFieldsSourceBox.ItemHeight = 15;
            vodFieldsSourceBox.Items.AddRange(new object[] { "Broadcaster", "Date Created", "Duration", "Title", "URL", "Views" });
            vodFieldsSourceBox.Location = new System.Drawing.Point(0, 40);
            vodFieldsSourceBox.Margin = new System.Windows.Forms.Padding(0);
            vodFieldsSourceBox.Name = "vodFieldsSourceBox";
            fieldsPanel.SetRowSpan(vodFieldsSourceBox, 2);
            vodFieldsSourceBox.Size = new System.Drawing.Size(125, 176);
            vodFieldsSourceBox.Sorted = true;
            vodFieldsSourceBox.TabIndex = 0;
            // 
            // clipFieldsSourceBox
            // 
            clipFieldsSourceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            clipFieldsSourceBox.FormattingEnabled = true;
            clipFieldsSourceBox.IntegralHeight = false;
            clipFieldsSourceBox.ItemHeight = 15;
            clipFieldsSourceBox.Items.AddRange(new object[] { "Broadcaster", "Creator", "Date Created", "Duration", "ID", "Title", "URL", "Views", "VOD Date", "VOD Timestamp" });
            clipFieldsSourceBox.Location = new System.Drawing.Point(322, 40);
            clipFieldsSourceBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            clipFieldsSourceBox.Name = "clipFieldsSourceBox";
            fieldsPanel.SetRowSpan(clipFieldsSourceBox, 2);
            clipFieldsSourceBox.Size = new System.Drawing.Size(122, 176);
            clipFieldsSourceBox.Sorted = true;
            clipFieldsSourceBox.TabIndex = 2;
            // 
            // clipFieldsAddButton
            // 
            clipFieldsAddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            clipFieldsAddButton.Location = new System.Drawing.Point(444, 105);
            clipFieldsAddButton.Margin = new System.Windows.Forms.Padding(0);
            clipFieldsAddButton.Name = "clipFieldsAddButton";
            clipFieldsAddButton.Size = new System.Drawing.Size(20, 23);
            clipFieldsAddButton.TabIndex = 5;
            clipFieldsAddButton.Text = ">";
            clipFieldsAddButton.UseVisualStyleBackColor = true;
            clipFieldsAddButton.Click += fieldsAddButton_Click;
            // 
            // vodFieldsAddButton
            // 
            vodFieldsAddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            vodFieldsAddButton.Location = new System.Drawing.Point(125, 105);
            vodFieldsAddButton.Margin = new System.Windows.Forms.Padding(0);
            vodFieldsAddButton.Name = "vodFieldsAddButton";
            vodFieldsAddButton.Size = new System.Drawing.Size(20, 23);
            vodFieldsAddButton.TabIndex = 4;
            vodFieldsAddButton.Text = ">";
            vodFieldsAddButton.UseVisualStyleBackColor = true;
            vodFieldsAddButton.Click += fieldsAddButton_Click;
            // 
            // clipFieldsDownButton
            // 
            clipFieldsDownButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            clipFieldsDownButton.Location = new System.Drawing.Point(526, 216);
            clipFieldsDownButton.Margin = new System.Windows.Forms.Padding(0);
            clipFieldsDownButton.Name = "clipFieldsDownButton";
            clipFieldsDownButton.Size = new System.Drawing.Size(25, 26);
            clipFieldsDownButton.TabIndex = 3;
            clipFieldsDownButton.Text = "∨";
            clipFieldsDownButton.UseVisualStyleBackColor = true;
            clipFieldsDownButton.Click += fieldsDownButton_Click;
            // 
            // vodFieldsDownButton
            // 
            vodFieldsDownButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            vodFieldsDownButton.Location = new System.Drawing.Point(207, 216);
            vodFieldsDownButton.Margin = new System.Windows.Forms.Padding(0);
            vodFieldsDownButton.Name = "vodFieldsDownButton";
            vodFieldsDownButton.Size = new System.Drawing.Size(25, 26);
            vodFieldsDownButton.TabIndex = 5;
            vodFieldsDownButton.Text = "∨";
            vodFieldsDownButton.UseVisualStyleBackColor = true;
            vodFieldsDownButton.Click += fieldsDownButton_Click;
            // 
            // clipFieldsUpButton
            // 
            clipFieldsUpButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            clipFieldsUpButton.Location = new System.Drawing.Point(501, 216);
            clipFieldsUpButton.Margin = new System.Windows.Forms.Padding(0);
            clipFieldsUpButton.Name = "clipFieldsUpButton";
            clipFieldsUpButton.Size = new System.Drawing.Size(25, 26);
            clipFieldsUpButton.TabIndex = 4;
            clipFieldsUpButton.Text = "∧";
            clipFieldsUpButton.UseVisualStyleBackColor = true;
            clipFieldsUpButton.Click += fieldsUpButton_Click;
            // 
            // vodClipsLabel
            // 
            vodClipsLabel.AutoSize = true;
            vodClipsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            vodClipsLabel.Location = new System.Drawing.Point(0, 20);
            vodClipsLabel.Margin = new System.Windows.Forms.Padding(0);
            vodClipsLabel.Name = "vodClipsLabel";
            vodClipsLabel.Size = new System.Drawing.Size(125, 20);
            vodClipsLabel.TabIndex = 6;
            vodClipsLabel.Text = "Hidden Fields";
            vodClipsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clipFieldsLabel
            // 
            clipFieldsLabel.AutoSize = true;
            clipFieldsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            clipFieldsLabel.Location = new System.Drawing.Point(322, 20);
            clipFieldsLabel.Name = "clipFieldsLabel";
            clipFieldsLabel.Size = new System.Drawing.Size(119, 20);
            clipFieldsLabel.TabIndex = 7;
            clipFieldsLabel.Text = "Hidden Fields";
            clipFieldsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clipFieldsSelected
            // 
            fieldsPanel.SetColumnSpan(clipFieldsSelected, 2);
            clipFieldsSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            clipFieldsSelected.FormattingEnabled = true;
            clipFieldsSelected.IntegralHeight = false;
            clipFieldsSelected.ItemHeight = 15;
            clipFieldsSelected.Location = new System.Drawing.Point(464, 40);
            clipFieldsSelected.Margin = new System.Windows.Forms.Padding(0);
            clipFieldsSelected.Name = "clipFieldsSelected";
            fieldsPanel.SetRowSpan(clipFieldsSelected, 2);
            clipFieldsSelected.Size = new System.Drawing.Size(129, 176);
            clipFieldsSelected.TabIndex = 3;
            // 
            // vodFieldsSelected
            // 
            fieldsPanel.SetColumnSpan(vodFieldsSelected, 2);
            vodFieldsSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            vodFieldsSelected.FormattingEnabled = true;
            vodFieldsSelected.IntegralHeight = false;
            vodFieldsSelected.ItemHeight = 15;
            vodFieldsSelected.Location = new System.Drawing.Point(145, 40);
            vodFieldsSelected.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            vodFieldsSelected.Name = "vodFieldsSelected";
            fieldsPanel.SetRowSpan(vodFieldsSelected, 2);
            vodFieldsSelected.Size = new System.Drawing.Size(121, 176);
            vodFieldsSelected.TabIndex = 1;
            // 
            // vodFieldsUpButton
            // 
            vodFieldsUpButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            vodFieldsUpButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            vodFieldsUpButton.Location = new System.Drawing.Point(182, 216);
            vodFieldsUpButton.Margin = new System.Windows.Forms.Padding(0);
            vodFieldsUpButton.Name = "vodFieldsUpButton";
            vodFieldsUpButton.Size = new System.Drawing.Size(25, 26);
            vodFieldsUpButton.TabIndex = 2;
            vodFieldsUpButton.Text = "∧";
            vodFieldsUpButton.UseVisualStyleBackColor = true;
            vodFieldsUpButton.Click += fieldsUpButton_Click;
            // 
            // vodFieldsRemoveButton
            // 
            vodFieldsRemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            vodFieldsRemoveButton.Location = new System.Drawing.Point(125, 128);
            vodFieldsRemoveButton.Margin = new System.Windows.Forms.Padding(0);
            vodFieldsRemoveButton.Name = "vodFieldsRemoveButton";
            vodFieldsRemoveButton.Size = new System.Drawing.Size(20, 23);
            vodFieldsRemoveButton.TabIndex = 8;
            vodFieldsRemoveButton.Text = "<";
            vodFieldsRemoveButton.UseVisualStyleBackColor = true;
            vodFieldsRemoveButton.Click += fieldsRemoveButton_Click;
            // 
            // clipFieldsRemoveButton
            // 
            clipFieldsRemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            clipFieldsRemoveButton.Location = new System.Drawing.Point(444, 128);
            clipFieldsRemoveButton.Margin = new System.Windows.Forms.Padding(0);
            clipFieldsRemoveButton.Name = "clipFieldsRemoveButton";
            clipFieldsRemoveButton.Size = new System.Drawing.Size(20, 23);
            clipFieldsRemoveButton.TabIndex = 9;
            clipFieldsRemoveButton.Text = "<";
            clipFieldsRemoveButton.UseVisualStyleBackColor = true;
            clipFieldsRemoveButton.Click += fieldsRemoveButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(8, 476);
            saveButton.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(100, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save Changes";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(928, 546);
            Controls.Add(flowLayoutPanel1);
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            helpFlow.ResumeLayout(false);
            helpFlow.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            fieldsPanel.ResumeLayout(false);
            fieldsPanel.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel fieldsPanel;
        private System.Windows.Forms.ListBox vodFieldsSelected;
        private System.Windows.Forms.ListBox clipFieldsSourceBox;
        private System.Windows.Forms.ListBox clipFieldsSelected;
        private System.Windows.Forms.ListBox vodFieldsSourceBox;
        private System.Windows.Forms.Button clipFieldsAddButton;
        private System.Windows.Forms.Button vodFieldsAddButton;
        private System.Windows.Forms.Label vodClipsLabel;
        private System.Windows.Forms.Button vodFieldsUpButton;
        private System.Windows.Forms.Button clipFieldsDownButton;
        private System.Windows.Forms.Button clipFieldsUpButton;
        private System.Windows.Forms.Button vodFieldsDownButton;
        private System.Windows.Forms.Label clipFieldsLabel;
        private System.Windows.Forms.Button vodFieldsRemoveButton;
        private System.Windows.Forms.Button clipFieldsRemoveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox downloadQuality;
        private System.Windows.Forms.Label label5;
    }
}