using Newtonsoft.Json;

namespace NoteApp
{
    public class Note : ICloneable
    {
        public delegate void StateChanged();
        public event StateChanged? OnStateChanged;

        ///<summary>
        ///Returns note's name
        ///</summary>
        [JsonProperty]
        public string Name { get; private set; }
        ///<summary>
        ///Returns note's type
        ///</summary>
        [JsonProperty]
        public NoteType Type { get; private set; }
        ///<summary>
        ///Returns note's text
        ///</summary>
        public IEnumerable<string> NoteText => _noteText;
        ///<summary>
        ///Returns note's time of creation
        ///</summary>
        [JsonProperty]
        public DateTime CreatedDateTime { get; private set; }
        ///<summary>
        ///Returns note's time of last modification
        ///</summary>
        [JsonProperty]
        public DateTime ModifiedDateTime { get; private set; }

        [JsonProperty]
        private string[] _noteText;

        public Note(NoteType type) : this("Nameless Note", type) 
        {
            
        }

        public Note(string name, NoteType type) 
        {
            if (name.Length > 50) throw new ArgumentException();
            else 
            {
                Name = name;
                Type = type;
                _noteText = Array.Empty<string>();
                CreatedDateTime = DateTime.Now;
                ModifiedDateTime = CreatedDateTime;
            }
        }

        [JsonConstructor]
        private Note(string name, NoteType type, DateTime creationTime, DateTime modified, string[] noteText) 
        { 
            Name=name;
            Type = type;
            CreatedDateTime=creationTime;
            ModifiedDateTime=modified;
            _noteText = noteText;
        }

        ///<summary>
        ///Copy current note as new instance
        ///</summary>
        public object Clone()
        {
            var clone = new Note(Name, Type);
            clone.ChangeNoteText(_noteText);
            clone.CreatedDateTime = DateTime.Now;
            clone.ModifiedDateTime = clone.CreatedDateTime;
            return clone;
        }

        ///<summary>
        ///Set new name to current note
        ///</summary>
        public void Rename(string newName) 
        {
            if (newName.Length > 50) throw new ArgumentException();
            else Name = newName;
            UpdateModifiedData();
            OnStateChanged?.Invoke();
        }
        ///<summary>
        ///Set new type to current note
        ///</summary>
        public void ChangeNoteType(NoteType newType) 
        { 
            Type = newType;
            UpdateModifiedData();
            OnStateChanged?.Invoke();
        }
        ///<summary>
        ///Set new text to current note
        ///</summary>
        public void ChangeNoteText(string[] text) 
        { 
            _noteText = text;
            UpdateModifiedData();
            OnStateChanged?.Invoke();
        }

        private void UpdateModifiedData() 
        { 
            ModifiedDateTime = DateTime.Now;
        }
    }
}
