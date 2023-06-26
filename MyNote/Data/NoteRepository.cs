using MyNote.Data.IRepositories;
using MyNote.DBContext;
using MyNote.Entites;

namespace MyNote.Data
{
	public class NoteRepository : INoteRepository
	{
		private readonly MyNoteContext _myNote;
		public NoteRepository(MyNoteContext myNote)	
		{
			_myNote = myNote;
			
				//_myNote.Database.EnsureCreated();
				if (!_myNote.GetNotes().Any())
				{
					_myNote.GetNotes().Add(
							new Note(1, "Texts", true));
					_myNote.SaveChanges();
				}
		}

		public List<Note> GetNotes()
		{			
				var t = _myNote.GetNotes().ToList();
                return t;            			
		}


        public List<Note> GetNotesBad()
        {
			string longQuery = @"
								SELECT *,
									CASE text
										WHEN 'test' THEN 1
										ELSE 10
									END,
									CASE text
										WHEN 'Text' THEN 2
										ELSE 20
									END,
									CASE text
										WHEN 'Texts' THEN 3
										ELSE 30
									END,
									CASE text
										WHEN 'Tex' THEN 4
										ELSE 30
									END,
									CASE text
										WHEN 'exts' THEN 5
										ELSE 30
									END,
									CASE text
										WHEN 'mm' THEN 6
										ELSE 34
									END,
									CASE text
										WHEN 'exts' THEN 5
										ELSE 30
									END,
									CASE text
										WHEN 'T' THEN 6
										ELSE 40
									END
								FROM note n
								INNER JOIN meetingnote mn ON n.id = mn.idNote
								INNER JOIN participant p ON mn.idParticipant = p.id
								INNER JOIN meeting m ON mn.idnote = m.id 
								WHERE (n.id = 1 AND n.id NOT IN (22)
								OR n.isGeneral = 1 AND n.id = 100)
								AND mn.id = 1 AND m.id = 2 AND p.id = 3 AND
								p.username <> 'test'
						";
            var t = _myNote.GetNotes().ToList();
            return t;
        }
    }
}

