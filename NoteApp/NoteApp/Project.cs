using Newtonsoft.Json;
using System.ComponentModel;

namespace NoteApp
{
    public class Project : INotifyPropertyChanged
    { 
        /// <summary>
        /// event для обновления свойств
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
  
        
        private List<Note> _notes = new();
        private List<Note> _filteredNotes = new();
        private List<string> _noteTypeList = new();

        private Note? _selectedNote;
        
        
        /// <summary>
        /// .ctor
        /// </summary>
        public Project() 
        { 
            Notes = new List<Note>();
            if (_noteTypeList.Count == 0)
                NoteTypeList = Enum.GetValues(typeof(NoteType))
                    .Cast<NoteType>()
                    .Select(v => v.ToString())
                    .ToList();
        }
        
        /// <summary>
        /// Список заметок
        /// </summary>
        [JsonProperty]
        public List<Note> Notes
        {
            get => _notes;
            set
            {
                _notes = value;
                OnPropertyChanged(nameof(Notes));
            }
        }

        /// <summary>
        /// Список отфильтрованных заметок
        /// </summary>
        [JsonIgnore]
        public List<Note> FilteredNotes
        {
            get => _filteredNotes;
            set
            {
                _filteredNotes= value;
                OnPropertyChanged(nameof(FilteredNotes));
            }
        }


        /// <summary>
        /// Создание заметки
        /// </summary>
        /// <returns></returns>
        public Note CreateNote() 
        {
            var note = new Note("Временное название", NoteType.Misc);
            Notes.Add(note);
            return note;
        }

        /// <summary>
        /// Удаление заметки
        /// </summary>
        /// <param name="note"></param>
        public void RemoveNote(Note note) 
        { 
            _notes.Remove(note);
        }

        /// <summary>
        /// Список типов заметок
        /// </summary>
        [JsonIgnore]
        public List<string> NoteTypeList 
        {
            get => _noteTypeList;
            set
            {
                _noteTypeList = value;
                OnPropertyChanged(nameof(NoteTypeList));
            }
        }

        /// <summary>
        /// Получить список заметок с типом All
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetNoteTypeListWithAll()
        {
            var list = new List<string>(NoteTypeList) { "All" };
            return list;
        }

        /// <summary>
        /// Выбранная заметка
        /// </summary>
        [JsonIgnore]
        public Note? SelectedNote
        { 
            get => _selectedNote;
            set
            {
                _selectedNote = value;
                OnPropertyChanged(nameof(SelectedNote));
            }
        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
