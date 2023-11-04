using MyNote.DTOs;
using MyNote.Entites;

namespace MyNote.Data.IRepositories
{
	public interface INoteRepository
	{
        List<Note> GetNotes();
        public NoteDTO GetNote(Int64 id);
    }
}

