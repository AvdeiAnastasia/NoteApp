using Newtonsoft.Json;
using NoteApp;
using Xunit;

namespace Test;

public class FileRepositoryTests
{
    [Fact]
    public void SerializeProject_Correct()
    {
        
        var project = new Project();
        var note = project.CreateNote();
        project.FilteredNotes = project.Notes;
        project.SelectedNote = note;
        var expectedJson = JsonConvert.SerializeObject(project);

        var repository = new FileRepository();
        var actualJson = repository.SerializeProject(project);

        Assert.Equal(expectedJson, actualJson);
    }
    
    [Fact]
    public void DeserializeProject_Correct()
    {
        
        var expectedProject = new Project();
        var note = expectedProject.CreateNote();
        expectedProject.FilteredNotes = expectedProject.Notes;
        expectedProject.SelectedNote = note;
        var json = JsonConvert.SerializeObject(expectedProject);
        
        var repository = new FileRepository();
        var actualProject = repository.DeserializeProject(json);
        Assert.NotNull(actualProject);
        Assert.Empty(actualProject.FilteredNotes);
        Assert.Null(actualProject.SelectedNote);
        Assert.Equal(actualProject.Notes.Count, expectedProject.Notes.Count);
    }
}