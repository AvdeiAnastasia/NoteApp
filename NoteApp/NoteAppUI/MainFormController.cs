using NoteApp;
using System.Windows.Forms;

namespace NoteAppUI
{
    public class MainFormController
    {
        private MainForm _mainForm;
        private Project _project;

        public MainFormController(MainForm mainForm, Project currentProject)
        {
            _mainForm = mainForm;
            _project = currentProject;
            AddNewFileHandler(mainForm);
            AddNoteCreationHandler(currentProject, mainForm);
            AddSaveFileHandler(mainForm);
            AddNoteSelectionHandler();
            ParseNoteTypes();
            AddEditHandler(currentProject);
            UpdateNoteList(currentProject);
        }

        private void AddNewFileHandler(MainForm form) 
        { 
            var mainMenu = form.GetMainMenu();
            var newFileMenu = ((ToolStripMenuItem) mainMenu.Items[0]).DropDownItems[0];
            newFileMenu.Click += (sender, args) => _project.CreateNote("Nameless", NoteType.Misc);
        }

        private void AddSaveFileHandler(MainForm form) 
        {
            var mainMenu = form.GetMainMenu();
            var SaveFileMenu = ((ToolStripMenuItem)mainMenu.Items[0]).DropDownItems[1];
            SaveFileMenu.Click += (sender, args) => ProjectManager.SaveToFile(_project);
        }

        private void AddNoteCreationHandler(Project project, MainForm form) 
        {
            var noteList = form.GetNotesListControl();
            project.OnNoteChanged += () => UpdateNoteList(project);
        }

        private void UpdateNoteList(Project project) 
        {
            var noteList = _mainForm.GetNotesListControl();
            noteList.Items.Clear();
            foreach ( var note in project.Notes) 
            {
                noteList.Items.Add(note.Name);
            }
        }

        private void AddNoteSelectionHandler() 
        {
            var noteList = _mainForm.GetNotesListControl();
            noteList.SelectedIndexChanged += (sender, args) => UpdateNoteInformation();
        }

        private void UpdateNoteInformation() 
        {
            var selectetNote = _mainForm.GetNotesListControl().SelectedItem.ToString();
            var note = _project.Notes.Where(x => x.Name == selectetNote).FirstOrDefault();
            if (note != null)
            {
                UpdateNoteTextBox(note);
                var noteNameLabel = _mainForm.GetNoteNameControl();
                noteNameLabel.Text = note.Name;

                var noteCreated = _mainForm.GetNoteCreatedDateControl();
                noteCreated.Text = note.CreatedDateTime.ToString();

                var noteModified = _mainForm.GetNoteModifiedDateControl();
                noteModified.Text = note.ModifiedDateTime.ToString();

                var noteCategory = _mainForm.GetNoteCategoryControl();
                noteCategory.Text = note.Type.ToString();

            }
        }

        private void UpdateNoteTextBox(Note? note)
        {
            var textBox = _mainForm.GetNoteTextControl();
            textBox.Text = string.Empty;
            if (note.NoteText != null)
            {
                foreach (var text in note.NoteText)
                {
                    textBox.Text += text;
                }
            }
        }

        private void ParseNoteTypes() 
        {
            var noteTypeFilter = _mainForm.GetNoteTypeFilter();
            var noteTypes = Enum.GetNames(typeof(NoteType));
            noteTypeFilter.Items.Add("All");
            if (noteTypes != null) 
            { 
                noteTypeFilter.Items.AddRange(noteTypes);
            }
            noteTypeFilter.SelectedItem = noteTypeFilter.Items[0];
        }

        private void OpenEditWindow(Project currentProject) 
        {
            var selectetNote = _mainForm.GetNotesListControl().SelectedItem?.ToString();
            var note = _project.Notes.Where(x => x.Name == selectetNote).FirstOrDefault();

            var editWindow = new NoteEditorForm();
            var category = editWindow.GetCategoryControl();
            category.Items.AddRange(Enum.GetNames(typeof(NoteType)));

            if (note == null) note = currentProject.CreateNote("Nameless", NoteType.Misc);

            var noteName = editWindow.GetNoteNameControl();
            noteName.Text = note.Name;
                
            var noteCreated = editWindow.GetDateCreatedControl();
            noteCreated.Text = note.CreatedDateTime.ToString();

            var noteModified = editWindow.GetDateModifiedControl();
            noteModified.Text = note.ModifiedDateTime.ToString();

            var noteText = editWindow.GetNoteTextControl();
            foreach (var text in note.NoteText) 
            {
                noteText.Text += text;
            }

            var okButton = editWindow.GetOkButton();
            okButton.Click += (sender, args) => OkButtonHandler(editWindow, note);

            editWindow.Show();
        }

        private void AddEditHandler(Project currentProject) 
        {
            var mainMenu = _mainForm.GetMainMenu();
            var EditMenu = ((ToolStripMenuItem)mainMenu.Items[1]).DropDownItems[0];
            EditMenu.Click += (sender, args) => OpenEditWindow(currentProject);
        }

        private void OkButtonHandler(NoteEditorForm editorForm, Note note) 
        { 
            var noteName = editorForm.GetNoteNameControl().Text;
            var noteText = editorForm.GetNoteTextControl().Text;
            var noteCategory = editorForm.GetCategoryControl().Text;

            try 
            {
                note.Rename(noteName);
                note.ChangeNoteType((NoteType)Enum.Parse(typeof(NoteType), noteCategory));
                note.ChangeNoteText(noteText.Split("\n").Select(x=> x + "\n").ToArray());
                editorForm.Close();
            }
            catch (Exception ex) 
            {
                
            }
        }
    }
}
