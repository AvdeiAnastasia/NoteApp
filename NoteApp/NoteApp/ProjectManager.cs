using Newtonsoft.Json;
using System.Reflection;
using System.IO;

namespace NoteApp
{
    public static class ProjectManager
    {
        private const string _fileName = "C:\\MyDocuments\\NoteApp.notes";

        public static void SaveToFile(Project currentProject) 
        {
            if (!File.Exists(_fileName))
            {
                if (!Directory.Exists("C:\\MyDocuments")) Directory.CreateDirectory("C:\\MyDocuments");
                var file = File.Create(_fileName);
                file.Close();
            }
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Include;
            serializer.TypeNameHandling = TypeNameHandling.All;
            using (StreamWriter streamWriter = new StreamWriter(_fileName))
            using (JsonWriter JSONWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(JSONWriter, currentProject);
            }
        }

        public static Project LoadFromFile() 
        {
            if (File.Exists(_fileName)) 
            {
                Project project = null;
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader streamReader = new StreamReader(_fileName))
                using (JsonReader JSONReader = new JsonTextReader(streamReader))
                {
                    project = (Project)serializer.Deserialize<Project>(JSONReader);
                    typeof(Project).GetMethod("OnAfterDeserialize", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                        ?.Invoke(project, Array.Empty<object>());
                }
                return project;
            }
            else return new Project();
        }
    }
}
