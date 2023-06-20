using System;
using MyNote.Entites;

namespace MyNote.Data.IRepositories
{
	public interface INoteRepository
	{
        List<Note> GetNotes();

    }
}

