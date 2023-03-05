
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
            this.fieldsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.vodFieldsSourceBox = new System.Windows.Forms.ListBox();
            this.clipFieldsSourceBox = new System.Windows.Forms.ListBox();
            this.clipFieldsAddButton = new System.Windows.Forms.Button();
            this.vodFieldsAddButton = new System.Windows.Forms.Button();
            this.clipFieldsDownButton = new System.Windows.Forms.Button();
            this.vodFieldsDownButton = new System.Windows.Forms.Button();
            this.clipFieldsUpButton = new System.Windows.Forms.Button();
            this.vodClipsLabel = new System.Windows.Forms.Label();
            this.clipFieldsLabel = new System.Windows.Forms.Label();
            this.clipFieldsSelected = new System.Windows.Forms.ListBox();
            this.vodFieldsSelected = new System.Windows.Forms.ListBox();
            this.vodFieldsUpButton = new System.Windows.Forms.Button();
            this.vodFieldsRemoveButton = new System.Windows.Forms.Button();
            this.clipFieldsRemoveButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.helpFlow.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.fieldsPanel.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.fieldsPanel);
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
            // fieldsPanel
            // 
            this.fieldsPanel.ColumnCount = 8;
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fieldsPanel.Controls.Add(this.label4, 6, 1);
            this.fieldsPanel.Controls.Add(this.label3, 4, 0);
            this.fieldsPanel.Controls.Add(this.label2, 0, 0);
            this.fieldsPanel.Controls.Add(this.label1, 2, 1);
            this.fieldsPanel.Controls.Add(this.vodFieldsSourceBox, 0, 2);
            this.fieldsPanel.Controls.Add(this.clipFieldsSourceBox, 4, 2);
            this.fieldsPanel.Controls.Add(this.clipFieldsAddButton, 5, 2);
            this.fieldsPanel.Controls.Add(this.vodFieldsAddButton, 1, 2);
            this.fieldsPanel.Controls.Add(this.clipFieldsDownButton, 7, 4);
            this.fieldsPanel.Controls.Add(this.vodFieldsDownButton, 3, 4);
            this.fieldsPanel.Controls.Add(this.clipFieldsUpButton, 6, 4);
            this.fieldsPanel.Controls.Add(this.vodClipsLabel, 0, 1);
            this.fieldsPanel.Controls.Add(this.clipFieldsLabel, 4, 1);
            this.fieldsPanel.Controls.Add(this.clipFieldsSelected, 6, 2);
            this.fieldsPanel.Controls.Add(this.vodFieldsSelected, 2, 2);
            this.fieldsPanel.Controls.Add(this.vodFieldsUpButton, 2, 4);
            this.fieldsPanel.Controls.Add(this.vodFieldsRemoveButton, 1, 3);
            this.fieldsPanel.Controls.Add(this.clipFieldsRemoveButton, 5, 3);
            this.fieldsPanel.Location = new System.Drawing.Point(8, 231);
            this.fieldsPanel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.RowCount = 5;
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.fieldsPanel.Size = new System.Drawing.Size(553, 242);
            this.fieldsPanel.TabIndex = 11;
            // 
            // vodFieldsSourceBox
            // 
            this.vodFieldsSourceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vodFieldsSourceBox.FormattingEnabled = true;
            this.vodFieldsSourceBox.IntegralHeight = false;
            this.vodFieldsSourceBox.ItemHeight = 15;
            this.vodFieldsSourceBox.Items.AddRange(new object[] {
            "Broadcaster",
            "Date Created",
            "Duration",
            "Title",
            "URL",
            "Views"});
            this.vodFieldsSourceBox.Location = new System.Drawing.Point(0, 40);
            this.vodFieldsSourceBox.Margin = new System.Windows.Forms.Padding(0);
            this.vodFieldsSourceBox.Name = "vodFieldsSourceBox";
            this.fieldsPanel.SetRowSpan(this.vodFieldsSourceBox, 2);
            this.vodFieldsSourceBox.Size = new System.Drawing.Size(128, 176);
            this.vodFieldsSourceBox.Sorted = true;
            this.vodFieldsSourceBox.TabIndex = 0;
            // 
            // clipFieldsSourceBox
            // 
            this.clipFieldsSourceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipFieldsSourceBox.FormattingEnabled = true;
            this.clipFieldsSourceBox.IntegralHeight = false;
            this.clipFieldsSourceBox.ItemHeight = 15;
            this.clipFieldsSourceBox.Items.AddRange(new object[] {
            "Broadcaster",
            "Creator",
            "Date Created",
            "Duration",
            "ID",
            "Title",
            "URL",
            "Views",
            "VOD Date",
            "VOD Timestamp"});
            this.clipFieldsSourceBox.Location = new System.Drawing.Point(279, 40);
            this.clipFieldsSourceBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.clipFieldsSourceBox.Name = "clipFieldsSourceBox";
            this.fieldsPanel.SetRowSpan(this.clipFieldsSourceBox, 2);
            this.clipFieldsSourceBox.Size = new System.Drawing.Size(125, 176);
            this.clipFieldsSourceBox.Sorted = true;
            this.clipFieldsSourceBox.TabIndex = 2;
            // 
            // clipFieldsAddButton
            // 
            this.clipFieldsAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clipFieldsAddButton.Location = new System.Drawing.Point(404, 105);
            this.clipFieldsAddButton.Margin = new System.Windows.Forms.Padding(0);
            this.clipFieldsAddButton.Name = "clipFieldsAddButton";
            this.clipFieldsAddButton.Size = new System.Drawing.Size(20, 23);
            this.clipFieldsAddButton.TabIndex = 5;
            this.clipFieldsAddButton.Text = ">";
            this.clipFieldsAddButton.UseVisualStyleBackColor = true;
            this.clipFieldsAddButton.Click += new System.EventHandler(this.fieldsAddButton_Click);
            // 
            // vodFieldsAddButton
            // 
            this.vodFieldsAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vodFieldsAddButton.Location = new System.Drawing.Point(128, 105);
            this.vodFieldsAddButton.Margin = new System.Windows.Forms.Padding(0);
            this.vodFieldsAddButton.Name = "vodFieldsAddButton";
            this.vodFieldsAddButton.Size = new System.Drawing.Size(20, 23);
            this.vodFieldsAddButton.TabIndex = 4;
            this.vodFieldsAddButton.Text = ">";
            this.vodFieldsAddButton.UseVisualStyleBackColor = true;
            this.vodFieldsAddButton.Click += new System.EventHandler(this.fieldsAddButton_Click);
            // 
            // clipFieldsDownButton
            // 
            this.clipFieldsDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clipFieldsDownButton.Location = new System.Drawing.Point(488, 216);
            this.clipFieldsDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.clipFieldsDownButton.Name = "clipFieldsDownButton";
            this.clipFieldsDownButton.Size = new System.Drawing.Size(25, 26);
            this.clipFieldsDownButton.TabIndex = 3;
            this.clipFieldsDownButton.Text = "∨";
            this.clipFieldsDownButton.UseVisualStyleBackColor = true;
            this.clipFieldsDownButton.Click += new System.EventHandler(this.fieldsDownButton_Click);
            // 
            // vodFieldsDownButton
            // 
            this.vodFieldsDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.vodFieldsDownButton.Location = new System.Drawing.Point(212, 216);
            this.vodFieldsDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.vodFieldsDownButton.Name = "vodFieldsDownButton";
            this.vodFieldsDownButton.Size = new System.Drawing.Size(25, 26);
            this.vodFieldsDownButton.TabIndex = 5;
            this.vodFieldsDownButton.Text = "∨";
            this.vodFieldsDownButton.UseVisualStyleBackColor = true;
            this.vodFieldsDownButton.Click += new System.EventHandler(this.fieldsDownButton_Click);
            // 
            // clipFieldsUpButton
            // 
            this.clipFieldsUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clipFieldsUpButton.Location = new System.Drawing.Point(463, 216);
            this.clipFieldsUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.clipFieldsUpButton.Name = "clipFieldsUpButton";
            this.clipFieldsUpButton.Size = new System.Drawing.Size(25, 26);
            this.clipFieldsUpButton.TabIndex = 4;
            this.clipFieldsUpButton.Text = "∧";
            this.clipFieldsUpButton.UseVisualStyleBackColor = true;
            this.clipFieldsUpButton.Click += new System.EventHandler(this.fieldsUpButton_Click);
            // 
            // vodClipsLabel
            // 
            this.vodClipsLabel.AutoSize = true;
            this.vodClipsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vodClipsLabel.Location = new System.Drawing.Point(0, 20);
            this.vodClipsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.vodClipsLabel.Name = "vodClipsLabel";
            this.vodClipsLabel.Size = new System.Drawing.Size(128, 20);
            this.vodClipsLabel.TabIndex = 6;
            this.vodClipsLabel.Text = "Hidden Fields";
            this.vodClipsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clipFieldsLabel
            // 
            this.clipFieldsLabel.AutoSize = true;
            this.clipFieldsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipFieldsLabel.Location = new System.Drawing.Point(279, 20);
            this.clipFieldsLabel.Name = "clipFieldsLabel";
            this.clipFieldsLabel.Size = new System.Drawing.Size(122, 20);
            this.clipFieldsLabel.TabIndex = 7;
            this.clipFieldsLabel.Text = "Hidden Fields";
            this.clipFieldsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clipFieldsSelected
            // 
            this.fieldsPanel.SetColumnSpan(this.clipFieldsSelected, 2);
            this.clipFieldsSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipFieldsSelected.FormattingEnabled = true;
            this.clipFieldsSelected.IntegralHeight = false;
            this.clipFieldsSelected.ItemHeight = 15;
            this.clipFieldsSelected.Location = new System.Drawing.Point(424, 40);
            this.clipFieldsSelected.Margin = new System.Windows.Forms.Padding(0);
            this.clipFieldsSelected.Name = "clipFieldsSelected";
            this.fieldsPanel.SetRowSpan(this.clipFieldsSelected, 2);
            this.clipFieldsSelected.Size = new System.Drawing.Size(129, 176);
            this.clipFieldsSelected.TabIndex = 3;
            // 
            // vodFieldsSelected
            // 
            this.fieldsPanel.SetColumnSpan(this.vodFieldsSelected, 2);
            this.vodFieldsSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vodFieldsSelected.FormattingEnabled = true;
            this.vodFieldsSelected.IntegralHeight = false;
            this.vodFieldsSelected.ItemHeight = 15;
            this.vodFieldsSelected.Location = new System.Drawing.Point(148, 40);
            this.vodFieldsSelected.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.vodFieldsSelected.Name = "vodFieldsSelected";
            this.fieldsPanel.SetRowSpan(this.vodFieldsSelected, 2);
            this.vodFieldsSelected.Size = new System.Drawing.Size(125, 176);
            this.vodFieldsSelected.TabIndex = 1;
            // 
            // vodFieldsUpButton
            // 
            this.vodFieldsUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vodFieldsUpButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vodFieldsUpButton.Location = new System.Drawing.Point(187, 216);
            this.vodFieldsUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.vodFieldsUpButton.Name = "vodFieldsUpButton";
            this.vodFieldsUpButton.Size = new System.Drawing.Size(25, 26);
            this.vodFieldsUpButton.TabIndex = 2;
            this.vodFieldsUpButton.Text = "∧";
            this.vodFieldsUpButton.UseVisualStyleBackColor = true;
            this.vodFieldsUpButton.Click += new System.EventHandler(this.fieldsUpButton_Click);
            // 
            // vodFieldsRemoveButton
            // 
            this.vodFieldsRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vodFieldsRemoveButton.Location = new System.Drawing.Point(128, 128);
            this.vodFieldsRemoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.vodFieldsRemoveButton.Name = "vodFieldsRemoveButton";
            this.vodFieldsRemoveButton.Size = new System.Drawing.Size(20, 23);
            this.vodFieldsRemoveButton.TabIndex = 8;
            this.vodFieldsRemoveButton.Text = "<";
            this.vodFieldsRemoveButton.UseVisualStyleBackColor = true;
            this.vodFieldsRemoveButton.Click += new System.EventHandler(this.fieldsRemoveButton_Click);
            // 
            // clipFieldsRemoveButton
            // 
            this.clipFieldsRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clipFieldsRemoveButton.Location = new System.Drawing.Point(404, 128);
            this.clipFieldsRemoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.clipFieldsRemoveButton.Name = "clipFieldsRemoveButton";
            this.clipFieldsRemoveButton.Size = new System.Drawing.Size(20, 23);
            this.clipFieldsRemoveButton.TabIndex = 9;
            this.clipFieldsRemoveButton.Text = "<";
            this.clipFieldsRemoveButton.UseVisualStyleBackColor = true;
            this.clipFieldsRemoveButton.Click += new System.EventHandler(this.fieldsRemoveButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(8, 476);
            this.saveButton.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.fieldsPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(148, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Displayed Fields";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.fieldsPanel.SetColumnSpan(this.label2, 4);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "VOD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.fieldsPanel.SetColumnSpan(this.label3, 4);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(279, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Clip";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.fieldsPanel.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(427, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Displayed Fields";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.helpFlow.ResumeLayout(false);
            this.helpFlow.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.fieldsPanel.ResumeLayout(false);
            this.fieldsPanel.PerformLayout();
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
    }
}