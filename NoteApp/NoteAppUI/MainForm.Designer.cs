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
            menuStrip.Size = new Size(2176, 49);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(87, 45);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(230, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNoteToolStripMenuItem, editNoteToolStripMenuItem, removeNoteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(92, 45);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            addNoteToolStripMenuItem.Size = new Size(365, 54);
            addNoteToolStripMenuItem.Text = "Add Note";
            addNoteToolStripMenuItem.Click += addNoteToolStripMenuItem_Click;
            // 
            // editNoteToolStripMenuItem
            // 
            editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            editNoteToolStripMenuItem.Size = new Size(365, 54);
            editNoteToolStripMenuItem.Text = "Edit Note";
            editNoteToolStripMenuItem.Click += editNoteToolStripMenuItem_Click;
            // 
            // removeNoteToolStripMenuItem
            // 
            removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            removeNoteToolStripMenuItem.Size = new Size(365, 54);
            removeNoteToolStripMenuItem.Text = "Remove Note";
            removeNoteToolStripMenuItem.Click += removeNoteToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(104, 45);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(266, 54);
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
            panel.Location = new Point(0, 49);
            panel.Name = "panel";
            panel.Size = new Size(2176, 995);
            panel.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.Image = Properties.Resources.remove_icon;
            DeleteButton.Location = new Point(140, 900);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(60, 70);
            DeleteButton.TabIndex = 4;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // NoteRichTextBox
            // 
            NoteRichTextBox.Enabled = false;
            NoteRichTextBox.Location = new Point(666, 311);
            NoteRichTextBox.Name = "NoteRichTextBox";
            NoteRichTextBox.ReadOnly = true;
            NoteRichTextBox.Size = new Size(1407, 544);
            NoteRichTextBox.TabIndex = 12;
            NoteRichTextBox.Text = "";
            // 
            // EditButton
            // 
            EditButton.Image = Properties.Resources.edit_icon;
            EditButton.Location = new Point(70, 900);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(60, 70);
            EditButton.TabIndex = 3;
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 14.1F, FontStyle.Italic, GraphicsUnit.Point, 204);
            TitleLabel.Location = new Point(666, 37);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(435, 62);
            TitleLabel.TabIndex = 11;
            TitleLabel.Text = "Название заметки";
            // 
            // AddButton
            // 
            AddButton.Image = Properties.Resources.add_icon;
            AddButton.Location = new Point(0, 900);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(60, 70);
            AddButton.TabIndex = 2;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(841, 155);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(0, 41);
            CategoryLabel.TabIndex = 10;
            // 
            // ModifiedDatePicker
            // 
            ModifiedDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            ModifiedDatePicker.Enabled = false;
            ModifiedDatePicker.Format = DateTimePickerFormat.Custom;
            ModifiedDatePicker.Location = new Point(1416, 237);
            ModifiedDatePicker.Name = "ModifiedDatePicker";
            ModifiedDatePicker.Size = new Size(369, 47);
            ModifiedDatePicker.TabIndex = 9;
            // 
            // CreateDatePicker
            // 
            CreateDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            CreateDatePicker.Enabled = false;
            CreateDatePicker.Format = DateTimePickerFormat.Custom;
            CreateDatePicker.Location = new Point(818, 237);
            CreateDatePicker.Name = "CreateDatePicker";
            CreateDatePicker.Size = new Size(369, 47);
            CreateDatePicker.TabIndex = 8;
            // 
            // ModifiedDescriptionLabel
            // 
            ModifiedDescriptionLabel.AutoSize = true;
            ModifiedDescriptionLabel.Location = new Point(1249, 237);
            ModifiedDescriptionLabel.Name = "ModifiedDescriptionLabel";
            ModifiedDescriptionLabel.Size = new Size(145, 41);
            ModifiedDescriptionLabel.TabIndex = 7;
            ModifiedDescriptionLabel.Text = "Modified:";
            // 
            // CreatedDescriptionLabel
            // 
            CreatedDescriptionLabel.AutoSize = true;
            CreatedDescriptionLabel.Location = new Point(666, 237);
            CreatedDescriptionLabel.Name = "CreatedDescriptionLabel";
            CreatedDescriptionLabel.Size = new Size(129, 41);
            CreatedDescriptionLabel.TabIndex = 6;
            CreatedDescriptionLabel.Text = "Created:";
            // 
            // CategoryDescriptionLabel
            // 
            CategoryDescriptionLabel.AutoSize = true;
            CategoryDescriptionLabel.Location = new Point(666, 155);
            CategoryDescriptionLabel.Name = "CategoryDescriptionLabel";
            CategoryDescriptionLabel.Size = new Size(146, 41);
            CategoryDescriptionLabel.TabIndex = 5;
            CategoryDescriptionLabel.Text = "Category:";
            // 
            // NotelistBox
            // 
            NotelistBox.FormattingEnabled = true;
            NotelistBox.ItemHeight = 41;
            NotelistBox.Location = new Point(51, 113);
            NotelistBox.Name = "NotelistBox";
            NotelistBox.Size = new Size(514, 742);
            NotelistBox.TabIndex = 4;
            NotelistBox.SelectedIndexChanged += NoteListBox_SelectedIndexChanged;
            NotelistBox.DoubleClick += NoteListBox_DoubleClick;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(263, 29);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(302, 49);
            CategoryComboBox.TabIndex = 3;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // ShowCategoryLabel
            // 
            ShowCategoryLabel.AutoSize = true;
            ShowCategoryLabel.Location = new Point(30, 29);
            ShowCategoryLabel.Name = "ShowCategoryLabel";
            ShowCategoryLabel.Size = new Size(227, 41);
            ShowCategoryLabel.TabIndex = 2;
            ShowCategoryLabel.Text = "Show Category:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2176, 1044);
            Controls.Add(panel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(6);
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
