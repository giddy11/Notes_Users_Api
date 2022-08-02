using CCSA_WebApi.DTOs;
using CCSANoteApp.Domain;
using CCSANoteApp.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace CCSA_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {

        public INoteService NoteService { get; }
        public NotesController(INoteService noteService)
        {
            NoteService = noteService;
        }

        [HttpPost("byNote")]
        public IActionResult CreateNote([FromBody] NoteDto note)
        {
            NoteService.CreateNote(note.NoteCreator, note.Title, note.Content, note.Group);
            return Ok("Created Successfully");
        }

        [HttpDelete]
        public IActionResult DeleteNote(Guid id)
        {
            NoteService.DeleteNote(id);
            return Ok("Deleted Successfully");
        }

        [HttpGet("all-note")]
        public IActionResult GetAllNote()
        {
            return Ok(NoteService.GetAllNote());
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetAllNoteById(Guid id)
        {
            return Ok(NoteService.GetAllNoteById(id));
        }

        [HttpPut("by-title")]
        public IActionResult UpdateNoteByTitle(Guid id, string title)
        {
            NoteService.UpdateNoteByTitle(id, title);
            return Ok("Title Updated Successfully");
        }

        [HttpPut("by-content")]
        public IActionResult UpdateNoteByContent(Guid id, string content)
        {
            NoteService.UpdateNoteByContent(id, content);
            return Ok("Title Updated Successfully");
        }

        [HttpPut("by-group")]
        public IActionResult UpdateNoteByGroup(Guid id, GroupName group)
        {
            NoteService.UpdateNoteByGroup(id, group);
            return Ok("Title Updated Successfully");
        }
    }
}
