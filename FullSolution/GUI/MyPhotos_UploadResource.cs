using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    partial class MyPhotos
    {
        private List<Dictionary<string, object>> selectedEntities;

        public void ShowSelectFilePopup()
        {
            saveButton.Enabled = false;
            selectedEntities = new List<Dictionary<string, object>>();

            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPEG Image (*.jpeg)|*.jpeg|JPG Image (*.jpg)|*.jpg|PNG Image (*.png)|*.png|MP4 (*.mp4)|*.mp4|WMV (*.wmv)|*.wmv";
            fileDialog.FilterIndex = 1;
            fileDialog.Multiselect = true;
            fileDialog.RestoreDirectory = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileNames.Length > 0)
                {
                    foreach (var fileName in fileDialog.FileNames)
                    {
                        Dictionary<string, object> fileObjectMeta = new Dictionary<string, object>();

                        fileObjectMeta.Add("name", Path.GetFileName(fileName));
                        fileObjectMeta.Add("description", "");
                        fileObjectMeta.Add("path", Path.GetDirectoryName(fileName));
                        fileObjectMeta.Add("imagePath", fileName);
                        fileObjectMeta.Add("createdAt", DateTime.Now.Date);
                        fileObjectMeta.Add("properties", new List<KeyValuePair<string, string>>());

                        selectedEntities.Add(fileObjectMeta);
                    }

                    UpdateTableView();
                }
            }
        }

        public void ShowSelectFolderPopup()
        {
            saveButton.Enabled = false;
            selectedEntities = new List<Dictionary<string, object>>();

            var folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
            {
                string[] files = Directory.GetFiles(folderDialog.SelectedPath).Where((string f) =>
                {
                    return f.EndsWith(".jpeg") || f.EndsWith(".jpg") || f.EndsWith(".png") || f.EndsWith(".mp4") || f.EndsWith(".wmv");
                }).ToArray();

                if (files.Length > 0)
                {
                    foreach (var fileName in files)
                    {
                        Dictionary<string, object> fileObjectMeta = new Dictionary<string, object>();

                        fileObjectMeta.Add("name", Path.GetFileName(fileName));
                        fileObjectMeta.Add("path", Path.GetDirectoryName(fileName));
                        fileObjectMeta.Add("imagePath", fileName);
                        fileObjectMeta.Add("createdAt", DateTime.Now.Date);
                        fileObjectMeta.Add("properties", new List<KeyValuePair<string, string>>());

                        selectedEntities.Add(fileObjectMeta);
                    }

                    UpdateTableView();
                }
            }
        }

        private void UpdateTableView()
        {
            fileMetaListTable.Controls.Clear();

            fileMetaListTable.RowCount = selectedEntities.Count;
            fileMetaListTable.Size = new Size(addEditTabPageContentWrapper.Width, 160 * fileMetaListTable.RowCount);

            var i = 0;
            foreach (var fileObject in selectedEntities)
            {
                CreateFileMetaCell(i, fileObject);
                i++;
            }

            addEditTabPageContentWrapper.Controls.Clear();
            addEditTabPageContentWrapper.Controls.Add(fileMetaListTable);
            saveButton.Enabled = true;
        }

        private void CreateFileMetaCell(int rowIndex, Dictionary<string, object> fileMeta)
        {
            var fileMetaTable = new TableLayoutPanel();

            fileMetaTable.RowCount = 1;
            fileMetaTable.ColumnCount = 3;
            fileMetaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            fileMetaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            fileMetaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            fileMetaTable.Size = new Size(fileMetaListTable.Width, fileMetaListTable.Height / selectedEntities.Count);

            var primaryFields = new TableLayoutPanel();
            primaryFields.Dock = DockStyle.Fill;
            primaryFields.RowCount = 4;
            primaryFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            primaryFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            primaryFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            primaryFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            primaryFields.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            primaryFields.ColumnCount = 1;

            CreatePrimaryFields(primaryFields, fileMeta);

            var propertyFields = new TableLayoutPanel();
            propertyFields.Dock = DockStyle.Fill;
            propertyFields.RowCount = 2;

            CreatePropertyFields(propertyFields, fileMeta);

            var previewField = new PictureBox();
            previewField.Dock = DockStyle.Fill;

            string filePath = fileMeta["imagePath"].ToString();
            if (filePath.EndsWith(".jpeg") || filePath.EndsWith(".jpg") || filePath.EndsWith(".png"))
            {
                previewField.Load(filePath);
            }

            fileMetaTable.Controls.Add(primaryFields, 0, 0);
            fileMetaTable.Controls.Add(propertyFields, 1, 0);
            fileMetaTable.Controls.Add(previewField, 2, 0);

            fileMetaListTable.Controls.Add(fileMetaTable, 1, rowIndex);
        }

        private void CreatePrimaryFields(TableLayoutPanel primaryFields, Dictionary<string, object> fileMeta)
        {
            var nameLabel = new Label();
            nameLabel.Text = "Nume: " + Path.GetFileName(fileMeta["name"].ToString());
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.ForeColor = Color.White;
            nameLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            nameLabel.AutoSize = true;

            primaryFields.Controls.Add(nameLabel, 0, 0);

            var pathLabel = new Label();
            pathLabel.Text = "Cale: " + Path.GetDirectoryName(fileMeta["path"].ToString());
            pathLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pathLabel.ForeColor = Color.White;
            pathLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            pathLabel.AutoSize = true;

            primaryFields.Controls.Add(pathLabel, 0, 1);

            var createdAtLabel = new Label();
            createdAtLabel.Text = "Data Crearii: " + fileMeta["createdAt"].ToString().Split(" ".ToCharArray()[0])[0];
            createdAtLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createdAtLabel.ForeColor = Color.White;
            createdAtLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            createdAtLabel.AutoSize = true;

            primaryFields.Controls.Add(createdAtLabel, 0, 2);

            TextBox descriptionTextarea = new TextBox();
            descriptionTextarea.MaxLength = 255;
            descriptionTextarea.Multiline = true;
            descriptionTextarea.Dock = DockStyle.Fill;
            descriptionTextarea.TextChanged += (object sender, EventArgs e) => { fileMeta["description"] = descriptionTextarea.Text; };

            if (fileMeta.ContainsKey("description") && fileMeta["description"].ToString().Length > 0)
            {
                descriptionTextarea.Text = fileMeta["description"].ToString();
            }
            else
            {
                descriptionTextarea.Text = "Descrierea (max 255 caractere)";
            }

            primaryFields.Controls.Add(descriptionTextarea);
        }

        private void CreatePropertyFields(TableLayoutPanel propertyFields, Dictionary<string, object> fileMeta)
        {
            List<KeyValuePair<string, string>> properties = (List<KeyValuePair<string, string>>)fileMeta["properties"];
            TableLayoutPanel eav = new TableLayoutPanel();

            eav.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eav.AutoScroll = true;
            eav.ColumnCount = 3;
            eav.RowCount = properties.Count;
            for (var i = 0; i < eav.RowCount; i++)
            {
                Dictionary<string, object> Tag = new Dictionary<string, object>() {
                    { "fileMeta", fileMeta },
                    { "index", i },
                };

                eav.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                ComboBox attribute = new ComboBox();
                attribute.Tag = Tag;
                attribute.TextChanged += CreateAttribute;

                ComboBox value = new ComboBox();
                value.Tag = Tag;
                value.TextChanged += SaveAttributeValue;

                try
                {
                    attribute.Text = properties[i].Key;
                    value.Text = properties[i].Value;
                }
                catch (Exception)
                {
                    // intentionally ignored exception
                }

                Button deleteButton = new Button();
                deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                deleteButton.Text = "X";
                deleteButton.ForeColor = Color.FromArgb(54, 75, 109);
                deleteButton.Tag = Tag;
                deleteButton.Click += handleDeleteAttribute;

                eav.Controls.Add(attribute);
                eav.Controls.Add(value);
                eav.Controls.Add(deleteButton);
            }

            propertyFields.Controls.Add(eav, 0, 0);

            Button plusButton = new Button();
            plusButton.Text = "+ Adauga Proprietate";
            plusButton.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            plusButton.ForeColor = Color.FromArgb(54, 75, 109);
            plusButton.Dock = DockStyle.Fill;
            plusButton.Tag = fileMeta["properties"];
            plusButton.Click += AddPropertyInputs;

            propertyFields.Controls.Add(plusButton, 0, 1);
        }

        private void AddPropertyInputs(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            List<KeyValuePair<string, string>> fileProperties = (List<KeyValuePair<string, string>>)button.Tag;

            fileProperties.Add(new KeyValuePair<string, string>("", ""));

            UpdateTableView();
        }

        private void handleDeleteAttribute(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            Dictionary<string, object> tag = (Dictionary<string, object>)button.Tag;

            ((List<KeyValuePair<string, string>>)(((Dictionary<string, object>)(tag["fileMeta"]))["properties"])).RemoveAt(Convert.ToInt32(tag["index"]));

            UpdateTableView();
        }

        private void CreateAttribute(object sender, EventArgs args)
        {
            ComboBox comboBox = (ComboBox)sender;
            Dictionary<string, object> tag = (Dictionary<string, object>)comboBox.Tag;

            int index = (int)((Dictionary<string, object>)comboBox.Tag)["index"];
            List<KeyValuePair<string, string>> properties = (List<KeyValuePair<string, string>>)((Dictionary<string, object>)tag["fileMeta"])["properties"];
            properties[index] = new KeyValuePair<string, string>(comboBox.Text, properties[index].Value);
        }

        private void SaveAttributeValue(object sender, EventArgs args)
        {
            ComboBox comboBox = (ComboBox)sender;
            Dictionary<string, object> tag = (Dictionary<string, object>)comboBox.Tag;

            int index = (int)((Dictionary<string, object>)comboBox.Tag)["index"];
            List<KeyValuePair<string, string>> properties = (List<KeyValuePair<string, string>>)((Dictionary<string, object>)tag["fileMeta"])["properties"];
            properties[index] = new KeyValuePair<string, string>(properties[index].Key, comboBox.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var tmpSelectedEntities = selectedEntities.ToArray();

            client.saveResources(tmpSelectedEntities);
            navigation.SelectedIndex = 0;

            if (navigation.Tag != null)
            {
                ((Dictionary<string, object>)navigation.Tag).Remove("editObject");
            }

            resources = client.getActiveResources().ToList();

            selectedEntities = new List<Dictionary<string, object>>();

            UpdateListView();
        }

        private void EditFileMeta()
        {
            selectedEntities = new List<Dictionary<string, object>>();

            resource res = (resource)((Dictionary<string, object>)navigation.Tag)["editObject"];
            Dictionary<string, object> fileObjectMeta = new Dictionary<string, object>();

            fileObjectMeta.Add("id", res.Id);
            fileObjectMeta.Add("name", res.name);
            fileObjectMeta.Add("description", res.description);
            fileObjectMeta.Add("path", Path.GetDirectoryName(res.fullpath));
            fileObjectMeta.Add("imagePath", res.fullpath);
            fileObjectMeta.Add("createdAt", res.created_at);
            fileObjectMeta.Add("properties", new List<KeyValuePair<string, string>>());

            foreach (resource_eav eav in res.resource_eav)
            {
                ((List<KeyValuePair<string, string>>)fileObjectMeta["properties"]).Add(new KeyValuePair<string, string>(eav.resource_attributes.attribute, eav.resource_attribute_values.value));
            }

            selectedEntities.Add(fileObjectMeta);

            UpdateTableView();
        }

        // close icon
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            navigation.SelectedIndex = 0;

            if (navigation.Tag != null)
            {
                ((Dictionary<string, object>)navigation.Tag).Remove("editObject");
            }
            selectedEntities = new List<Dictionary<string, object>>();
            UpdateTableView();
        }
    }
}
