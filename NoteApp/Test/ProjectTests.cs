using NoteApp;
using Xunit;

namespace Test;

public class ProjectTests
{
    [Fact]
    public void Project_Ctor_ShouldBeNotEmptyTypes()
    {
        var project = new Project();

        Assert.NotEmpty(project.NoteTypeList);
    }

    [Fact]
    public void Project_GetNoteTypeListWithAll_ExistsAll()
    {
        var project = new Project();
        
        Assert.DoesNotContain(project.NoteTypeList, x =>x.Equals("all", StringComparison.CurrentCultureIgnoreCase));
        
        Assert.Contains(project.GetNoteTypeListWithAll(), x =>x.Equals("all", StringComparison.CurrentCultureIgnoreCase));
    }
    
    [Fact]
    public void Project_Create_ShouldCorrectNoteProperties()
    {
        var project = new Project();
        var note = project.CreateNote();
        
        Assert.Equal(NoteType.Misc, note.Type);
        Assert.Equal("Временное название", note.Name);
        Assert.Empty(note.NoteText);
        Assert.NotEqual(new DateTime(), note.CreatedDateTime);
        Assert.NotEqual(new DateTime(), note.ModifiedDateTime);
    }
    [Fact]
    public void Project_Create_ShouldCorrectNotes()
    {
        var project = new Project();
        Assert.Empty(project.Notes);
        project.CreateNote();
        Assert.Single(project.Notes);
    }
    
    [Fact]
    public void Project_Remove_ShouldEmptyNotes()
    {
        var project = new Project();
        var note = project.CreateNote();
        project.RemoveNote(note);
        Assert.Empty(project.Notes);
    }
    
    [Fact]
    public void Project_FilteredNote_IsEmpty()
    {
        var project = new Project();
        project.CreateNote();
        Assert.Single(project.Notes);
        Assert.Empty(project.FilteredNotes);
    }
    
    [Fact]
    public void Project_SetFilteredNote_ShouldBeNotEmpty()
    {
        var project = new Project();
        project.CreateNote();
        project.FilteredNotes = project.Notes;
        Assert.Single(project.Notes);
        Assert.Single(project.FilteredNotes);
    }
    
    [Fact]
    public void Project_SetSelectedNote_ShouldBeNotNull()
    {
        var project = new Project();
        var note = project.CreateNote();
        project.SelectedNote = note;
        Assert.NotNull(project.SelectedNote);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void UpdateNote_ShouldBeIncorrectName(string? name)
    {
        var project = new Project();
        var note = project.CreateNote();

        var (isSuccess, errorMessage) = note.UpdateNote(name, NoteType.Documents, "");
        Assert.False(isSuccess);
        Assert.Equal("Не заполнено имя", errorMessage);
    }
    
    [Fact]
    public void UpdateNote_ShouldBeIncorrectType()
    {
        var project = new Project();
        var note = project.CreateNote();

        var (isSuccess, errorMessage) = note.UpdateNote("name", null, "");
        Assert.False(isSuccess);
        Assert.Equal("Не выбран тип", errorMessage);
    }
    
    [Fact]
    public void UpdateNote_ShouldBeOk()
    {
        var project = new Project();
        var note = project.CreateNote();

        var (isSuccess, _) = note.UpdateNote("name", NoteType.Documents, "document");
        Assert.True(isSuccess);
        Assert.Equal("document",note.NoteText);
        Assert.Equal("name",note.Name);
        Assert.True(note.ModifiedDateTime > note.CreatedDateTime);
    }
}