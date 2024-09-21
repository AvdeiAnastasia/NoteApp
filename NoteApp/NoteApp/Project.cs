using Newtonsoft.Json;

namespace NoteApp
{
    public class Project
    {
        public delegate void NoteChanged();
        public event NoteChanged? OnNoteChanged;

        [JsonProperty]
        private List<Note> _notes;
        public IEnumerable<Note> Notes => _notes.OrderBy(x => x.CreatedDateTime);

        public Project() 
        { 
            _notes = new List<Note>();
        }

        public Note CreateNote(string name, NoteType type) 
        {
            var note = new Note(name, type);
            _notes.Add(note);
            note.OnStateChanged += () => OnNoteChanged?.Invoke();
            OnNoteChanged.Invoke();
            return note;
        }

        public void RemoveNote(Note note) 
        { 
            _notes.Remove(note);
        }

        public IEnumerable<Note> FindNotesByName(string name) 
        { 
            return _notes.Where(x => x.Name == name);
        }

        private void OnAfterDeserialize() 
        {
            foreach (var note in _notes) 
            { 
                note.OnStateChanged += () => OnNoteChanged?.Invoke();
            }
        }
    }
}
