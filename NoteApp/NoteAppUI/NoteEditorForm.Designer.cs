namespace NoteAppUI
{
    partial class NoteEditorForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            _title = new Label();
            _noteName = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            _category = new Label();
            _categorySelector = new ComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            _created = new Label();
            _modified = new Label();
            _dateModified = new ComboBox();
            _dateCreated = new ComboBox();
            _noteText = new RichTextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            _ok = new Button();
            _cancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Controls.Add(_noteText, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.52381F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.47619F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 285F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.942065F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.05794F));
            tableLayoutPanel2.Controls.Add(_title, 0, 0);
            tableLayoutPanel2.Controls.Add(_noteName, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 34);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Dock = DockStyle.Fill;
            _title.Location = new Point(3, 0);
            _title.Name = "_title";
            _title.Size = new Size(65, 34);
            _title.TabIndex = 0;
            _title.Text = "Title:";
            _title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _noteName
            // 
            _noteName.Dock = DockStyle.Fill;
            _noteName.Location = new Point(74, 3);
            _noteName.Name = "_noteName";
            _noteName.Size = new Size(717, 27);
            _noteName.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.3571434F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.64286F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 457F));
            tableLayoutPanel3.Controls.Add(_category, 0, 0);
            tableLayoutPanel3.Controls.Add(_categorySelector, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 43);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(794, 34);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // _category
            // 
            _category.AutoSize = true;
            _category.Dock = DockStyle.Fill;
            _category.Location = new Point(3, 0);
            _category.Name = "_category";
            _category.Size = new Size(96, 34);
            _category.TabIndex = 0;
            _category.Text = "Category: ";
            _category.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _categorySelector
            // 
            _categorySelector.Dock = DockStyle.Fill;
            _categorySelector.FormattingEnabled = true;
            _categorySelector.Location = new Point(105, 3);
            _categorySelector.Name = "_categorySelector";
            _categorySelector.Size = new Size(228, 28);
            _categorySelector.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.6887436F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.3112564F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tableLayoutPanel4.Controls.Add(_created, 0, 0);
            tableLayoutPanel4.Controls.Add(_modified, 2, 0);
            tableLayoutPanel4.Controls.Add(_dateModified, 1, 0);
            tableLayoutPanel4.Controls.Add(_dateCreated, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 83);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(794, 36);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // _created
            // 
            _created.AutoSize = true;
            _created.Dock = DockStyle.Fill;
            _created.Location = new Point(3, 0);
            _created.Name = "_created";
            _created.Size = new Size(135, 36);
            _created.TabIndex = 0;
            _created.Text = "Created:";
            _created.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _modified
            // 
            _modified.AutoSize = true;
            _modified.Dock = DockStyle.Fill;
            _modified.Location = new Point(305, 0);
            _modified.Name = "_modified";
            _modified.Size = new Size(152, 36);
            _modified.TabIndex = 1;
            _modified.Text = "Modified:";
            _modified.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _dateModified
            // 
            _dateModified.Dock = DockStyle.Fill;
            _dateModified.Enabled = false;
            _dateModified.FormattingEnabled = true;
            _dateModified.Location = new Point(144, 3);
            _dateModified.Name = "_dateModified";
            _dateModified.Size = new Size(155, 28);
            _dateModified.TabIndex = 2;
            // 
            // _dateCreated
            // 
            _dateCreated.Dock = DockStyle.Fill;
            _dateCreated.Enabled = false;
            _dateCreated.FormattingEnabled = true;
            _dateCreated.Location = new Point(463, 3);
            _dateCreated.Name = "_dateCreated";
            _dateCreated.Size = new Size(164, 28);
            _dateCreated.TabIndex = 3;
            // 
            // _noteText
            // 
            _noteText.Dock = DockStyle.Fill;
            _noteText.Location = new Point(3, 125);
            _noteText.Name = "_noteText";
            _noteText.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            _noteText.Size = new Size(794, 279);
            _noteText.TabIndex = 3;
            _noteText.Text = "";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.0638F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9362049F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(_ok, 1, 0);
            tableLayoutPanel5.Controls.Add(_cancel, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 410);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(794, 37);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // _ok
            // 
            _ok.Dock = DockStyle.Fill;
            _ok.Location = new Point(521, 3);
            _ok.Name = "_ok";
            _ok.Size = new Size(123, 31);
            _ok.TabIndex = 0;
            _ok.Text = "OK";
            _ok.UseVisualStyleBackColor = true;
            // 
            // _cancel
            // 
            _cancel.Dock = DockStyle.Fill;
            _cancel.Location = new Point(650, 3);
            _cancel.Name = "_cancel";
            _cancel.Size = new Size(120, 31);
            _cancel.TabIndex = 1;
            _cancel.Text = "Cancel";
            _cancel.UseVisualStyleBackColor = true;
            // 
            // NoteEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "NoteEditorForm";
            Text = "Add/Edit Note";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label _title;
        private TextBox _noteName;
        private TableLayoutPanel tableLayoutPanel3;
        private Label _category;
        private ComboBox _categorySelector;
        private TableLayoutPanel tableLayoutPanel4;
        private Label _created;
        private Label _modified;
        private ComboBox _dateCreated;
        private ComboBox _dateModified;
        private RichTextBox _noteText;
        private TableLayoutPanel tableLayoutPanel5;
        private Button _ok;
        private Button _cancel;

        public TextBox GetNoteNameControl() 
        { 
            return _noteName;
        }

        public ComboBox GetCategoryControl()
        {
            return _categorySelector;
        }

        public ComboBox GetDateCreatedControl()
        {
            return _dateCreated;
        }

        public ComboBox GetDateModifiedControl()
        {
            return _dateModified;
        }

        public RichTextBox GetNoteTextControl() 
        { 
            return _noteText;
        }

        public Button GetOkButton() 
        {
            return _ok;
        }

        public Button GetCancelButton()
        {
            return _cancel;
        }
    }
}