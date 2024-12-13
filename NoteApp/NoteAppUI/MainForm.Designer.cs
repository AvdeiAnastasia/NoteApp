namespace NoteAppUI
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

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addNoteToolStripMenuItem;
        private ToolStripMenuItem editNoteToolStripMenuItem;
        private ToolStripMenuItem removeNoteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel;
        private ComboBox CategoryComboBox;
        private Label ShowCategoryLabel;
        private DateTimePicker CreateDatePicker;
        private Label ModifiedDescriptionLabel;
        private Label CreatedDescriptionLabel;
        private Label CategoryDescriptionLabel;
        private ListBox NotelistBox;
        private Label CategoryLabel;
        private DateTimePicker ModifiedDatePicker;
        private RichTextBox NoteRichTextBox;
        private Label TitleLabel;

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addNoteToolStripMenuItem = new ToolStripMenuItem();
            editNoteToolStripMenuItem = new ToolStripMenuItem();
            removeNoteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel = new Panel();
            DeleteButton = new Button();
            NoteRichTextBox = new RichTextBox();
            EditButton = new Button();
            TitleLabel = new Label();
            AddButton = new Button();
            CategoryLabel = new Label();
            ModifiedDatePicker = new DateTimePicker();
            CreateDatePicker = new DateTimePicker();
            ModifiedDescriptionLabel = new Label();
            CreatedDescriptionLabel = new Label();
            CategoryDescriptionLabel = new Label();
            NotelistBox = new ListBox();
            CategoryComboBox = new ComboBox();
            ShowCategoryLabel = new Label();
            menuStrip.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(40, 40);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(3, 1, 0, 1);
            menuStrip.Size = new Size(905, 26);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNoteToolStripMenuItem, editNoteToolStripMenuItem, removeNoteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            addNoteToolStripMenuItem.Size = new Size(183, 26);
            addNoteToolStripMenuItem.Text = "Add Note";
            addNoteToolStripMenuItem.Click += addNoteToolStripMenuItem_Click;
            // 
            // editNoteToolStripMenuItem
            // 
            editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            editNoteToolStripMenuItem.Size = new Size(183, 26);
            editNoteToolStripMenuItem.Text = "Edit Note";
            editNoteToolStripMenuItem.Click += editNoteToolStripMenuItem_Click;
            // 
            // removeNoteToolStripMenuItem
            // 
            removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            removeNoteToolStripMenuItem.Size = new Size(183, 26);
            removeNoteToolStripMenuItem.Text = "Remove Note";
            removeNoteToolStripMenuItem.Click += removeNoteToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // panel
            // 
            panel.Controls.Add(DeleteButton);
            panel.Controls.Add(NoteRichTextBox);
            panel.Controls.Add(EditButton);
            panel.Controls.Add(TitleLabel);
            panel.Controls.Add(AddButton);
            panel.Controls.Add(CategoryLabel);
            panel.Controls.Add(ModifiedDatePicker);
            panel.Controls.Add(CreateDatePicker);
            panel.Controls.Add(ModifiedDescriptionLabel);
            panel.Controls.Add(CreatedDescriptionLabel);
            panel.Controls.Add(CategoryDescriptionLabel);
            panel.Controls.Add(NotelistBox);
            panel.Controls.Add(CategoryComboBox);
            panel.Controls.Add(ShowCategoryLabel);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 26);
            panel.Margin = new Padding(1);
            panel.Name = "panel";
            panel.Size = new Size(905, 483);
            panel.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.BackgroundImage = Properties.Resources.remove_icon;
            DeleteButton.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteButton.Location = new Point(66, 439);
            DeleteButton.Margin = new Padding(1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(28, 34);
            DeleteButton.TabIndex = 4;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // NoteRichTextBox
            // 
            NoteRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            NoteRichTextBox.Enabled = false;
            NoteRichTextBox.Location = new Point(313, 152);
            NoteRichTextBox.Margin = new Padding(1);
            NoteRichTextBox.Name = "NoteRichTextBox";
            NoteRichTextBox.ReadOnly = true;
            NoteRichTextBox.Size = new Size(664, 267);
            NoteRichTextBox.TabIndex = 12;
            NoteRichTextBox.Text = "";
            // 
            // EditButton
            // 
            EditButton.BackgroundImage = Properties.Resources.edit_icon;
            EditButton.BackgroundImageLayout = ImageLayout.Zoom;
            EditButton.Location = new Point(33, 439);
            EditButton.Margin = new Padding(1);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(28, 34);
            EditButton.TabIndex = 3;
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 14.1F, FontStyle.Italic, GraphicsUnit.Point, 204);
            TitleLabel.Location = new Point(313, 18);
            TitleLabel.Margin = new Padding(1, 0, 1, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(225, 32);
            TitleLabel.TabIndex = 11;
            TitleLabel.Text = "Название заметки";
            // 
            // AddButton
            // 
            AddButton.BackgroundImage = Properties.Resources.add_icon;
            AddButton.BackgroundImageLayout = ImageLayout.Zoom;
            AddButton.Location = new Point(0, 439);
            AddButton.Margin = new Padding(1);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(28, 34);
            AddButton.TabIndex = 2;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(396, 76);
            CategoryLabel.Margin = new Padding(1, 0, 1, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(0, 20);
            CategoryLabel.TabIndex = 10;
            // 
            // ModifiedDatePicker
            // 
            ModifiedDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            ModifiedDatePicker.Enabled = false;
            ModifiedDatePicker.Format = DateTimePickerFormat.Custom;
            ModifiedDatePicker.Location = new Point(666, 116);
            ModifiedDatePicker.Margin = new Padding(1);
            ModifiedDatePicker.Name = "ModifiedDatePicker";
            ModifiedDatePicker.Size = new Size(176, 27);
            ModifiedDatePicker.TabIndex = 9;
            // 
            // CreateDatePicker
            // 
            CreateDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            CreateDatePicker.Enabled = false;
            CreateDatePicker.Format = DateTimePickerFormat.Custom;
            CreateDatePicker.Location = new Point(385, 116);
            CreateDatePicker.Margin = new Padding(1);
            CreateDatePicker.Name = "CreateDatePicker";
            CreateDatePicker.Size = new Size(176, 27);
            CreateDatePicker.TabIndex = 8;
            // 
            // ModifiedDescriptionLabel
            // 
            ModifiedDescriptionLabel.AutoSize = true;
            ModifiedDescriptionLabel.Location = new Point(588, 116);
            ModifiedDescriptionLabel.Margin = new Padding(1, 0, 1, 0);
            ModifiedDescriptionLabel.Name = "ModifiedDescriptionLabel";
            ModifiedDescriptionLabel.Size = new Size(73, 20);
            ModifiedDescriptionLabel.TabIndex = 7;
            ModifiedDescriptionLabel.Text = "Modified:";
            // 
            // CreatedDescriptionLabel
            // 
            CreatedDescriptionLabel.AutoSize = true;
            CreatedDescriptionLabel.Location = new Point(313, 116);
            CreatedDescriptionLabel.Margin = new Padding(1, 0, 1, 0);
            CreatedDescriptionLabel.Name = "CreatedDescriptionLabel";
            CreatedDescriptionLabel.Size = new Size(64, 20);
            CreatedDescriptionLabel.TabIndex = 6;
            CreatedDescriptionLabel.Text = "Created:";
            // 
            // CategoryDescriptionLabel
            // 
            CategoryDescriptionLabel.AutoSize = true;
            CategoryDescriptionLabel.Location = new Point(313, 76);
            CategoryDescriptionLabel.Margin = new Padding(1, 0, 1, 0);
            CategoryDescriptionLabel.Name = "CategoryDescriptionLabel";
            CategoryDescriptionLabel.Size = new Size(72, 20);
            CategoryDescriptionLabel.TabIndex = 5;
            CategoryDescriptionLabel.Text = "Category:";
            // 
            // NotelistBox
            // 
            NotelistBox.FormattingEnabled = true;
            NotelistBox.Location = new Point(24, 55);
            NotelistBox.Margin = new Padding(1);
            NotelistBox.Name = "NotelistBox";
            NotelistBox.Size = new Size(244, 364);
            NotelistBox.TabIndex = 4;
            NotelistBox.SelectedIndexChanged += NoteListBox_SelectedIndexChanged;
            NotelistBox.DoubleClick += NoteListBox_DoubleClick;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(124, 14);
            CategoryComboBox.Margin = new Padding(1);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(144, 28);
            CategoryComboBox.TabIndex = 3;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // ShowCategoryLabel
            // 
            ShowCategoryLabel.AutoSize = true;
            ShowCategoryLabel.Location = new Point(14, 14);
            ShowCategoryLabel.Margin = new Padding(1, 0, 1, 0);
            ShowCategoryLabel.Name = "ShowCategoryLabel";
            ShowCategoryLabel.Size = new Size(112, 20);
            ShowCategoryLabel.TabIndex = 2;
            ShowCategoryLabel.Text = "Show Category:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 509);
            Controls.Add(panel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "NoteApp";
            FormClosed += MainForm_FormClosed;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
    }
}
