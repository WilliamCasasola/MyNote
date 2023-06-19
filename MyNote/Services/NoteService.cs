using System;
using MyNote.Data;
using MyNote.Entites;

namespace MyNote.Services
{
	public class NoteService
	{
		private NoteData _noteData;
		public NoteService()
		{
			_noteData = new NoteData();
		}

		public List<Note> GetNotesData()
		{
			return _noteData.GetNotes();
		}
	}
}

