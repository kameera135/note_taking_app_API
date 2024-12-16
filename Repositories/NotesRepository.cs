using Microsoft.EntityFrameworkCore;
using Note_APP.DTO;
using Note_APP.Interfaces;
using Note_APP.Models;

namespace Note_APP.Repositories
{
    public class NotesRepository : INotesRepository
    {
        private readonly NotesContext m_noteContext;

        public NotesRepository(NotesContext noteContext)
        {
            m_noteContext = noteContext;
        }

        public Task<int> createNote(NoteDTO note)
        {
            throw new NotImplementedException();
        }

        public Task<int> deleteNote(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<NoteDTO>> getNotes()
        {
            try
            {
                List<Note> note = new List<Note>();
                    
                note = m_noteContext.Notes.Where(q=>q.DeletedAt == null).ToList();

                if (note == null)
                {
                    throw new Exception("There is no values for notes");
                }

                List<NoteDTO> result = new List<NoteDTO>();

                foreach (Note n in note)
                {
                    NoteDTO tempNote = new()
                    {
                        id = n.Id,
                        title = n.Title,
                        description = n.Description,
                    };

                    result.Add(tempNote);
                }
                
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<int> updateNote(NoteDTO note)
        {
            throw new NotImplementedException();
        }
    }
}
