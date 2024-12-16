using Note_APP.DTO;

namespace Note_APP.Interfaces
{
    public interface INotesRepository
    {
        Task<List<NoteDTO>> getNotes();
        Task<int> updateNote(NoteDTO note);
        Task<int> deleteNote(int id);
        Task<int> createNote(NoteDTO note);
    }
}
