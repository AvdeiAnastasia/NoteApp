using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Репозиторий для работы с файлом
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class FileRepository 
    {
        private readonly string _fileName = "C:\\MyDocuments\\NoteApp.json";

        [ExcludeFromCodeCoverage]
        public void SaveProject(Project? currentProject)
        {
            if (!File.Exists(_fileName))
            {
                if (!Directory.Exists("C:\\MyDocuments")) Directory.CreateDirectory("C:\\MyDocuments");
                var file = File.Create(_fileName);
                file.Close();
            }

            var json = SerializeProject(currentProject);
            using var streamWriter = new StreamWriter(_fileName);
            streamWriter.WriteLine(json);
        }

        public string SerializeProject(Project? project)
        {
            return project == null ? "" : JsonConvert.SerializeObject(project);
        }
        
        public Project? DeserializeProject(string json)
        {
            return JsonConvert.DeserializeObject<Project>(json);
        }

        [ExcludeFromCodeCoverage]
        public Project? LoadProject()
        {
            if (!File.Exists(_fileName)) return new Project();
            Project? project;
            using var streamReader = new StreamReader(_fileName);
            var json = streamReader.ReadToEnd();
            try
            {
                project = DeserializeProject(json);
            }
            catch
            {
                project = null;
            }

            return project;

        }
    }
}
