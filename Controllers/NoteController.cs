using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Note_APP.DTO;
using Note_APP.Interfaces;
using Note_APP.Models;

namespace Note_APP.Controllers
{
    [Route("api/")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INotesRepository m_notesRepository;

        public NoteController(INotesRepository notesRepository)
        {
            m_notesRepository = notesRepository;
        }

        [HttpGet("Notes")]
        public async Task<IActionResult> GetNotes()
        {
            try
            {
                List<NoteDTO> notes = new List<NoteDTO>();
                
                notes = await m_notesRepository.getNotes();
           
                return Ok(notes);
            }
            catch (Exception ex)
            {
                var errorResponse = new
                {
                    Message = ex.Message,
                };

                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
            finally { }
        }
    }
}
