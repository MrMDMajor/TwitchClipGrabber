
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            submit = new System.Windows.Forms.Button();
            username = new System.Windows.Forms.TextBox();
            listView1 = new CustomListView();
            vodTitle = new System.Windows.Forms.ColumnHeader();
            vodDateCreated = new System.Windows.Forms.ColumnHeader();
            vodDuration = new System.Windows.Forms.ColumnHeader();
            mainLayout = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            settingsButton = new System.Windows.Forms.Button();
            authorizeButton = new System.Windows.Forms.Button();
            inputPanel = new System.Windows.Forms.TableLayoutPanel();
            username_label = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            downloadButton = new System.Windows.Forms.Button();
            deselectAllButton = new System.Windows.Forms.Button();
            selectAllButton = new System.Windows.Forms.Button();
            playSelectedButton = new System.Windows.Forms.Button();
            progressStatusStrip = new System.Windows.Forms.StatusStrip();
            progressBar = new System.Windows.Forms.ToolStripProgressBar();
            progressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            mainPanels = new System.Windows.Forms.TableLayoutPanel();
            rightPanel = new System.Windows.Forms.TableLayoutPanel();
            listView2 = new CustomListView();
            clipTitle = new System.Windows.Forms.ColumnHeader();
            clipCreator = new System.Windows.Forms.ColumnHeader();
            clipDate = new System.Windows.Forms.ColumnHeader();
            clipVodTimestamp = new System.Windows.Forms.ColumnHeader();
            clipDuration = new System.Windows.Forms.ColumnHeader();
            embedPanel = new System.Windows.Forms.TableLayoutPanel();
            videoEmbed = new Microsoft.Web.WebView2.WinForms.WebView2();
            leftButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            getClipsButton = new System.Windows.Forms.Button();
            downloadTarget = new System.Windows.Forms.FolderBrowserDialog();
            tableLayoutPanel1.SuspendLayout();
            mainLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            inputPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            progressStatusStrip.SuspendLayout();
            mainPanels.SuspendLayout();
            rightPanel.SuspendLayout();
            embedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoEmbed).BeginInit();
            leftButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Fill;
            button1.Location = new System.Drawing.Point(3, 43);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 54);
            button1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(20, 20);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 0;
            // 
            // submit
            // 
            submit.Dock = System.Windows.Forms.DockStyle.Fill;
            submit.Location = new System.Drawing.Point(484, 3);
            submit.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            submit.Name = "submit";
            submit.Size = new System.Drawing.Size(119, 30);
            submit.TabIndex = 2;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // username
            // 
            username.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            username.Location = new System.Drawing.Point(73, 6);
            username.Name = "username";
            username.Size = new System.Drawing.Size(405, 23);
            username.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { vodTitle, vodDateCreated, vodDuration });
            listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new System.Drawing.Point(0, 0);
            listView1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(602, 673);
            listView1.SortedColumnIndex = -1;
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            listView1.ColumnWidthChanged += listView_ColumnWidthChanged;
            listView1.MouseDoubleClick += getClipsButton_Click;
            // 
            // vodTitle
            // 
            vodTitle.Text = "Title";
            vodTitle.Width = 350;
            // 
            // vodDateCreated
            // 
            vodDateCreated.Text = "Date Created";
            vodDateCreated.Width = 100;
            // 
            // vodDuration
            // 
            vodDuration.Text = "Duration";
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            mainLayout.Controls.Add(tableLayoutPanel2, 1, 0);
            mainLayout.Controls.Add(inputPanel, 0, 0);
            mainLayout.Controls.Add(flowLayoutPanel2, 1, 2);
            mainLayout.Controls.Add(mainPanels, 0, 1);
            mainLayout.Controls.Add(leftButtonPanel, 0, 2);
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.Location = new System.Drawing.Point(0, 0);
            mainLayout.Margin = new System.Windows.Forms.Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            mainLayout.Size = new System.Drawing.Size(1341, 745);
            mainLayout.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(settingsButton, 2, 0);
            tableLayoutPanel2.Controls.Add(authorizeButton, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(603, 0);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(738, 36);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // settingsButton
            // 
            settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            settingsButton.Location = new System.Drawing.Point(651, 3);
            settingsButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new System.Drawing.Size(86, 30);
            settingsButton.TabIndex = 1;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // authorizeButton
            // 
            authorizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            authorizeButton.Location = new System.Drawing.Point(563, 3);
            authorizeButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            authorizeButton.Name = "authorizeButton";
            authorizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            authorizeButton.Size = new System.Drawing.Size(86, 30);
            authorizeButton.TabIndex = 0;
            authorizeButton.Text = "Authenticate";
            authorizeButton.UseVisualStyleBackColor = true;
            authorizeButton.Click += authorizeButton_Click;
            // 
            // inputPanel
            // 
            inputPanel.ColumnCount = 3;
            inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            inputPanel.Controls.Add(username, 1, 0);
            inputPanel.Controls.Add(username_label, 0, 0);
            inputPanel.Controls.Add(submit, 2, 0);
            inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            inputPanel.Location = new System.Drawing.Point(0, 0);
            inputPanel.Margin = new System.Windows.Forms.Padding(0);
            inputPanel.Name = "inputPanel";
            inputPanel.RowCount = 1;
            inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            inputPanel.Size = new System.Drawing.Size(603, 36);
            inputPanel.TabIndex = 16;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Dock = System.Windows.Forms.DockStyle.Fill;
            username_label.Location = new System.Drawing.Point(3, 0);
            username_label.Name = "username_label";
            username_label.Size = new System.Drawing.Size(64, 36);
            username_label.TabIndex = 1;
            username_label.Text = "Username";
            username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(downloadButton);
            flowLayoutPanel2.Controls.Add(deselectAllButton);
            flowLayoutPanel2.Controls.Add(selectAllButton);
            flowLayoutPanel2.Controls.Add(playSelectedButton);
            flowLayoutPanel2.Controls.Add(progressStatusStrip);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new System.Drawing.Point(603, 709);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(738, 36);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // downloadButton
            // 
            downloadButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            downloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            downloadButton.ForeColor = System.Drawing.SystemColors.ControlText;
            downloadButton.Location = new System.Drawing.Point(620, 3);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new System.Drawing.Size(115, 30);
            downloadButton.TabIndex = 11;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = false;
            downloadButton.Click += downloadButton_Click;
            // 
            // deselectAllButton
            // 
            deselectAllButton.BackColor = System.Drawing.SystemColors.ControlLight;
            deselectAllButton.Location = new System.Drawing.Point(524, 3);
            deselectAllButton.Name = "deselectAllButton";
            deselectAllButton.Size = new System.Drawing.Size(90, 30);
            deselectAllButton.TabIndex = 13;
            deselectAllButton.Text = "Uncheck All";
            deselectAllButton.UseVisualStyleBackColor = false;
            deselectAllButton.Click += deselectAllButton_Click;
            // 
            // selectAllButton
            // 
            selectAllButton.Location = new System.Drawing.Point(428, 3);
            selectAllButton.Name = "selectAllButton";
            selectAllButton.Size = new System.Drawing.Size(90, 30);
            selectAllButton.TabIndex = 12;
            selectAllButton.Text = "Check All";
            selectAllButton.UseVisualStyleBackColor = true;
            selectAllButton.Click += selectAllButton_Click;
            // 
            // playSelectedButton
            // 
            playSelectedButton.Location = new System.Drawing.Point(315, 3);
            playSelectedButton.Name = "playSelectedButton";
            playSelectedButton.Size = new System.Drawing.Size(107, 30);
            playSelectedButton.TabIndex = 14;
            playSelectedButton.Text = "Preview Selected";
            playSelectedButton.UseVisualStyleBackColor = true;
            playSelectedButton.Click += preview_Click;
            // 
            // progressStatusStrip
            // 
            progressStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { progressBar, progressLabel });
            progressStatusStrip.Location = new System.Drawing.Point(125, 6);
            progressStatusStrip.Name = "progressStatusStrip";
            progressStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            progressStatusStrip.Size = new System.Drawing.Size(150, 30);
            progressStatusStrip.SizingGrip = false;
            progressStatusStrip.TabIndex = 15;
            progressStatusStrip.Text = "statusStrip1";
            progressStatusStrip.Visible = false;
            // 
            // progressBar
            // 
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(100, 24);
            // 
            // progressLabel
            // 
            progressLabel.Name = "progressLabel";
            progressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            progressLabel.Size = new System.Drawing.Size(0, 25);
            progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            progressLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            progressLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mainPanels
            // 
            mainPanels.ColumnCount = 2;
            mainLayout.SetColumnSpan(mainPanels, 2);
            mainPanels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            mainPanels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            mainPanels.Controls.Add(rightPanel, 0, 0);
            mainPanels.Controls.Add(listView1, 0, 0);
            mainPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanels.Location = new System.Drawing.Point(0, 36);
            mainPanels.Margin = new System.Windows.Forms.Padding(0);
            mainPanels.Name = "mainPanels";
            mainPanels.RowCount = 1;
            mainPanels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mainPanels.Size = new System.Drawing.Size(1341, 673);
            mainPanels.TabIndex = 17;
            mainPanels.MouseDown += mainPanels_MouseDown;
            mainPanels.MouseLeave += mainPanels_MouseLeave;
            mainPanels.MouseMove += mainPanels_MouseMove;
            mainPanels.MouseUp += mainPanels_MouseUp;
            // 
            // rightPanel
            // 
            rightPanel.ColumnCount = 1;
            rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rightPanel.Controls.Add(listView2, 0, 1);
            rightPanel.Controls.Add(embedPanel, 0, 0);
            rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            rightPanel.Location = new System.Drawing.Point(606, 0);
            rightPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.RowCount = 2;
            rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            rightPanel.Size = new System.Drawing.Size(735, 673);
            rightPanel.TabIndex = 2;
            rightPanel.MouseDown += rightPanel_MouseDown;
            rightPanel.MouseLeave += mainPanels_MouseLeave;
            rightPanel.MouseMove += rightPanel_MouseMove;
            rightPanel.MouseUp += mainPanels_MouseUp;
            // 
            // listView2
            // 
            listView2.CheckBoxes = true;
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { clipTitle, clipCreator, clipDate, clipVodTimestamp, clipDuration });
            rightPanel.SetColumnSpan(listView2, 3);
            listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            listView2.FullRowSelect = true;
            listView2.Location = new System.Drawing.Point(0, 406);
            listView2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(735, 267);
            listView2.SortedColumnIndex = -1;
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            listView2.ColumnClick += listView2_ColumnClick;
            listView2.ColumnWidthChanged += listView_ColumnWidthChanged;
            listView2.DoubleClick += preview_Click;
            // 
            // clipTitle
            // 
            clipTitle.Text = "Title";
            clipTitle.Width = 290;
            // 
            // clipCreator
            // 
            clipCreator.Text = "Creator";
            clipCreator.Width = 120;
            // 
            // clipDate
            // 
            clipDate.Text = "VOD Date";
            clipDate.Width = 70;
            // 
            // clipVodTimestamp
            // 
            clipVodTimestamp.Text = "VOD Timestamp";
            clipVodTimestamp.Width = 75;
            // 
            // clipDuration
            // 
            clipDuration.Text = "Duration";
            // 
            // embedPanel
            // 
            embedPanel.ColumnCount = 1;
            embedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            embedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            embedPanel.Controls.Add(videoEmbed, 0, 0);
            embedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            embedPanel.Location = new System.Drawing.Point(0, 0);
            embedPanel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            embedPanel.Name = "embedPanel";
            embedPanel.RowCount = 1;
            embedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            embedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 403F));
            embedPanel.Size = new System.Drawing.Size(732, 403);
            embedPanel.TabIndex = 18;
            embedPanel.Resize += embedPanel_Resize;
            // 
            // videoEmbed
            // 
            videoEmbed.AllowExternalDrop = true;
            videoEmbed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            videoEmbed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            videoEmbed.CreationProperties = null;
            videoEmbed.DefaultBackgroundColor = System.Drawing.Color.Black;
            videoEmbed.Location = new System.Drawing.Point(22, 0);
            videoEmbed.Margin = new System.Windows.Forms.Padding(0);
            videoEmbed.Name = "videoEmbed";
            videoEmbed.Size = new System.Drawing.Size(688, 403);
            videoEmbed.TabIndex = 10;
            videoEmbed.ZoomFactor = 1D;
            // 
            // leftButtonPanel
            // 
            leftButtonPanel.Controls.Add(getClipsButton);
            leftButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            leftButtonPanel.Location = new System.Drawing.Point(0, 709);
            leftButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            leftButtonPanel.Name = "leftButtonPanel";
            leftButtonPanel.Size = new System.Drawing.Size(603, 36);
            leftButtonPanel.TabIndex = 18;
            // 
            // getClipsButton
            // 
            getClipsButton.Location = new System.Drawing.Point(3, 3);
            getClipsButton.Name = "getClipsButton";
            getClipsButton.Size = new System.Drawing.Size(94, 30);
            getClipsButton.TabIndex = 18;
            getClipsButton.Text = "Get Clips";
            getClipsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = submit;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1341, 745);
            Controls.Add(mainLayout);
            Name = "Form1";
            Text = "Twitch Clip Grabber";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Shown += CheckToken;
            tableLayoutPanel1.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            progressStatusStrip.ResumeLayout(false);
            progressStatusStrip.PerformLayout();
            mainPanels.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            embedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)videoEmbed).EndInit();
            leftButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox username;
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
        private System.Windows.Forms.Button authorizeButton;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.FlowLayoutPanel leftButtonPanel;
        private System.Windows.Forms.Button getClipsButton;
    }
}

