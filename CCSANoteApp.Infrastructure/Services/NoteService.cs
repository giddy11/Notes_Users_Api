using CCSANoteApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSANoteApp.Infrastructure.Services
{
    public class NoteService : INoteService
    {
        List<Note> notes = new List<Note>();

        #region NOTE DETAILS
        public void CreateNote(Note note)
        {
            notes.Add(note);
        }

        public void CreateNote(User noteCreator, string title, string content, GroupName group)
        {
            notes.Add(new Note
            {
                NoteCreator = noteCreator,
                Title = title,
                Content = content,
                Group = group,
            });
        }

        public void DeleteNote(Guid id)
        {
            var note = notes.FirstOrDefault(x => x.Id == id);
            if (note != null)
            {
                notes.Remove(note);
            }
        }

        public List<Note> GetAllNote()
        {
            return notes;
        }

        public Note GetAllNoteById(Guid id)
        {
            var note = notes.FirstOrDefault(x => x.Id == id);
            return note;
        }

        public void UpdateNoteByTitle(Guid id, string title)
        {
            var _note = notes.FirstOrDefault(x => x.Id == id);
            if (_note != null)
            {
                _note.Title = title;
            }
        }

        public void UpdateNoteByContent(Guid id, string content)
        {
            var _note = notes.FirstOrDefault(x => x.Id == id);
            if (_note != null)
            {
                _note.Content = content;
            }
        }

        public void UpdateNoteByGroup(Guid id, GroupName group)
        {
            var _note = notes.FirstOrDefault(x => x.Id == id);
            if (_note != null)
            {
                _note.Group = group;
            }
        }

        #endregion
    }
}
