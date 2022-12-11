
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
            this.listView1 = new TwitchClipGrabber.CustomListView();
            this.vodTitle = new System.Windows.Forms.ColumnHeader();
            this.vodDateCreated = new System.Windows.Forms.ColumnHeader();
            this.vodDuration = new System.Windows.Forms.ColumnHeader();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.idSubmitButton = new System.Windows.Forms.Button();
            this.authorizeButton = new System.Windows.Forms.Button();
            this.idText_label = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.inputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.downloadButton = new System.Windows.Forms.Button();
            this.deselectAllButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.playSelectedButton = new System.Windows.Forms.Button();
            this.progressStatusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.progressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanels = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listView2 = new TwitchClipGrabber.CustomListView();
            this.clipTitle = new System.Windows.Forms.ColumnHeader();
            this.clipCreator = new System.Windows.Forms.ColumnHeader();
            this.clipDate = new System.Windows.Forms.ColumnHeader();
            this.clipVodTimestamp = new System.Windows.Forms.ColumnHeader();
            this.clipDuration = new System.Windows.Forms.ColumnHeader();
            this.embedPanel = new System.Windows.Forms.TableLayoutPanel();
            this.videoEmbed = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.getClipsButton = new System.Windows.Forms.Button();
            this.downloadTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.progressStatusStrip.SuspendLayout();
            this.mainPanels.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.embedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoEmbed)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.submit.Location = new System.Drawing.Point(450, 3);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(119, 30);
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
            this.username.Size = new System.Drawing.Size(371, 23);
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
            this.username_label.Text = "Search by Username";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vodTitle,
            this.vodDateCreated,
            this.vodDuration});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 631);
            this.listView1.SortedColumnIndex = -1;
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listView_ColumnWidthChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.getClipsButton_Click);
            // 
            // vodTitle
            // 
            this.vodTitle.Text = "Title";
            this.vodTitle.Width = 350;
            // 
            // vodDateCreated
            // 
            this.vodDateCreated.Text = "Date Created";
            this.vodDateCreated.Width = 100;
            // 
            // vodDuration
            // 
            this.vodDuration.Text = "Duration";
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.mainLayout.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.mainLayout.Controls.Add(this.inputPanel, 0, 0);
            this.mainLayout.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.mainLayout.Controls.Add(this.mainPanels, 0, 1);
            this.mainLayout.Controls.Add(this.getClipsButton, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(1266, 717);
            this.mainLayout.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.Controls.Add(this.settingsButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.idSubmitButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.authorizeButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.idText_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.idText, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(569, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(697, 36);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsButton.Location = new System.Drawing.Point(610, 3);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(86, 30);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // idSubmitButton
            // 
            this.idSubmitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idSubmitButton.Location = new System.Drawing.Point(430, 3);
            this.idSubmitButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.idSubmitButton.Name = "idSubmitButton";
            this.idSubmitButton.Size = new System.Drawing.Size(90, 30);
            this.idSubmitButton.TabIndex = 3;
            this.idSubmitButton.Text = "Submit";
            this.idSubmitButton.UseVisualStyleBackColor = true;
            // 
            // authorizeButton
            // 
            this.authorizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorizeButton.Location = new System.Drawing.Point(522, 3);
            this.authorizeButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.authorizeButton.Name = "authorizeButton";
            this.authorizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.authorizeButton.Size = new System.Drawing.Size(86, 30);
            this.authorizeButton.TabIndex = 0;
            this.authorizeButton.Text = "Authenticate";
            this.authorizeButton.UseVisualStyleBackColor = true;
            this.authorizeButton.Click += new System.EventHandler(this.authorizeButton_Click);
            // 
            // idText_label
            // 
            this.idText_label.AutoSize = true;
            this.idText_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idText_label.Location = new System.Drawing.Point(3, 0);
            this.idText_label.Name = "idText_label";
            this.idText_label.Size = new System.Drawing.Size(61, 36);
            this.idText_label.TabIndex = 2;
            this.idText_label.Text = "Search by Clip ID";
            this.idText_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idText
            // 
            this.idText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idText.Location = new System.Drawing.Point(70, 6);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(356, 23);
            this.idText.TabIndex = 0;
            // 
            // inputPanel
            // 
            this.inputPanel.ColumnCount = 3;
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.inputPanel.Controls.Add(this.username, 1, 0);
            this.inputPanel.Controls.Add(this.username_label, 0, 0);
            this.inputPanel.Controls.Add(this.submit, 2, 0);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.RowCount = 1;
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputPanel.Size = new System.Drawing.Size(569, 36);
            this.inputPanel.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.downloadButton);
            this.flowLayoutPanel2.Controls.Add(this.deselectAllButton);
            this.flowLayoutPanel2.Controls.Add(this.selectAllButton);
            this.flowLayoutPanel2.Controls.Add(this.playSelectedButton);
            this.flowLayoutPanel2.Controls.Add(this.progressStatusStrip);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(569, 667);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(697, 50);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.downloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.downloadButton.Location = new System.Drawing.Point(579, 3);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(115, 44);
            this.downloadButton.TabIndex = 11;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deselectAllButton.Location = new System.Drawing.Point(483, 3);
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(90, 44);
            this.deselectAllButton.TabIndex = 13;
            this.deselectAllButton.Text = "Uncheck All";
            this.deselectAllButton.UseVisualStyleBackColor = false;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(387, 3);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(90, 44);
            this.selectAllButton.TabIndex = 12;
            this.selectAllButton.Text = "Check All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // playSelectedButton
            // 
            this.playSelectedButton.Location = new System.Drawing.Point(274, 3);
            this.playSelectedButton.Name = "playSelectedButton";
            this.playSelectedButton.Size = new System.Drawing.Size(107, 44);
            this.playSelectedButton.TabIndex = 14;
            this.playSelectedButton.Text = "Preview Selected";
            this.playSelectedButton.UseVisualStyleBackColor = true;
            this.playSelectedButton.Click += new System.EventHandler(this.preview_Click);
            // 
            // progressStatusStrip
            // 
            this.progressStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.progressLabel});
            this.progressStatusStrip.Location = new System.Drawing.Point(102, 20);
            this.progressStatusStrip.Name = "progressStatusStrip";
            this.progressStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressStatusStrip.Size = new System.Drawing.Size(173, 30);
            this.progressStatusStrip.SizingGrip = false;
            this.progressStatusStrip.TabIndex = 15;
            this.progressStatusStrip.Text = "statusStrip1";
            this.progressStatusStrip.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 24);
            // 
            // progressLabel
            // 
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressLabel.Size = new System.Drawing.Size(23, 25);
            this.progressLabel.Text = "0%";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.progressLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.progressLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mainPanels
            // 
            this.mainPanels.ColumnCount = 2;
            this.mainLayout.SetColumnSpan(this.mainPanels, 2);
            this.mainPanels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainPanels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.mainPanels.Controls.Add(this.rightPanel, 0, 0);
            this.mainPanels.Controls.Add(this.listView1, 0, 0);
            this.mainPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanels.Location = new System.Drawing.Point(0, 36);
            this.mainPanels.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanels.Name = "mainPanels";
            this.mainPanels.RowCount = 1;
            this.mainPanels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanels.Size = new System.Drawing.Size(1266, 631);
            this.mainPanels.TabIndex = 17;
            this.mainPanels.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanels_MouseDown);
            this.mainPanels.MouseLeave += new System.EventHandler(this.mainPanels_MouseLeave);
            this.mainPanels.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanels_MouseMove);
            this.mainPanels.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanels_MouseUp);
            // 
            // rightPanel
            // 
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Controls.Add(this.listView2, 0, 1);
            this.rightPanel.Controls.Add(this.embedPanel, 0, 0);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(572, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 2;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.rightPanel.Size = new System.Drawing.Size(694, 631);
            this.rightPanel.TabIndex = 2;
            this.rightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightPanel_MouseDown);
            this.rightPanel.MouseLeave += new System.EventHandler(this.mainPanels_MouseLeave);
            this.rightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rightPanel_MouseMove);
            this.rightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanels_MouseUp);
            this.rightPanel.Resize += new System.EventHandler(this.embedPanel_Resize);
            // 
            // listView2
            // 
            this.listView2.CheckBoxes = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clipTitle,
            this.clipCreator,
            this.clipDate,
            this.clipVodTimestamp,
            this.clipDuration});
            this.rightPanel.SetColumnSpan(this.listView2, 3);
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 381);
            this.listView2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(694, 250);
            this.listView2.SortedColumnIndex = -1;
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView2_ColumnClick);
            this.listView2.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listView_ColumnWidthChanged);
            this.listView2.DoubleClick += new System.EventHandler(this.preview_Click);
            // 
            // clipTitle
            // 
            this.clipTitle.Text = "Title";
            this.clipTitle.Width = 290;
            // 
            // clipCreator
            // 
            this.clipCreator.Text = "Creator";
            this.clipCreator.Width = 120;
            // 
            // clipDate
            // 
            this.clipDate.Text = "VOD Date";
            this.clipDate.Width = 70;
            // 
            // clipVodTimestamp
            // 
            this.clipVodTimestamp.Text = "VOD Timestamp";
            this.clipVodTimestamp.Width = 75;
            // 
            // clipDuration
            // 
            this.clipDuration.Text = "Duration";
            // 
            // embedPanel
            // 
            this.embedPanel.ColumnCount = 1;
            this.embedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.embedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.embedPanel.Controls.Add(this.videoEmbed, 0, 0);
            this.embedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.embedPanel.Location = new System.Drawing.Point(0, 0);
            this.embedPanel.Margin = new System.Windows.Forms.Padding(0);
            this.embedPanel.Name = "embedPanel";
            this.embedPanel.RowCount = 1;
            this.embedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.embedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.embedPanel.Size = new System.Drawing.Size(694, 378);
            this.embedPanel.TabIndex = 18;
            this.embedPanel.Resize += new System.EventHandler(this.embedPanel_Resize);
            // 
            // videoEmbed
            // 
            this.videoEmbed.AllowExternalDrop = true;
            this.videoEmbed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.videoEmbed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.videoEmbed.CreationProperties = null;
            this.videoEmbed.DefaultBackgroundColor = System.Drawing.Color.Black;
            this.videoEmbed.Location = new System.Drawing.Point(3, 0);
            this.videoEmbed.Margin = new System.Windows.Forms.Padding(0);
            this.videoEmbed.Name = "videoEmbed";
            this.videoEmbed.Size = new System.Drawing.Size(688, 378);
            this.videoEmbed.TabIndex = 10;
            this.videoEmbed.ZoomFactor = 1D;
            // 
            // getClipsButton
            // 
            this.getClipsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.getClipsButton.Location = new System.Drawing.Point(0, 670);
            this.getClipsButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.getClipsButton.Name = "getClipsButton";
            this.getClipsButton.Size = new System.Drawing.Size(94, 44);
            this.getClipsButton.TabIndex = 17;
            this.getClipsButton.Text = "Get Clips";
            this.getClipsButton.UseVisualStyleBackColor = true;
            this.getClipsButton.Click += new System.EventHandler(this.getClipsButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 745);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.mainLayout);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1266, 717);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 717);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 745);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Twitch Clip Grabber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.CheckToken);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.progressStatusStrip.ResumeLayout(false);
            this.progressStatusStrip.PerformLayout();
            this.mainPanels.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.embedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoEmbed)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label username_label;
        private CustomListView listView1;
        private System.Windows.Forms.ColumnHeader vodTitle;
        private System.Windows.Forms.ColumnHeader vodDateCreated;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.FolderBrowserDialog downloadTarget;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.ColumnHeader clipTitle;
        private System.Windows.Forms.ColumnHeader clipCreator;
        private System.Windows.Forms.ColumnHeader clipDate;
        private System.Windows.Forms.ColumnHeader clipVodTimestamp;
        private System.Windows.Forms.ColumnHeader clipDuration;
        private Microsoft.Web.WebView2.WinForms.WebView2 videoEmbed;
        private System.Windows.Forms.Button deselectAllButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TableLayoutPanel inputPanel;
        private System.Windows.Forms.Button getClipsButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel mainPanels;
        private System.Windows.Forms.TableLayoutPanel embedPanel;
        private System.Windows.Forms.ColumnHeader vodDuration;
        private System.Windows.Forms.Button playSelectedButton;
        public System.Windows.Forms.ToolStripProgressBar progressBar;
        public System.Windows.Forms.ToolStripStatusLabel progressLabel;
        public System.Windows.Forms.StatusStrip progressStatusStrip;
        private CustomListView listView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button idSubmitButton;
        private System.Windows.Forms.Button authorizeButton;
        private System.Windows.Forms.Label idText_label;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

