
namespace Twitch_Clip_Grabber
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.clipTitle = new System.Windows.Forms.ColumnHeader();
            this.creator = new System.Windows.Forms.ColumnHeader();
            this.clipDate = new System.Windows.Forms.ColumnHeader();
            this.offset = new System.Windows.Forms.ColumnHeader();
            this.submit = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.title = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.viewDropDown = new System.Windows.Forms.ComboBox();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.clipButtons = new System.Windows.Forms.TableLayoutPanel();
            this.deselectAllButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.getClipsButton = new System.Windows.Forms.Button();
            this.downloadTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.clipButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(66, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 94);
            this.button1.TabIndex = 10;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(103, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 94);
            this.button2.TabIndex = 11;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.CheckBoxes = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clipTitle,
            this.creator,
            this.clipDate,
            this.offset});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(516, 37);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(510, 481);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView2_ItemChecked);
            // 
            // clipTitle
            // 
            this.clipTitle.Text = "Title";
            this.clipTitle.Width = 150;
            // 
            // creator
            // 
            this.creator.Text = "Creator";
            this.creator.Width = 140;
            // 
            // clipDate
            // 
            this.clipDate.Text = "Date";
            this.clipDate.Width = 100;
            // 
            // offset
            // 
            this.offset.Text = "Timestamp";
            this.offset.Width = 100;
            // 
            // submit
            // 
            this.submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submit.Location = new System.Drawing.Point(414, 3);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(96, 28);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.username.Location = new System.Drawing.Point(85, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(323, 23);
            this.username.TabIndex = 0;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username_label.Location = new System.Drawing.Point(3, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(76, 34);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Username";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.date});
            this.mainLayout.SetColumnSpan(this.listView1, 3);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 37);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 481);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // viewDropDown
            // 
            this.viewDropDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.viewDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewDropDown.DropDownWidth = 100;
            this.viewDropDown.FormattingEnabled = true;
            this.viewDropDown.Items.AddRange(new object[] {
            "Large Icon",
            "Small Icon",
            "Details",
            "List",
            "Tile"});
            this.viewDropDown.Location = new System.Drawing.Point(1008, 5);
            this.viewDropDown.Name = "viewDropDown";
            this.viewDropDown.Size = new System.Drawing.Size(18, 23);
            this.viewDropDown.TabIndex = 9;
            this.viewDropDown.SelectedIndexChanged += new System.EventHandler(this.viewDropDown_SelectedIndexChanged);
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 4;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.username_label, 0, 0);
            this.mainLayout.Controls.Add(this.clipButtons, 3, 2);
            this.mainLayout.Controls.Add(this.listView2, 3, 1);
            this.mainLayout.Controls.Add(this.username, 1, 0);
            this.mainLayout.Controls.Add(this.submit, 2, 0);
            this.mainLayout.Controls.Add(this.viewDropDown, 3, 0);
            this.mainLayout.Controls.Add(this.listView1, 0, 1);
            this.mainLayout.Controls.Add(this.getClipsButton, 2, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.61404F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.421053F));
            this.mainLayout.Size = new System.Drawing.Size(1029, 570);
            this.mainLayout.TabIndex = 14;
            // 
            // clipButtons
            // 
            this.clipButtons.ColumnCount = 3;
            this.clipButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.clipButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.clipButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clipButtons.Controls.Add(this.deselectAllButton, 0, 0);
            this.clipButtons.Controls.Add(this.selectAllButton, 0, 0);
            this.clipButtons.Controls.Add(this.downloadButton, 2, 0);
            this.clipButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipButtons.Location = new System.Drawing.Point(516, 524);
            this.clipButtons.Name = "clipButtons";
            this.clipButtons.RowCount = 1;
            this.clipButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clipButtons.Size = new System.Drawing.Size(510, 43);
            this.clipButtons.TabIndex = 13;
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deselectAllButton.Location = new System.Drawing.Point(130, 3);
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(121, 37);
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
            this.selectAllButton.Size = new System.Drawing.Size(121, 37);
            this.selectAllButton.TabIndex = 12;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.downloadButton.Location = new System.Drawing.Point(257, 3);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(115, 37);
            this.downloadButton.TabIndex = 11;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // getClipsButton
            // 
            this.getClipsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getClipsButton.Location = new System.Drawing.Point(414, 524);
            this.getClipsButton.Name = "getClipsButton";
            this.getClipsButton.Size = new System.Drawing.Size(96, 43);
            this.getClipsButton.TabIndex = 14;
            this.getClipsButton.Text = "Get Clips>>>";
            this.getClipsButton.UseVisualStyleBackColor = true;
            this.getClipsButton.Click += new System.EventHandler(this.getClipsButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.mainLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.clipButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ListView2_ItemChecked(object sender, System.Windows.Forms.ItemCheckedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ListView2_SelectClick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ListView1_DrawItem(object sender, System.Windows.Forms.DrawListViewItemEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader clipTitle;
        private System.Windows.Forms.ColumnHeader creator;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.ComboBox viewDropDown;
        private System.Windows.Forms.Button getClipsButton;
        private System.Windows.Forms.ColumnHeader clipDate;
        private System.Windows.Forms.TableLayoutPanel clipButtons;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.FolderBrowserDialog downloadTarget;
        private System.Windows.Forms.Button deselectAllButton;
        private System.Windows.Forms.ColumnHeader offset;
    }
}

