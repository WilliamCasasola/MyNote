using System;
using Microsoft.EntityFrameworkCore;
using MyNote.DBContext;
using MyNote.Entites;

namespace MyNote.Data
{
	public class NoteData
	{
		public NoteData()
		{
			using(var dbContext = new MyNoteContext())
			{
				dbContext.Database.EnsureCreated();
				if (!dbContext.GetNotes().Any())
				{
					dbContext.GetNotes().Add(
						new Note(1, "Texts", true));
					dbContext.SaveChanges();
				}
			}
		}

		public List<Note> GetNotes()
		{
			using(var dbContext = new MyNoteContext())
			{
				var t = dbContext.GetNotes().ToList();
                return t;
            }
			
		}
	}
}

