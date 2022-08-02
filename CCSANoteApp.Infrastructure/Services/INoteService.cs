using CCSANoteApp.Domain;

namespace CCSANoteApp.Infrastructure.Services
{
    public interface INoteService
    {
        void CreateNote(Note note);
        void CreateNote(User noteCreator, string title, string content, GroupName group);
        void DeleteNote(Guid id);
        List<Note> GetAllNote();
        Note GetAllNoteById(Guid id);
        void UpdateNoteByContent(Guid id, string content);
        void UpdateNoteByGroup(Guid id, GroupName group);
        void UpdateNoteByTitle(Guid id, string title);
    }
}
