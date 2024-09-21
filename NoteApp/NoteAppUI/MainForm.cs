using System.ComponentModel;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        private TableLayoutPanel _mainRows;
        private MenuStrip _mainMenu;
        private Panel _mainPanel;
        private Panel _leftColumn;
        private Panel _rightColumn;
        private ComboBox _noteTypeFilter;
        private ListBox _notes;
        private RichTextBox _noteText;
        private Label _noteName;
        private Label _noteCategoryData;
        private Label _noteCreatedText;
        private Label _noteModifiedText;
        private ComboBox _noteCreatedDate;
        private ComboBox _noteModifiedDate;

        private MainFormController _controller;

        public MainForm()
        {
            InitializeComponent();
            InitializeMainRows();
            var project = ProjectManager.LoadFromFile();
            if (project == null) project = new Project();
            _controller = new MainFormController(this, project);
        }

        public ListBox GetNotesListControl() 
        { 
            return _notes;
        }

        public ComboBox GetNoteTypeFilterControl() 
        {  
            return _noteTypeFilter; 
        }

        public RichTextBox GetNoteTextControl() 
        { 
            return _noteText;
        }

        public MenuStrip GetMainMenu() 
        {
            return _mainMenu;
        }

        public ComboBox GetNoteTypeFilter() 
        {
            return _noteTypeFilter;
        }

        public Label GetNoteNameControl() 
        {
            return _noteName;
        }

        public Label GetNoteCategoryControl()
        {
            return _noteCategoryData;
        }

        public ComboBox GetNoteCreatedDateControl() 
        {
            return _noteCreatedDate;
        }

        public ComboBox GetNoteModifiedDateControl()
        {
            return _noteModifiedDate;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Name = "MainForm";
            Text = "NoteApp";
            ResumeLayout(false);
        }

        private void InitializeMainRows() 
        {
            _mainRows = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1,
            };
            _mainRows.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            _mainRows.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            Controls.Add(_mainRows);
            InitializeMainMenu(_mainRows);
            InitializeMainPanel(_mainRows);
        }

        private void InitializeMainMenu(TableLayoutPanel mainRows) 
        {
            var newFileMenu = new ToolStripMenuItem
            {
                Name = "newFileMenu",
                Dock = DockStyle.Fill,
                Text = "New",
                ShortcutKeyDisplayString = "Ctrl + N"
            };
            var saveMenu = new ToolStripMenuItem
            {
                Name = "saveMenu",
                Dock = DockStyle.Fill,
                Text = "Save",
                ShortcutKeyDisplayString = "Ctrl + S"
            };
            var fileMenu = new ToolStripMenuItem
            {
                Name = "FileMenu",
                Dock = DockStyle.Fill,
                Text = "File",
                DropDownItems = { newFileMenu, saveMenu }
            };


            var renameMenu = new ToolStripMenuItem
            {
                Name = "RenameMenu",
                Dock = DockStyle.Fill,
                Text = "Rename"
            };
            var deleteMenu = new ToolStripMenuItem
            {
                Name = "DeleteMenu",
                Dock = DockStyle.Fill,
                Text = "Delete",
                ShortcutKeyDisplayString = "Del"
            };
            var editMenu = new ToolStripMenuItem 
            {
                Name = "EditMenu",
                Dock = DockStyle.Fill,
                Text = "Edit",
                DropDownItems = { renameMenu, deleteMenu }
            };

            var helpMenu = new ToolStripMenuItem
            {
                Name = "HelpMenu",
                Dock = DockStyle.Fill,
                Text = "Help",
            };

            _mainMenu = new MenuStrip
            {
                Name = "MainMenuToolbar",
                Dock = DockStyle.Fill,
            };
            _mainMenu.Items.AddRange(new ToolStripMenuItem[] { fileMenu, editMenu, helpMenu });
            mainRows.SetRow(_mainMenu, 0);
            mainRows.Controls.Add(_mainMenu);
        }

        private void InitializeMainPanel(TableLayoutPanel mainRows)
        {
            _mainPanel = new Panel { Dock = DockStyle.Fill };
            mainRows.SetRow(_mainPanel, 1);
            mainRows.Controls.Add(_mainPanel);

            var twoColumnsTableLayout = new TableLayoutPanel 
            { 
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 2,
            };
            twoColumnsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            twoColumnsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66F));
            _mainPanel.Controls.Add(twoColumnsTableLayout);
            InitializeLeftColumn(twoColumnsTableLayout);
            InitializeRightColumn(twoColumnsTableLayout);
        }

        private void InitializeLeftColumn(TableLayoutPanel twoColumnTable) 
        {
            _leftColumn = new Panel { Dock = DockStyle.Fill };
            twoColumnTable.SetColumn(_leftColumn, 0);
            twoColumnTable.Controls.Add(_leftColumn);

            var leftColumnTableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
                ColumnCount = 1,
            };
            leftColumnTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            leftColumnTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            leftColumnTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));

            _leftColumn.Controls.Add(leftColumnTableLayout);

            InitializeNoteTypeBox(leftColumnTableLayout);
            InitializeNoteList(leftColumnTableLayout);
        }

        private void InitializeNoteTypeBox(TableLayoutPanel leftColumnTableLayout)
        {
            _noteTypeFilter = new ComboBox { Dock = DockStyle.Fill};
            var noteCategory = new Label
            {
                Name = "NoteCategory",
                Text = "Show Category:",
                Dock = DockStyle.Fill
            };
            var categoryFilterPanel = new Panel { Dock = DockStyle.Fill };
            var categoryFilterLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 2
            };
            categoryFilterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            categoryFilterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75));

            leftColumnTableLayout.SetRow(categoryFilterPanel, 0);
            leftColumnTableLayout.Controls.Add(categoryFilterPanel);

            categoryFilterPanel.Controls.Add(categoryFilterLayout);
            categoryFilterLayout.SetColumn(noteCategory, 0);
            categoryFilterLayout.SetColumn(_noteTypeFilter, 1);
            categoryFilterLayout.Controls.AddRange(new Control[] { noteCategory, _noteTypeFilter });
        }

        private void InitializeNoteList(TableLayoutPanel leftColumnTableLayout)
        {
            _notes = new ListBox
            {
                Name = "AvailableNotes",
                Dock = DockStyle.Fill
            };

            leftColumnTableLayout.SetRow(_notes, 1);
            leftColumnTableLayout.Controls.Add(_notes);
        }

        private void InitializeRightColumn(TableLayoutPanel twoColumnTable)
        {
            _rightColumn = new Panel { Dock = DockStyle.Fill };
            twoColumnTable.SetColumn(_rightColumn, 1);
            twoColumnTable.Controls.Add(_rightColumn);

            var twoRowsLayout = new TableLayoutPanel 
            { 
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1
            };
            twoRowsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            twoRowsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));

            _rightColumn.Controls.Add(twoRowsLayout);
            InitializeNoteDataPanel(twoRowsLayout);
            InitializeTextBox(twoRowsLayout);

        }

        private void InitializeNoteDataPanel(TableLayoutPanel twoRowsPanel) 
        {
            _noteName = new Label
            {
                Dock = DockStyle.Fill,
                Text = "PlaceHolder",
                Font = new Font(Name = "Segoe UI", 14, FontStyle.Bold, GraphicsUnit.Point)
            };

            _noteCategoryData = new Label
            { 
                Dock = DockStyle.Fill,
                Text = "Category: "
            };

            var threeRowsLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
                ColumnCount = 1
            };

            threeRowsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            threeRowsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            threeRowsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));

            twoRowsPanel.SetRow(threeRowsLayout, 0);
            twoRowsPanel.Controls.Add(threeRowsLayout);

            threeRowsLayout.SetRow(_noteName, 0);
            threeRowsLayout.Controls.Add(_noteName);
            threeRowsLayout.SetRow(_noteCategoryData, 1);
            threeRowsLayout.Controls.Add(_noteCategoryData);

            var noteChangesData = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 5
            };

            threeRowsLayout.SetRow(noteChangesData, 2);
            threeRowsLayout.Controls.Add(noteChangesData);
            noteChangesData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            noteChangesData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            noteChangesData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            noteChangesData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            noteChangesData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            InitializeNoteDataControls(noteChangesData);
        }

        private void InitializeNoteDataControls(TableLayoutPanel noteChangesData) 
        {
            _noteCreatedText = new Label
            {
                Dock = DockStyle.Fill,
                Text = "Created: "
            };

            _noteModifiedText = new Label
            { 
                Dock = DockStyle.Fill,
                Text = "Modified: "
            };

            _noteCreatedDate = new ComboBox
            {
                Dock = DockStyle.Fill,
                Enabled = false,
            };

            _noteModifiedDate = new ComboBox
            {
                Dock = DockStyle.Fill,
                Enabled= false,
            };

            noteChangesData.SetColumn(_noteCreatedText, 0);
            noteChangesData.SetColumn(_noteCreatedDate, 1);
            noteChangesData.SetColumn(_noteModifiedText, 2);
            noteChangesData.SetColumn(_noteModifiedDate, 3);
            noteChangesData.Controls.AddRange(new Control[]
            {
                _noteCreatedText,
                _noteCreatedDate,
                _noteModifiedText,
                _noteModifiedDate,
            });
        }

        private void InitializeTextBox(TableLayoutPanel twoRowsPanel) 
        {
            _noteText = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ScrollBars = RichTextBoxScrollBars.ForcedBoth,
                Multiline = true,
                Enabled = false
            };
            twoRowsPanel.SetRow(_noteText, 1);
            twoRowsPanel.Controls.Add(_noteText);
        }
    }
}
