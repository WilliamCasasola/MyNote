using MyNote.Data.IRepositories;
using MyNote.DTOs;
using MyNote.Entites;

namespace MyNote.Services
{
	public class NoteService
	{
		private INoteRepository _note;
		public NoteService(INoteRepository note)
		{
			_note = note;
		}

		public List<Note> GetNotesData()
		{
			return _note.GetNotes();
		}

		public NoteDTO GetNote(Int64 id)
		{
			return _note.GetNote(id);
		}
	}
}

