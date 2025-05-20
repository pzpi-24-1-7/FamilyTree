namespace FamilyTree
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            FindButton = new Button();
            panel1 = new Panel();
            DateLabel = new Label();
            DateTextBox = new TextBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            IdLabel = new Label();
            IdTextBox = new TextBox();
            SearchResults = new ListBox();
            personBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитькакToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            предварительныйпросмотрToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            personToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            содержимоеToolStripMenuItem = new ToolStripMenuItem();
            индексToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            опрограммеToolStripMenuItem = new ToolStripMenuItem();
            NothingLabel = new Label();
            LoadButton = new Button();
            FamilyTreeView = new TreeView();
            GetTree = new Button();
            GenerateTestData = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // FindButton
            // 
            FindButton.Cursor = Cursors.Hand;
            FindButton.Font = new Font("Segoe UI", 8F);
            FindButton.Location = new Point(442, 108);
            FindButton.Name = "FindButton";
            FindButton.RightToLeft = RightToLeft.Yes;
            FindButton.Size = new Size(90, 30);
            FindButton.TabIndex = 0;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(DateTextBox);
            panel1.Controls.Add(NameLabel);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(IdLabel);
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(FindButton);
            panel1.Location = new Point(16, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 157);
            panel1.TabIndex = 2;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(198, 21);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(94, 20);
            DateLabel.TabIndex = 6;
            DateLabel.Text = "Date of birth";
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(198, 44);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(223, 27);
            DateTextBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(25, 87);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(150, 20);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Last name/First name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(25, 110);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(396, 27);
            NameTextBox.TabIndex = 3;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(25, 20);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(24, 20);
            IdLabel.TabIndex = 2;
            IdLabel.Text = "ID";
            // 
            // IdTextBox
            // 
            IdTextBox.BorderStyle = BorderStyle.FixedSingle;
            IdTextBox.Cursor = Cursors.IBeam;
            IdTextBox.Location = new Point(25, 43);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(137, 27);
            IdTextBox.TabIndex = 1;
            // 
            // SearchResults
            // 
            SearchResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SearchResults.DataSource = personBindingSource;
            SearchResults.DisplayMember = "FirstName";
            SearchResults.FormattingEnabled = true;
            SearchResults.Location = new Point(13, 221);
            SearchResults.Name = "SearchResults";
            SearchResults.Size = new Size(556, 304);
            SearchResults.TabIndex = 3;
            SearchResults.ValueMember = "Id";
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Models.Person);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, personToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1082, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, сохранитькакToolStripMenuItem, toolStripSeparator1, печатьToolStripMenuItem, предварительныйпросмотрToolStripMenuItem, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Image = (Image)resources.GetObject("создатьToolStripMenuItem.Image");
            создатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            создатьToolStripMenuItem.Size = new Size(294, 26);
            создатьToolStripMenuItem.Text = "&Создать";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(294, 26);
            открытьToolStripMenuItem.Text = "&Открыть";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(291, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(294, 26);
            сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // сохранитькакToolStripMenuItem
            // 
            сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            сохранитькакToolStripMenuItem.Size = new Size(294, 26);
            сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(291, 6);
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Image = (Image)resources.GetObject("печатьToolStripMenuItem.Image");
            печатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            печатьToolStripMenuItem.Size = new Size(294, 26);
            печатьToolStripMenuItem.Text = "&Печать";
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            предварительныйпросмотрToolStripMenuItem.Image = (Image)resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image");
            предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            предварительныйпросмотрToolStripMenuItem.Size = new Size(294, 26);
            предварительныйпросмотрToolStripMenuItem.Text = "Предварительный про&смотр";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(291, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(294, 26);
            выходToolStripMenuItem.Text = "Вы&ход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // personToolStripMenuItem
            // 
            personToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            personToolStripMenuItem.Name = "personToolStripMenuItem";
            personToolStripMenuItem.Size = new Size(66, 24);
            personToolStripMenuItem.Text = "Person";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(136, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(136, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(136, 26);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { содержимоеToolStripMenuItem, индексToolStripMenuItem, поискToolStripMenuItem, toolStripSeparator5, опрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "&Справка";
            // 
            // содержимоеToolStripMenuItem
            // 
            содержимоеToolStripMenuItem.Name = "содержимоеToolStripMenuItem";
            содержимоеToolStripMenuItem.Size = new Size(198, 26);
            содержимоеToolStripMenuItem.Text = "&Содержимое";
            // 
            // индексToolStripMenuItem
            // 
            индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            индексToolStripMenuItem.Size = new Size(198, 26);
            индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(198, 26);
            поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(195, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            опрограммеToolStripMenuItem.Size = new Size(198, 26);
            опрограммеToolStripMenuItem.Text = "&О программе…";
            // 
            // NothingLabel
            // 
            NothingLabel.AutoSize = true;
            NothingLabel.Location = new Point(215, 226);
            NothingLabel.Name = "NothingLabel";
            NothingLabel.RightToLeft = RightToLeft.No;
            NothingLabel.Size = new Size(135, 20);
            NothingLabel.TabIndex = 5;
            NothingLabel.Text = "Nothing was found";
            NothingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoadButton
            // 
            LoadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoadButton.Location = new Point(979, 546);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(90, 30);
            LoadButton.TabIndex = 6;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // FamilyTreeView
            // 
            FamilyTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FamilyTreeView.Location = new Point(601, 51);
            FamilyTreeView.Name = "FamilyTreeView";
            FamilyTreeView.Size = new Size(468, 474);
            FamilyTreeView.TabIndex = 7;
            // 
            // GetTree
            // 
            GetTree.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GetTree.Location = new Point(13, 546);
            GetTree.Name = "GetTree";
            GetTree.Size = new Size(90, 30);
            GetTree.TabIndex = 8;
            GetTree.Text = "Get tree";
            GetTree.UseVisualStyleBackColor = true;
            GetTree.Click += GetTree_Click;
            // 
            // GenerateTestData
            // 
            GenerateTestData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GenerateTestData.Cursor = Cursors.Hand;
            GenerateTestData.Font = new Font("Segoe UI", 8F);
            GenerateTestData.Location = new Point(109, 546);
            GenerateTestData.Name = "GenerateTestData";
            GenerateTestData.RightToLeft = RightToLeft.Yes;
            GenerateTestData.Size = new Size(90, 30);
            GenerateTestData.TabIndex = 7;
            GenerateTestData.Text = "Generate";
            GenerateTestData.UseVisualStyleBackColor = true;
            GenerateTestData.Click += GenerateTestData_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 588);
            Controls.Add(GenerateTestData);
            Controls.Add(GetTree);
            Controls.Add(FamilyTreeView);
            Controls.Add(LoadButton);
            Controls.Add(NothingLabel);
            Controls.Add(SearchResults);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MinimumSize = new Size(1100, 635);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FindButton;
        private Panel panel1;
        private ListBox SearchResults;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитькакToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem содержимоеToolStripMenuItem;
        private ToolStripMenuItem индексToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label DateLabel;
        private TextBox DateTextBox;
        private Label IdLabel;
        private TextBox IdTextBox;
        private Label NothingLabel;
        private BindingSource personBindingSource;
        private ToolStripMenuItem personToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button LoadButton;
        private TreeView FamilyTreeView;
        private Button GetTree;
        private Button GenerateTestData;
    }
}
