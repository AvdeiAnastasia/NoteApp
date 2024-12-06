namespace NoteAppUI
{
    partial class NoteEditForm
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
            TitleLabel = new Label();
            CategoryLabel = new Label();
            CreatedLabel = new Label();
            TitleTextBox = new TextBox();
            CategoryComboBox = new ComboBox();
            CreatedDatePicker = new DateTimePicker();
            ModifiedDatePicker = new DateTimePicker();
            ModifiedLabel = new Label();
            NoteRichTextBox = new RichTextBox();
            ExitButton = new Button();
            OkButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(30, 30);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(81, 41);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(30, 90);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(146, 41);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(30, 150);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(129, 41);
            CreatedLabel.TabIndex = 2;
            CreatedLabel.Text = "Created:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(181, 27);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(1338, 47);
            TitleTextBox.TabIndex = 3;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(181, 90);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(599, 49);
            CategoryComboBox.TabIndex = 4;
            // 
            // CreatedDatePicker
            // 
            CreatedDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            CreatedDatePicker.Enabled = false;
            CreatedDatePicker.Format = DateTimePickerFormat.Custom;
            CreatedDatePicker.Location = new Point(181, 150);
            CreatedDatePicker.Name = "CreatedDatePicker";
            CreatedDatePicker.Size = new Size(500, 47);
            CreatedDatePicker.TabIndex = 5;
            // 
            // ModifiedDatePicker
            // 
            ModifiedDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            ModifiedDatePicker.Enabled = false;
            ModifiedDatePicker.Format = DateTimePickerFormat.Custom;
            ModifiedDatePicker.Location = new Point(1009, 150);
            ModifiedDatePicker.Name = "ModifiedDatePicker";
            ModifiedDatePicker.Size = new Size(500, 47);
            ModifiedDatePicker.TabIndex = 6;
            // 
            // ModifiedLabel
            // 
            ModifiedLabel.AutoSize = true;
            ModifiedLabel.Location = new Point(787, 156);
            ModifiedLabel.Name = "ModifiedLabel";
            ModifiedLabel.Size = new Size(145, 41);
            ModifiedLabel.TabIndex = 7;
            ModifiedLabel.Text = "Modified:";
            // 
            // NoteRichTextBox
            // 
            NoteRichTextBox.Location = new Point(30, 236);
            NoteRichTextBox.Name = "NoteRichTextBox";
            NoteRichTextBox.Size = new Size(1489, 614);
            NoteRichTextBox.TabIndex = 8;
            NoteRichTextBox.Text = "";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1331, 891);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(188, 58);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "Cancel";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(1100, 891);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(188, 58);
            OkButton.TabIndex = 10;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // NoteEditForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 979);
            Controls.Add(OkButton);
            Controls.Add(ExitButton);
            Controls.Add(NoteRichTextBox);
            Controls.Add(ModifiedLabel);
            Controls.Add(ModifiedDatePicker);
            Controls.Add(CreatedDatePicker);
            Controls.Add(CategoryComboBox);
            Controls.Add(TitleTextBox);
            Controls.Add(CreatedLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(TitleLabel);
            Name = "NoteEditForm";
            Text = "NoteEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label CategoryLabel;
        private Label CreatedLabel;
        private TextBox TitleTextBox;
        private ComboBox CategoryComboBox;
        private DateTimePicker CreatedDatePicker;
        private DateTimePicker ModifiedDatePicker;
        private Label ModifiedLabel;
        private RichTextBox NoteRichTextBox;
        private Button ExitButton;
        private Button OkButton;
    }
}