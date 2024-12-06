using System.ComponentModel;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        private readonly Project _project;
        private readonly FileRepository _fileRepository = new();

        public MainForm()
        {
            InitializeComponent();
            var project = _fileRepository.LoadProject();
            project ??= new Project();
            _project = project!;

            CategoryComboBox.DataSource = _project.GetNoteTypeListWithAll().OrderBy(x => x).ToList();
            SetBinding();
            SetBindingNoteListBox();


            addNoteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            editNoteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            removeNoteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            aboutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _fileRepository.SaveProject(_project);
        }


        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeNote();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void NoteListBox_DoubleClick(object sender, EventArgs e)
        {
            EditNote();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = CategoryComboBox.SelectedItem?.ToString()?.ToLower();
            if (item == null || item.Equals("all", StringComparison.OrdinalIgnoreCase))
            {
                _project.FilteredNotes = _project.Notes;
            }
            else

            {
                _project.FilteredNotes = _project.Notes.Where(x => x.Type.ToString().ToLower() == item).ToList();
            }

            ChangeNote();
            SetBindingNoteListBox();
        }

        /// <summary>
        /// Смена заметки
        /// </summary>
        private void ChangeNote()
        {
            var item = NotelistBox.SelectedItem;
            _project.SelectedNote = item is not Note note ? null : note;
            SetDate(CreateDatePicker, _project.SelectedNote?.CreatedDateTime);
            SetDate(ModifiedDatePicker, _project.SelectedNote?.ModifiedDateTime);
            SetBinding();
        }

        /// <summary>
        /// Установка дат в DatePicker
        /// </summary>
        /// <param name="dateTimePicker"></param>
        /// <param name="dateTime"></param>
        private void SetDate(DateTimePicker dateTimePicker, DateTime? dateTime)
        {
            if (dateTime == null)
            {
                dateTimePicker.CustomFormat = " ";
                dateTimePicker.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                dateTimePicker.Value = dateTime.Value;
            }
        }


        /// <summary>
        /// Редактирование заметки 
        /// </summary>
        private void EditNote()
        {
            _project.SelectedNote ??= _project.CreateNote();

            var noteEditForm = new NoteEditForm(_project);

            noteEditForm.ShowDialog();
            CategoryComboBox.DataSource = _project.GetNoteTypeListWithAll().OrderBy(x => x).ToList();
        }

        /// <summary>
        /// Добавление заметки
        /// </summary>
        private void AddNote()
        {
            _project.SelectedNote = _project.CreateNote();
            CategoryComboBox.DataSource = _project.GetNoteTypeListWithAll().OrderBy(x => x).ToList();
        }

        /// <summary>
        /// Удаление заметки
        /// </summary>
        private void DeleteNote()
        {
            if (_project.SelectedNote == null) return;
            _project.RemoveNote(_project.SelectedNote);
            NotelistBox.DataSource = null;
            NotelistBox.DataSource = _project.Notes;
        }

        /// <summary>
        /// Установка зависимостей для списка заметок
        /// </summary>
        private void SetBindingNoteListBox()
        {
            NotelistBox.DataSource = null;
            var binding = new BindingList<Note>(_project.FilteredNotes);
            var bSource = new BindingSource();
            bSource.DataSource = binding;
            NotelistBox.DataSource = bSource;
            NotelistBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Установка зависимостей
        /// </summary>
        private void SetBinding()
        {
            if (_project.SelectedNote == null)
                return;
            NoteRichTextBox.DataBindings.Clear();
            NoteRichTextBox.DataBindings.Add("Text", _project.SelectedNote, "NoteText");
            TitleLabel.DataBindings.Clear();
            TitleLabel.DataBindings.Add("Text", _project.SelectedNote, "Name");
            CategoryLabel.DataBindings.Clear();
            CategoryLabel.DataBindings.Add("Text", _project.SelectedNote, "Type");
        }
    }
}