using NoteApp;

namespace NoteAppUI
{
    public partial class NoteEditForm : Form
    {
        private readonly Project _project;

        /// <summary>
        /// .ctor
        /// </summary>
        public NoteEditForm(Project project)
        {
            InitializeComponent();
            _project = project;
            CategoryComboBox.DataSource = _project.NoteTypeList;

            if (_project.SelectedNote == null) return;
            CreatedDatePicker.Value = _project.SelectedNote.CreatedDateTime;
            ModifiedDatePicker.Value = _project.SelectedNote.ModifiedDateTime;
            TitleTextBox.Text = _project.SelectedNote.Name;
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteType));
            CategoryComboBox.SelectedItem = _project.SelectedNote.Type;
            NoteRichTextBox.Text = _project.SelectedNote.NoteText;

            this.SetNotChangedSize();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_project.SelectedNote == null)
            {
                MessageBox.Show("Заметка не выбрана", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var item = CategoryComboBox.SelectedItem;
            var (isSuccess, errorMessage) = _project.SelectedNote.UpdateNote(TitleTextBox.Text, item is NoteType noteType ? noteType : null, NoteRichTextBox.Text);

            if (isSuccess)
                Close();
            else
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
