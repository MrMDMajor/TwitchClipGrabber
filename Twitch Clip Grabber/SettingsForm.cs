using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TwitchClipGrabber
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.formatText.Text = Properties.Settings.Default.FilenameFormat;
            downloadQuality.DataSource = new BindingSource(new Dictionary<string, string>()
            {
                { "1080p", "1080" },
                { "720p", "720" },
                { "480p", "480" },
                { "360p", "360" }
            }, null);
            downloadQuality.DisplayMember = "Key";
            downloadQuality.ValueMember = "Value";
            downloadQuality.SelectedValue = Properties.Settings.Default.DownloadQuality;
            vodFieldsSourceBox.Items.Clear();
            clipFieldsSourceBox.Items.Clear();

            var form1 = Application.OpenForms["Form1"] as Form1;

            foreach (KeyValuePair<string, int> i in form1.vodDict)
            {
                vodFieldsSourceBox.Items.Add(i.Key);
            }
            foreach (KeyValuePair<string, int> i in form1.clipDict)
            {
                if (i.Key != "")
                {
                    clipFieldsSourceBox.Items.Add(i.Key);
                }
            }
            foreach (var i in Properties.Settings.Default.VODFields)
            {
                vodFieldsSelected.Items.Add(i);
                vodFieldsSourceBox.Items.Remove(i);
            }
            foreach (var i in Properties.Settings.Default.ClipFields)
            {
                clipFieldsSelected.Items.Add(i);
                clipFieldsSourceBox.Items.Remove(i);
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (helpFlow.Visible) helpFlow.Hide();
            else helpFlow.Show();
        }

        private void formatText_TextChanged(object sender, EventArgs e)
        {
            exampleText.Text = UserSettings.FormatFilename(ExampleClip.clip, formatText.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FilenameFormat = formatText.Text;
            Properties.Settings.Default.DownloadQuality = downloadQuality.SelectedValue.ToString();
            Properties.Settings.Default.VODFields.Clear();
            Properties.Settings.Default.ClipFields.Clear();
            Properties.Settings.Default.VODFields.AddRange(vodFieldsSelected.Items.Cast<string>().ToArray());
            Properties.Settings.Default.ClipFields.AddRange(clipFieldsSelected.Items.Cast<string>().ToArray());
            Properties.Settings.Default.Save();
            (Application.OpenForms["Form1"] as Form1).UpdateListViews();
            this.Close();
        }

        private void fieldsAddButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            ListBox selected, source;
            if (button.Name == "vodFieldsAddButton")
            {
                selected = vodFieldsSelected;
                source = vodFieldsSourceBox;
            }
            else
            {
                selected = clipFieldsSelected;
                source = clipFieldsSourceBox;
            }
            if (source.SelectedItem != null)
            {
                selected.Items.Add(source.SelectedItem);
                selected.SelectedItem = source.SelectedItem;
                source.Items.Remove(source.SelectedItem);
            }
        }

        private void fieldsRemoveButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            ListBox selected, source;
            if (button.Name == "vodFieldsRemoveButton")
            {
                selected = vodFieldsSelected;
                source = vodFieldsSourceBox;
            }
            else
            {
                selected = clipFieldsSelected;
                source = clipFieldsSourceBox;
            }
            if (selected.SelectedItem != null)
            {
                source.Items.Add(selected.SelectedItem);
                var index = selected.SelectedIndex;
                selected.Items.Remove(selected.SelectedItem);
                selected.SelectedItem = index != 0 ? selected.Items[index - 1] : selected.Items.Count < 1 ? null : selected.Items[0];
            }
        }

        private void fieldsUpButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            ListBox selected = button.Name == "vodFieldsUpButton" ? vodFieldsSelected : clipFieldsSelected;
            var selectedItem = selected.SelectedItem;
            var index = selected.SelectedIndex;
            if (index > 0 && selected != null)
            {
                selected.Items.Remove(selectedItem);
                selected.Items.Insert(index - 1, selectedItem);
                selected.SelectedItem = selectedItem;
            }
        }

        private void fieldsDownButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            ListBox selected = button.Name == "vodFieldsDownButton" ? vodFieldsSelected : clipFieldsSelected;
            var selectedItem = selected.SelectedItem;
            var index = selected.SelectedIndex;
            if (index < selected.Items.Count && selected != null)
            {
                selected.Items.Remove(selectedItem);
                selected.Items.Insert(index + 1, selectedItem);
                selected.SelectedItem = selectedItem;
            }
        }

        private void downloadQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(downloadQuality.SelectedValue);
        }
    }
}
