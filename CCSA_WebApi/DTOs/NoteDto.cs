using CCSANoteApp.Domain;

namespace CCSA_WebApi.DTOs
{
    public class NoteDto
    {
        public virtual User NoteCreator { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual GroupName Group { get; set; }

    }
}
