using System;
using MyNote.Data;
using MyNote.Data.IRepositories;
using MyNote.DBContext;
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
	}
}

