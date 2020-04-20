namespace GUI
{
    partial class MyPhotos
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
            this.navigation = new System.Windows.Forms.TabControl();
            this.listViewPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.resourceListLabel = new System.Windows.Forms.Label();
            this.saveSearchResultButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.findLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filter_created_to = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.filter_created_from = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.filter_attribute_value = new System.Windows.Forms.TextBox();
            this.filter_attribute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.filter_description = new System.Windows.Forms.TextBox();
            this.filter_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listResultTable = new System.Windows.Forms.TableLayoutPanel();
            this.listResultHeaderActionsLabel = new System.Windows.Forms.Label();
            this.listResultHeaderDescriptionLabel = new System.Windows.Forms.Label();
            this.listResultHeaderPathLabel = new System.Windows.Forms.Label();
            this.listResultHeaderNameLabel = new System.Windows.Forms.Label();
            this.listResultHeaderNumberLabel = new System.Windows.Forms.Label();
            this.listResultHeaderPropertiesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addEditPage = new System.Windows.Forms.TabPage();
            this.table1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.addResourceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.addEditTabPageContentWrapper = new System.Windows.Forms.Panel();
            this.navigation.SuspendLayout();
            this.listViewPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.listResultTable.SuspendLayout();
            this.addEditPage.SuspendLayout();
            this.table1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation
            // 
            this.navigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigation.Controls.Add(this.listViewPage);
            this.navigation.Controls.Add(this.addEditPage);
            this.navigation.Location = new System.Drawing.Point(-4, 0);
            this.navigation.Name = "navigation";
            this.navigation.SelectedIndex = 0;
            this.navigation.Size = new System.Drawing.Size(1109, 454);
            this.navigation.TabIndex = 0;
            // 
            // listViewPage
            // 
            this.listViewPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.listViewPage.Controls.Add(this.tableLayoutPanel1);
            this.listViewPage.Location = new System.Drawing.Point(4, 22);
            this.listViewPage.Name = "listViewPage";
            this.listViewPage.Padding = new System.Windows.Forms.Padding(3);
            this.listViewPage.Size = new System.Drawing.Size(1101, 428);
            this.listViewPage.TabIndex = 0;
            this.listViewPage.Text = "listTabPage";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1095, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.resourceListLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveSearchResultButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.emailButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1089, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // resourceListLabel
            // 
            this.resourceListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceListLabel.AutoSize = true;
            this.resourceListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceListLabel.ForeColor = System.Drawing.Color.White;
            this.resourceListLabel.Location = new System.Drawing.Point(3, 0);
            this.resourceListLabel.Name = "resourceListLabel";
            this.resourceListLabel.Size = new System.Drawing.Size(144, 34);
            this.resourceListLabel.TabIndex = 0;
            this.resourceListLabel.Text = "Lista Resurse";
            this.resourceListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveSearchResultButton
            // 
            this.saveSearchResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSearchResultButton.BackColor = System.Drawing.Color.White;
            this.saveSearchResultButton.FlatAppearance.BorderSize = 0;
            this.saveSearchResultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.saveSearchResultButton.Location = new System.Drawing.Point(789, 0);
            this.saveSearchResultButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveSearchResultButton.Name = "saveSearchResultButton";
            this.saveSearchResultButton.Size = new System.Drawing.Size(200, 34);
            this.saveSearchResultButton.TabIndex = 2;
            this.saveSearchResultButton.Text = "Salveaza Rezultatul";
            this.saveSearchResultButton.UseVisualStyleBackColor = false;
            this.saveSearchResultButton.Click += new System.EventHandler(this.saveSearchResultButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailButton.BackColor = System.Drawing.Color.White;
            this.emailButton.FlatAppearance.BorderSize = 0;
            this.emailButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.emailButton.Location = new System.Drawing.Point(989, 0);
            this.emailButton.Margin = new System.Windows.Forms.Padding(0);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(100, 34);
            this.emailButton.TabIndex = 2;
            this.emailButton.Text = "Email";
            this.emailButton.UseVisualStyleBackColor = false;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.button2.Location = new System.Drawing.Point(589, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "+ Adauga Resurse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Location = new System.Drawing.Point(3, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 194);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1083, 194);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1358F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.findLabel, 0, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1077, 34);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // findLabel
            // 
            this.findLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findLabel.AutoSize = true;
            this.findLabel.BackColor = System.Drawing.Color.Transparent;
            this.findLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.findLabel.Location = new System.Drawing.Point(3, 0);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(1352, 34);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Cautare";
            this.findLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1077, 148);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.filter_created_to);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.filter_created_from);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.filter_attribute_value);
            this.panel3.Controls.Add(this.filter_attribute);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.findButton);
            this.panel3.Controls.Add(this.filter_description);
            this.panel3.Controls.Add(this.filter_name);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 142);
            this.panel3.TabIndex = 0;
            // 
            // filter_created_to
            // 
            this.filter_created_to.Location = new System.Drawing.Point(369, 116);
            this.filter_created_to.Name = "filter_created_to";
            this.filter_created_to.Size = new System.Drawing.Size(200, 20);
            this.filter_created_to.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(334, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "si";
            // 
            // filter_created_from
            // 
            this.filter_created_from.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filter_created_from.Location = new System.Drawing.Point(116, 116);
            this.filter_created_from.Name = "filter_created_from";
            this.filter_created_from.Size = new System.Drawing.Size(200, 20);
            this.filter_created_from.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(34, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Creat intre";
            // 
            // filter_attribute_value
            // 
            this.filter_attribute_value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filter_attribute_value.Location = new System.Drawing.Point(553, 81);
            this.filter_attribute_value.Name = "filter_attribute_value";
            this.filter_attribute_value.Size = new System.Drawing.Size(147, 20);
            this.filter_attribute_value.TabIndex = 8;
            // 
            // filter_attribute
            // 
            this.filter_attribute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filter_attribute.Location = new System.Drawing.Point(553, 43);
            this.filter_attribute.Name = "filter_attribute";
            this.filter_attribute.Size = new System.Drawing.Size(147, 20);
            this.filter_attribute.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(470, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valoare Atribut";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(470, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Atribut";
            // 
            // findButton
            // 
            this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findButton.BackColor = System.Drawing.Color.White;
            this.findButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.findButton.Location = new System.Drawing.Point(980, 78);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 27);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Cauta";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // filter_description
            // 
            this.filter_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filter_description.Location = new System.Drawing.Point(116, 81);
            this.filter_description.Name = "filter_description";
            this.filter_description.Size = new System.Drawing.Size(147, 20);
            this.filter_description.TabIndex = 3;
            // 
            // filter_name
            // 
            this.filter_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filter_name.Location = new System.Drawing.Point(116, 43);
            this.filter_name.Name = "filter_name";
            this.filter_name.Size = new System.Drawing.Size(147, 20);
            this.filter_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descriere";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.listResultTable);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 176);
            this.panel2.TabIndex = 3;
            // 
            // listResultTable
            // 
            this.listResultTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResultTable.AutoSize = true;
            this.listResultTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listResultTable.ColumnCount = 7;
            this.listResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.listResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.listResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.listResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.listResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.listResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.listResultTable.Controls.Add(this.listResultHeaderActionsLabel, 6, 0);
            this.listResultTable.Controls.Add(this.listResultHeaderDescriptionLabel, 3, 0);
            this.listResultTable.Controls.Add(this.listResultHeaderPathLabel, 2, 0);
            this.listResultTable.Controls.Add(this.listResultHeaderNameLabel, 1, 0);
            this.listResultTable.Controls.Add(this.listResultHeaderNumberLabel, 0, 0);
            this.listResultTable.Controls.Add(this.listResultHeaderPropertiesLabel, 5, 0);
            this.listResultTable.Controls.Add(this.label1, 4, 0);
            this.listResultTable.Location = new System.Drawing.Point(3, 3);
            this.listResultTable.Name = "listResultTable";
            this.listResultTable.RowCount = 1;
            this.listResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listResultTable.Size = new System.Drawing.Size(1083, 170);
            this.listResultTable.TabIndex = 0;
            // 
            // listResultHeaderActionsLabel
            // 
            this.listResultHeaderActionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResultHeaderActionsLabel.AutoSize = true;
            this.listResultHeaderActionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.listResultHeaderActionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResultHeaderActionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.listResultHeaderActionsLabel.Location = new System.Drawing.Point(843, 0);
            this.listResultHeaderActionsLabel.Name = "listResultHeaderActionsLabel";
            this.listResultHeaderActionsLabel.Size = new System.Drawing.Size(237, 170);
            this.listResultHeaderActionsLabel.TabIndex = 6;
            this.listResultHeaderActionsLabel.Text = "Actiuni";
            this.listResultHeaderActionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listResultHeaderDescriptionLabel
            // 
            this.listResultHeaderDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResultHeaderDescriptionLabel.AutoSize = true;
            this.listResultHeaderDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.listResultHeaderDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResultHeaderDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.listResultHeaderDescriptionLabel.Location = new System.Drawing.Point(353, 0);
            this.listResultHeaderDescriptionLabel.Name = "listResultHeaderDescriptionLabel";
            this.listResultHeaderDescriptionLabel.Size = new System.Drawing.Size(134, 20);
            this.listResultHeaderDescriptionLabel.TabIndex = 3;
            this.listResultHeaderDescriptionLabel.Text = "Descriere";
            this.listResultHeaderDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listResultHeaderPathLabel
            // 
            this.listResultHeaderPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResultHeaderPathLabel.AutoSize = true;
            this.listResultHeaderPathLabel.BackColor = System.Drawing.Color.Transparent;
            this.listResultHeaderPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResultHeaderPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.listResultHeaderPathLabel.Location = new System.Drawing.Point(153, 0);
            this.listResultHeaderPathLabel.Name = "listResultHeaderPathLabel";
            this.listResultHeaderPathLabel.Size = new System.Drawing.Size(194, 20);
            this.listResultHeaderPathLabel.TabIndex = 2;
            this.listResultHeaderPathLabel.Text = "Cale";
            this.listResultHeaderPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listResultHeaderNameLabel
            // 
            this.listResultHeaderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResultHeaderNameLabel.AutoSize = true;
            this.listResultHeaderNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.listResultHeaderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResultHeaderNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.listResultHeaderNameLabel.Location = new System.Drawing.Point(53, 0);
            this.listResultHeaderNameLabel.Name = "listResultHeaderNameLabel";
            this.listResultHeaderNameLabel.Size = new System.Drawing.Size(94, 20);
            this.listResultHeaderNameLabel.TabIndex = 1;
            this.listResultHeaderNameLabel.Text = "Nume";
            this.listResultHeaderNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listResultHeaderNumberLabel
            // 
            this.listResultHeaderNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResultHeaderNumberLabel.AutoSize = true;
            this.listResultHeaderNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.listResultHeaderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResultHeaderNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.listResultHeaderNumberLabel.Location = new System.Drawing.Point(3, 0);
            this.listResultHeaderNumberLabel.Name = "listResultHeaderNumberLabel";
            this.listResultHeaderNumberLabel.Size = new System.Drawing.Size(44, 20);
            this.listResultHeaderNumberLabel.TabIndex = 0;
            this.listResultHeaderNumberLabel.Text = "#";
            this.listResultHeaderNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listResultHeaderPropertiesLabel
            // 
            this.listResultHeaderPropertiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResultHeaderPropertiesLabel.AutoSize = true;
            this.listResultHeaderPropertiesLabel.BackColor = System.Drawing.Color.Transparent;
            this.listResultHeaderPropertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResultHeaderPropertiesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.listResultHeaderPropertiesLabel.Location = new System.Drawing.Point(643, 0);
            this.listResultHeaderPropertiesLabel.Name = "listResultHeaderPropertiesLabel";
            this.listResultHeaderPropertiesLabel.Size = new System.Drawing.Size(194, 20);
            this.listResultHeaderPropertiesLabel.TabIndex = 4;
            this.listResultHeaderPropertiesLabel.Text = "Proprietati";
            this.listResultHeaderPropertiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(493, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Crearii";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addEditPage
            // 
            this.addEditPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.addEditPage.Controls.Add(this.table1);
            this.addEditPage.Location = new System.Drawing.Point(4, 22);
            this.addEditPage.Name = "addEditPage";
            this.addEditPage.Padding = new System.Windows.Forms.Padding(3);
            this.addEditPage.Size = new System.Drawing.Size(1101, 428);
            this.addEditPage.TabIndex = 1;
            this.addEditPage.Text = "addEditTabPage";
            // 
            // table1
            // 
            this.table1.BackColor = System.Drawing.Color.Transparent;
            this.table1.ColumnCount = 1;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1.Controls.Add(this.saveButton, 0, 3);
            this.table1.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.table1.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.table1.Controls.Add(this.addEditTabPageContentWrapper, 0, 2);
            this.table1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table1.Location = new System.Drawing.Point(3, 3);
            this.table1.Name = "table1";
            this.table1.RowCount = 4;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table1.Size = new System.Drawing.Size(1095, 422);
            this.table1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Enabled = false;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.saveButton.Location = new System.Drawing.Point(487, 395);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 24);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Salveaza";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.Controls.Add(this.addResourceLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1089, 34);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // addResourceLabel
            // 
            this.addResourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addResourceLabel.AutoSize = true;
            this.addResourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResourceLabel.ForeColor = System.Drawing.Color.White;
            this.addResourceLabel.Location = new System.Drawing.Point(3, 0);
            this.addResourceLabel.Name = "addResourceLabel";
            this.addResourceLabel.Size = new System.Drawing.Size(1043, 34);
            this.addResourceLabel.TabIndex = 0;
            this.addResourceLabel.Text = "Adauga Resurse";
            this.addResourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GUI.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(1052, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.selectFileButton, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.selectFolderButton, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1089, 114);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.selectFileButton.Location = new System.Drawing.Point(241, 3);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(300, 108);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Selecteaza\r\nFotografie/Film";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selectFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.selectFolderButton.Location = new System.Drawing.Point(547, 3);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(300, 108);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Selecteaza\r\nFolder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // addEditTabPageContentWrapper
            // 
            this.addEditTabPageContentWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addEditTabPageContentWrapper.AutoScroll = true;
            this.addEditTabPageContentWrapper.BackColor = System.Drawing.Color.Transparent;
            this.addEditTabPageContentWrapper.Location = new System.Drawing.Point(3, 163);
            this.addEditTabPageContentWrapper.Name = "addEditTabPageContentWrapper";
            this.addEditTabPageContentWrapper.Size = new System.Drawing.Size(1089, 226);
            this.addEditTabPageContentWrapper.TabIndex = 4;
            // 
            // MyPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.navigation);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyPhotos";
            this.Text = "MyPhotos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MyPhotos_Load);
            this.navigation.ResumeLayout(false);
            this.listViewPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.listResultTable.ResumeLayout(false);
            this.listResultTable.PerformLayout();
            this.addEditPage.ResumeLayout(false);
            this.table1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navigation;
        private System.Windows.Forms.TabPage listViewPage;
        private System.Windows.Forms.TabPage addEditPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label resourceListLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveSearchResultButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel listResultTable;
        private System.Windows.Forms.Label listResultHeaderNumberLabel;
        private System.Windows.Forms.Label listResultHeaderNameLabel;
        private System.Windows.Forms.Label listResultHeaderPathLabel;
        private System.Windows.Forms.Label listResultHeaderDescriptionLabel;
        private System.Windows.Forms.Label listResultHeaderPropertiesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label listResultHeaderActionsLabel;
        private System.Windows.Forms.TableLayoutPanel table1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label addResourceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Panel addEditTabPageContentWrapper;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox filter_description;
        private System.Windows.Forms.TextBox filter_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filter_attribute_value;
        private System.Windows.Forms.TextBox filter_attribute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker filter_created_from;
        private System.Windows.Forms.DateTimePicker filter_created_to;
    }
}

