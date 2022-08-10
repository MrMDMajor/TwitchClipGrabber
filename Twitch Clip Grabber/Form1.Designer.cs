
namespace TwitchClipGrabber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.title = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.clipTitle = new System.Windows.Forms.ColumnHeader();
            this.creator = new System.Windows.Forms.ColumnHeader();
            this.clipDate = new System.Windows.Forms.ColumnHeader();
            this.offset = new System.Windows.Forms.ColumnHeader();
            this.length = new System.Windows.Forms.ColumnHeader();
            this.preview = new System.Windows.Forms.ColumnHeader();
            this.videoEmbed = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.clipButtons = new System.Windows.Forms.TableLayoutPanel();
            this.deselectAllButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.authorizeButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.getClipsButton = new System.Windows.Forms.Button();
            this.downloadTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoEmbed)).BeginInit();
            this.clipButtons.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 54);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submit.Location = new System.Drawing.Point(466, 3);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(97, 30);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.username.Location = new System.Drawing.Point(73, 6);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(387, 23);
            this.username.TabIndex = 0;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username_label.Location = new System.Drawing.Point(3, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(64, 36);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Username";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.date});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 36);
            this.listView1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(562, 663);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.getClipsButton_Click);
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 350;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 100;
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 563F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 437F));
            this.mainLayout.Controls.Add(this.rightPanel, 1, 1);
            this.mainLayout.Controls.Add(this.clipButtons, 1, 2);
            this.mainLayout.Controls.Add(this.listView1, 0, 1);
            this.mainLayout.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.mainLayout.Controls.Add(this.inputPanel, 0, 0);
            this.mainLayout.Controls.Add(this.getClipsButton, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 663F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.mainLayout.Size = new System.Drawing.Size(1280, 745);
            this.mainLayout.TabIndex = 14;
            this.mainLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainLayout_MouseDown);
            this.mainLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainLayout_MouseMove);
            this.mainLayout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainLayout_MouseUp);
            // 
            // rightPanel
            // 
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Controls.Add(this.listView2, 0, 1);
            this.rightPanel.Controls.Add(this.videoEmbed, 0, 0);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(564, 36);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 2;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.rightPanel.Size = new System.Drawing.Size(716, 663);
            this.rightPanel.TabIndex = 2;
            // 
            // listView2
            // 
            this.listView2.CheckBoxes = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clipTitle,
            this.creator,
            this.clipDate,
            this.offset,
            this.length,
            this.preview});
            this.rightPanel.SetColumnSpan(this.listView2, 3);
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(1, 298);
            this.listView2.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(715, 365);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // clipTitle
            // 
            this.clipTitle.Text = "Title";
            this.clipTitle.Width = 200;
            // 
            // creator
            // 
            this.creator.Text = "Creator";
            this.creator.Width = 120;
            // 
            // clipDate
            // 
            this.clipDate.Text = "Date";
            this.clipDate.Width = 70;
            // 
            // offset
            // 
            this.offset.Text = "Timestamp";
            this.offset.Width = 75;
            // 
            // length
            // 
            this.length.Text = "Length";
            // 
            // preview
            // 
            this.preview.Text = "";
            this.preview.Width = 70;
            // 
            // videoEmbed
            // 
            this.videoEmbed.AllowExternalDrop = true;
            this.videoEmbed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.videoEmbed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.videoEmbed.CreationProperties = null;
            this.videoEmbed.DefaultBackgroundColor = System.Drawing.Color.White;
            this.videoEmbed.Location = new System.Drawing.Point(118, 0);
            this.videoEmbed.Margin = new System.Windows.Forms.Padding(0);
            this.videoEmbed.Name = "videoEmbed";
            this.videoEmbed.Size = new System.Drawing.Size(480, 298);
            this.videoEmbed.TabIndex = 10;
            this.videoEmbed.ZoomFactor = 1D;
            // 
            // clipButtons
            // 
            this.clipButtons.ColumnCount = 3;
            this.clipButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.clipButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.clipButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 638F));
            this.clipButtons.Controls.Add(this.deselectAllButton, 0, 0);
            this.clipButtons.Controls.Add(this.selectAllButton, 0, 0);
            this.clipButtons.Controls.Add(this.downloadButton, 2, 0);
            this.clipButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipButtons.Location = new System.Drawing.Point(563, 699);
            this.clipButtons.Margin = new System.Windows.Forms.Padding(0);
            this.clipButtons.Name = "clipButtons";
            this.clipButtons.RowCount = 1;
            this.clipButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clipButtons.Size = new System.Drawing.Size(717, 46);
            this.clipButtons.TabIndex = 13;
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deselectAllButton.Location = new System.Drawing.Point(99, 3);
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(90, 40);
            this.deselectAllButton.TabIndex = 13;
            this.deselectAllButton.Text = "Deselect All";
            this.deselectAllButton.UseVisualStyleBackColor = true;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAllButton.Location = new System.Drawing.Point(3, 3);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(90, 40);
            this.selectAllButton.TabIndex = 12;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.downloadButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.downloadButton.Location = new System.Drawing.Point(195, 3);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(117, 40);
            this.downloadButton.TabIndex = 11;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.settingsButton);
            this.flowLayoutPanel1.Controls.Add(this.authorizeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(563, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(717, 36);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.settingsButton.Location = new System.Drawing.Point(639, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // authorizeButton
            // 
            this.authorizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.authorizeButton.Location = new System.Drawing.Point(550, 3);
            this.authorizeButton.Name = "authorizeButton";
            this.authorizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.authorizeButton.Size = new System.Drawing.Size(83, 23);
            this.authorizeButton.TabIndex = 0;
            this.authorizeButton.Text = "Authenticate";
            this.authorizeButton.UseVisualStyleBackColor = true;
            this.authorizeButton.Click += new System.EventHandler(this.authorizeButton_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.ColumnCount = 3;
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.inputPanel.Controls.Add(this.username, 1, 0);
            this.inputPanel.Controls.Add(this.username_label, 0, 0);
            this.inputPanel.Controls.Add(this.submit, 2, 0);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.RowCount = 1;
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputPanel.Size = new System.Drawing.Size(563, 36);
            this.inputPanel.TabIndex = 16;
            // 
            // getClipsButton
            // 
            this.getClipsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getClipsButton.Location = new System.Drawing.Point(466, 702);
            this.getClipsButton.Name = "getClipsButton";
            this.getClipsButton.Size = new System.Drawing.Size(94, 40);
            this.getClipsButton.TabIndex = 17;
            this.getClipsButton.Text = "Get Clips";
            this.getClipsButton.UseVisualStyleBackColor = true;
            this.getClipsButton.Click += new System.EventHandler(this.getClipsButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 745);
            this.Controls.Add(this.mainLayout);
            this.Name = "Form1";
            this.Text = "Twitch Clip Grabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoEmbed)).EndInit();
            this.clipButtons.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.FolderBrowserDialog downloadTarget;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader clipTitle;
        private System.Windows.Forms.ColumnHeader creator;
        private System.Windows.Forms.ColumnHeader clipDate;
        private System.Windows.Forms.ColumnHeader offset;
        private System.Windows.Forms.ColumnHeader length;
        private System.Windows.Forms.ColumnHeader preview;
        private Microsoft.Web.WebView2.WinForms.WebView2 videoEmbed;
        private System.Windows.Forms.TableLayoutPanel clipButtons;
        private System.Windows.Forms.Button deselectAllButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button authorizeButton;
        private System.Windows.Forms.TableLayoutPanel inputPanel;
        private System.Windows.Forms.Button getClipsButton;
    }
}

