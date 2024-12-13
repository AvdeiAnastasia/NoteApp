using Newtonsoft.Json;
using System.ComponentModel;

namespace NoteApp
{
    public class Note : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private NoteType _type;
        private string _name = "";
        private string _noteText = "";

        ///<summary>
        /// Наименование заметки
        ///</summary>
        [JsonProperty]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }


        ///<summary>
        /// Тип заметки
        ///</summary>
        [JsonProperty]
        public NoteType Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        ///<summary>
        /// Текст заметки
        ///</summary>
        public string NoteText
        {
            get => _noteText;
            set
            {
                _noteText = value;
                OnPropertyChanged(nameof(NoteText));
            }
        }

        ///<summary>
        /// Дата создания заметки
        ///</summary>
        [JsonProperty]
        public DateTime CreatedDateTime { get; set; }

        ///<summary>
        /// Дата редактирования заметки
        ///</summary>
        [JsonProperty]
        public DateTime ModifiedDateTime { get; set; }

        /// <summary>
        /// .ctor
        /// </summary>
        public Note(string name, NoteType type)
        {
            Name = name;
            Type = type;
            CreatedDateTime = DateTime.Now;
            ModifiedDateTime = DateTime.Now;
        }

        /// <summary>
        /// Изменить заметку
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="noteText"></param>
        /// <returns></returns>
        public (bool, string) UpdateNote(string? name, NoteType? type, string noteText)
        {
            if (string.IsNullOrWhiteSpace(name))
                return (false, "Не заполнено имя");
            if (type == null)
                return (false, "Не выбрана категория");
            if (name.Length > 50)
                return (false, "Название не должно превышать 50 символов");

            Name = name;
            Type = type.Value;
            NoteText = noteText;
            ModifiedDateTime = DateTime.Now;

            return (true, "");
        }

        /// <summary>
        /// Строкое представление объекта
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}