using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class MyPhotos : Form
    {
        TableLayoutPanel fileMetaListTable = new TableLayoutPanel();

        private int previousNavigationSelectedIndex = 0;
        private List<resource> resources = new List<resource>();
        readonly WcfServiceReference.ServiceClient client;

        public MyPhotos()
        {
            InitializeComponent();

            navigation.Appearance = TabAppearance.FlatButtons;
            navigation.ItemSize = new Size(0, 1);
            navigation.SizeMode = TabSizeMode.Fixed;
            navigation.TabStop = false;

            navigation.SelectedIndexChanged += handleNavigation;

            fileMetaListTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileMetaListTable.ColumnCount = 1;
            fileMetaListTable.AutoSize = true;
            fileMetaListTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            filter_created_from.Value = DateTime.Today;
            filter_created_to.Value = DateTime.Today.AddDays(1);

            client = new WcfServiceReference.ServiceClient();
        }

        private void MyPhotos_Load(object sender, EventArgs e)
        {
            resources = client.getActiveResources().ToList();

            UpdateListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigation.SelectedIndex = 1;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            ShowSelectFilePopup();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            ShowSelectFolderPopup();
        }

        private void handleNavigation(object sender, EventArgs e)
        {
            if (previousNavigationSelectedIndex == 1 && ((TabControl)sender).SelectedIndex == 0)
            {
                UpdateListView();
            }
        }

        private void UpdateListView()
        {
            Control[] headers = new Control[listResultTable.ColumnCount];
            for (int j = 0; j < listResultTable.ColumnCount; j++)
            {
                headers[j] = listResultTable.Controls[j];
}

            listResultTable.Controls.Clear();
            listResultTable.RowCount = resources.Count + 1;

            foreach (var header in headers)
            {
                listResultTable.Controls.Add(header);
}

            int i = 0;
            foreach (var res in resources)
            {
                i++;

                Label indexLabel = new Label();
                indexLabel.Text = i.ToString();
                indexLabel.Dock = DockStyle.Fill;
                indexLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
                indexLabel.ForeColor = Color.FromArgb(54, 75, 109);
                indexLabel.TextAlign = ContentAlignment.MiddleCenter;
                listResultTable.Controls.Add(indexLabel);

                Label nameLabel = new Label();
                nameLabel.Text = res.name;
                nameLabel.Dock = DockStyle.Fill;
                nameLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
                nameLabel.ForeColor = Color.FromArgb(54, 75, 109);
                nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                listResultTable.Controls.Add(nameLabel);

                Label pathLabel = new Label();
                pathLabel.Dock = DockStyle.Fill;
                if (File.Exists(res.fullpath))
                {
                    pathLabel.Text = res.fullpath;
                    pathLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
                    pathLabel.ForeColor = Color.FromArgb(54, 75, 109);
                }
                else
                {
                    pathLabel.Text = "Fisierul " + res.fullpath + " nu poate fi gasit";
                    pathLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                    pathLabel.ForeColor = Color.Orange;
                }
                pathLabel.TextAlign = ContentAlignment.MiddleCenter;
                listResultTable.Controls.Add(pathLabel);

                Label descriptionLabel = new Label();
                descriptionLabel.Text = res.description;
                descriptionLabel.Dock = DockStyle.Fill;
                descriptionLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
                descriptionLabel.ForeColor = Color.FromArgb(54, 75, 109);
                descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
                listResultTable.Controls.Add(descriptionLabel);

                Label createdAtLabel = new Label();
                createdAtLabel.Text = res.created_at.ToShortDateString();
                createdAtLabel.Dock = DockStyle.Fill;
                createdAtLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
                createdAtLabel.ForeColor = Color.FromArgb(54, 75, 109);
                createdAtLabel.TextAlign = ContentAlignment.MiddleCenter;
                listResultTable.Controls.Add(createdAtLabel);

                Panel propertiesPanel = new Panel();
                propertiesPanel.Dock = DockStyle.Fill;

                TableLayoutPanel propertiesTable = new TableLayoutPanel();
                propertiesTable.ColumnCount = 2;
                propertiesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                propertiesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                propertiesTable.RowCount = res.resource_eav.Count();

                propertiesPanel.Controls.Add(propertiesTable);

                foreach (var eav in res.resource_eav)
                {
                    Label attributeName = new Label();
                    attributeName.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
                    attributeName.ForeColor = Color.FromArgb(54, 75, 109);
                    attributeName.Text = eav.resource_attributes.attribute;

                    propertiesTable.Controls.Add(attributeName);

                    Label attributeValue = new Label();
                    attributeValue.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
                    attributeValue.ForeColor = Color.FromArgb(54, 75, 109);
                    attributeValue.Text = eav.resource_attribute_values.value;

                    propertiesTable.Controls.Add(attributeValue);
                }
                listResultTable.Controls.Add(propertiesPanel);

                TableLayoutPanel actionsTable = new TableLayoutPanel();
                actionsTable.Dock = DockStyle.Fill;
                actionsTable.ColumnCount = 1;
                actionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                actionsTable.RowCount = 2;
                actionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                actionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

                Button editButton = new Button();
                editButton.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                editButton.ForeColor = Color.FromArgb(54, 75, 109);
                editButton.Dock = DockStyle.Fill;
                editButton.Text = "Editeaza";
                editButton.Tag = res;
                editButton.Click += handleEditFile;

                actionsTable.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                deleteButton.ForeColor = Color.Red;
                deleteButton.Dock = DockStyle.Fill;
                deleteButton.Text = "Sterge";
                deleteButton.Tag = res.Id;
                deleteButton.Click += handleRemoveFile;

                actionsTable.Controls.Add(deleteButton);

                listResultTable.Controls.Add(actionsTable);
            }

            listResultTable.Update();
        }

        private void handleRemoveFile(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            client.deleteResource(Convert.ToInt32(button.Tag));

            resources = client.getActiveResources().ToList();

            UpdateListView();
        }

        private void handleEditFile(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            navigation.SelectedIndex = 1;
            navigation.Tag = new Dictionary<string, object>() { { "editObject", button.Tag } };

            EditFileMeta();
        }
    }
}
