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

            this.SetNotChangedSize();
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
            ChangeNote(null);
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
            SetBindingNoteListBox();

            //if (d?.Type.ToString() == item)
            //    ChangeNote(_project.SelectedNote);
            //else
                ChangeNote(null);
            
        }

        /// <summary>
        /// Смена заметки
        /// </summary>
        private void ChangeNote(Note? selectedNote)
        {
            var item = selectedNote ?? NotelistBox.SelectedItem;
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
                dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
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
            var selectedCategory = _project.SelectedNote.Type.ToString().ToLower();
            
            CategoryComboBox.SelectedItem = _project
                .GetNoteTypeListWithAll()
                .FirstOrDefault(x => x.ToLower() == selectedCategory);
        }

        /// <summary>
        /// Добавление заметки
        /// </summary>
        private void AddNote()
        {
            _project.SelectedNote = _project.CreateNote();
            var noteEditForm = new NoteEditForm(_project);

            var dialogResut = noteEditForm.ShowDialog();
            if (dialogResut == DialogResult.Cancel)
            {
                _project.RemoveNote(_project.SelectedNote);
                return;
            }

            var selectedCategory = _project.SelectedNote.Type.ToString().ToLower();

            CategoryComboBox.SelectedItem = _project
                .GetNoteTypeListWithAll()
                .FirstOrDefault(x => x.ToLower() == selectedCategory);
            SetBindingNoteListBox();
        }

        /// <summary>
        /// Удаление заметки
        /// </summary>
        private void DeleteNote()
        {
            if (_project.SelectedNote == null) return;
            var messageBox = MessageBox.Show($"Вы уверены что хотите удалить заметку {_project.SelectedNote.Name}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;

            if (messageBox == DialogResult.Yes)
            {
                _project.RemoveNote(_project.SelectedNote);
                NotelistBox.DataSource = null;
                NotelistBox.DataSource = _project.Notes;
                CategoryComboBox.SelectedItem = _project
                .GetNoteTypeListWithAll()
                .FirstOrDefault(x => x.ToLower() == "all");
            }
        }

        /// <summary>
        /// Установка зависимостей для списка заметок
        /// </summary>
        private void SetBindingNoteListBox()
        {
            var selectedNote = _project.SelectedNote;
            var item = CategoryComboBox.SelectedItem?.ToString()?.ToLower();
            if (item == null || item.Equals("all", StringComparison.OrdinalIgnoreCase))
                _project.FilteredNotes = _project.Notes;
            else
                _project.FilteredNotes = _project.Notes.Where(x => x.Type.ToString().ToLower() == item).ToList();

            NotelistBox.DataSource = null;
            var binding = new BindingList<Note>(_project.FilteredNotes);
            var bSource = new BindingSource();
            bSource.DataSource = binding;
            NotelistBox.DataSource = bSource;
            NotelistBox.DisplayMember = "Name";
            if (selectedNote != null)
            {
                NotelistBox.SelectedItem = selectedNote;

            }
        }

        /// <summary>
        /// Установка зависимостей
        /// </summary>
        private void SetBinding()
        {
            NoteRichTextBox.DataBindings.Clear();
            TitleLabel.DataBindings.Clear();
            CategoryLabel.DataBindings.Clear();
            if (_project.SelectedNote == null)
            {
                NoteRichTextBox.Text = null;
                TitleLabel.Text = null;
                CategoryLabel.Text = null;
            }
            else
            {
                NoteRichTextBox.DataBindings.Add("Text", _project.SelectedNote, "NoteText");
                TitleLabel.DataBindings.Add("Text", _project.SelectedNote, "Name");
                CategoryLabel.DataBindings.Add("Text", _project.SelectedNote, "Type");
            }
        }
    }
}