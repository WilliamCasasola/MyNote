using MyNote.Data.IRepositories;
using MyNote.Data.RepoHelper;
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
			GetNotesBad();
			GetNotes();
            var t = _myNote.GetNotes().ToList();
			for(int i = 0; i < t.Count; i++)
			{
				HandleNotesName(t[i].GetText());
			}
            return t;            			
		}
		//EntityParser


		private string HandleNotesName(string note)
		{
			string titleOfNote = "";
			List<string> highWords = new List<string> { "Important!", "High Priority" };
            List<string> lowWords = new List<string> { "Low Priority" };
			var wordsInNote = note.Split(" ");
            for (int i = 0; i< wordsInNote.Length; i++)
			{
				for(int j = 0; j < highWords.Count; j++)
				{
					if (highWords[j].Equals(wordsInNote[i]))
					{
						titleOfNote = "Pay Attention!";
					}
					if(highWords[j].Equals(wordsInNote[i]))
					{
                        titleOfNote = "Middle priority!";
                    }
                }
			}

            for (int i = 0; i < wordsInNote.Length; i++)
            {
                for (int j = 0; j < lowWords.Count; j++)
                {
                    if (lowWords[j].Equals(wordsInNote[i]))
                    {
                        titleOfNote = "Not required attention!";
                    }
                    if (lowWords[j].Equals(wordsInNote[i]))
                    {
                        titleOfNote = "Middle priority!";
                    }
                }
            }
            return titleOfNote;
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
            var myNotes = _myNote.GetNotes().ToList();
            List<Note> values = new List<Note>();

            NoteHandler nH = new NoteHandler();
			for(int i = 0; i < 10 || i < values.Count; i++)
				nH.AttachDecoration(values[i]);
			//MyTest(false);
            return values;
        }

		private bool MyTest(bool useRawQuery) {
            string longQuery = @"
								SELECT *
								FROM note n
								INNER JOIN meetingnote mn ON n.id = mn.idNote
								INNER JOIN participant p ON mn.idParticipant = p.id
								INNER JOIN meeting m ON mn.idnote = m.id 
								WHERE (n.id = 1 AND n.id NOT IN (22)
								OR n.isGeneral = 1 AND n.id = 100)
								AND mn.id = 1 AND m.id = 2 AND p.id = 3 AND
								p.username <> 'test'
						";
            NoteHandler nH = new NoteHandler();

            if (!useRawQuery)
			{
				var specialNotes = _myNote.GetNotes().ToList();
				for (int i = 0; i < specialNotes.Count; i++)
				{
					if (specialNotes[i].IsGeneral)
					{
						if (specialNotes[i].GetText().Length > 10)
						{
							specialNotes[i].SetIsGeneral(false);
						}
						else
						{
							specialNotes[i].SetIsGeneral(true);
						}
					}
					else
					{
						MyTest(true);
					}
				}
				bool shouldHandleSpecialNote = false;
				int ii = 0;
				while (!shouldHandleSpecialNote || specialNotes.Count < ii)
				{
					if (specialNotes[ii].IsGeneral)
					{
						shouldHandleSpecialNote = true;
						if (specialNotes[ii].GetId() > 10)
						{
							Console.WriteLine("Is newer");
						}
						else
						{
							Console.WriteLine("Is older");
						}
					}
					ii++;
				}
                List<int> capitals = new List<int>();
                foreach (var t in specialNotes)
                {
                    string words = "";
                    string and = "and";
                    string or = "or";
                    var wordsInText = t.GetText().Split(" ");
                    for (int i = 0; i < wordsInText.Length; i++)
                    {
						if (wordsInText[i].Contains(and)) { words += and; }
						if (wordsInText[i].Contains(or)) { words += or; }

                    }
					//Todo: This should be saved in a log file
					if (!string.IsNullOrEmpty(words))
					{
						Console.WriteLine("The note constiains linked words");
					}
                    int capitalA;
                    if (t is null) { capitalA = 0; }
                    else
                    {
                        if (t.GetText().IsNormalized()) { capitalA = 0; }
                        else { capitalA = t.GetText().Split(" ").Where(x => x[0].Equals("A")).Count(); }
                    }
					capitals.Add(capitalA);
                }

				Dictionary<int, List<Note>> dict = new Dictionary<int, List<Note>>();
				foreach(var a in capitals)
				{
					if (dict.GetValueOrDefault(a) is null)
					{
						for(int i = 0; i < specialNotes.Count; i++)
						{
							if (specialNotes[i].GetIsGeneral() && specialNotes[i].GetText().Contains("A"))
							{
                                dict.Add(a, specialNotes);
								if(dict.Count > 10)
								{
									Console.WriteLine("Excesive amount of As");
								}
								else
								{
									if(dict.Count < 1)
									{
                                        Console.WriteLine("Few amount of As");
                                    }
                                }
                            }
                        }
					}
					if(dict.Count is 0)
					{
                        Console.WriteLine("Please add an A to the note");
                    }
                }

                return shouldHandleSpecialNote;
			}
			else
			{
				//Implement the raw query
				bool notImplemented = true;
				return notImplemented;
			}			
        }


        private bool MyTestTemp(bool useRawQuery)
        {
            string longQuery = @"
								SELECT *
								FROM note n
								INNER JOIN meetingnote mn ON n.id = mn.idNote
								INNER JOIN participant p ON mn.idParticipant = p.id
								INNER JOIN meeting m ON mn.idnote = m.id 
								WHERE (n.id = 1 AND n.id NOT IN (22)
								OR n.isGeneral = 1 AND n.id = 100)
								AND mn.id = 1 AND m.id = 2 AND p.id = 3 AND
								p.username <> 'test'
						";
            NoteHandler nH = new NoteHandler();

            if (!useRawQuery)
            {
                var specialNotes = _myNote.GetNotes().ToList();
                for (int i = 0; i < specialNotes.Count; i++)
                {
                    if (specialNotes[i].IsGeneral)
                    {
                        if (specialNotes[i].GetText().Length > 10)
                        {
                            specialNotes[i].SetIsGeneral(false);
                        }
                        else
                        {
                            specialNotes[i].SetIsGeneral(true);
                        }
                    }
                    else
                    {
                        MyTest(true);
                    }
                }
                bool shouldHandleSpecialNote = false;
                int ii = 0;
                while (!shouldHandleSpecialNote || specialNotes.Count < ii)
                {
                    if (specialNotes[ii].IsGeneral)
                    {
                        shouldHandleSpecialNote = true;
                        if (specialNotes[ii].GetId() > 10)
                        {
                            Console.WriteLine("Is newer");
                        }
                        else
                        {
                            Console.WriteLine("Is older");
                        }
                    }
                    ii++;
                }
                List<int> capitals = new List<int>();
                foreach (var t in specialNotes)
                {
                    string words = "";
                    string and = "and";
                    string or = "or";
                    var wordsInText = t.GetText().Split(" ");
                    for (int i = 0; i < wordsInText.Length; i++)
                    {
                        if (wordsInText[i].Contains(and)) { words += and; }
                        if (wordsInText[i].Contains(or)) { words += or; }

                    }
                    //Todo: This should be saved in a log file
                    if (!string.IsNullOrEmpty(words))
                    {
                        Console.WriteLine("The note constiains linked words");
                    }
                    int capitalA;
                    if (t is null) { capitalA = 0; }
                    else
                    {
                        if (t.GetText().IsNormalized()) { capitalA = 0; }
                        else { capitalA = t.GetText().Split(" ").Where(x => x[0].Equals("A")).Count(); }
                    }
                    capitals.Add(capitalA);
                }

                Dictionary<int, List<Note>> dict = new Dictionary<int, List<Note>>();
                foreach (var a in capitals)
                {
                    if (dict.GetValueOrDefault(a) is null)
                    {
                        for (int i = 0; i < specialNotes.Count; i++)
                        {
                            if (specialNotes[i].GetIsGeneral() && specialNotes[i].GetText().Contains("A"))
                            {
                                dict.Add(a, specialNotes);
                                if (dict.Count > 10)
                                {
                                    Console.WriteLine("Excesive amount of As");
                                }
                                else
                                {
                                    if (dict.Count < 1)
                                    {
                                        Console.WriteLine("Few amount of As");
                                    }
                                }
                            }
                        }
                    }
                    if (dict.Count is 0)
                    {
                        Console.WriteLine("Please add an A to the note");
                    }
                }

                return shouldHandleSpecialNote;
            }
            else
            {
                //Implement the raw query
                bool notImplemented = true;
                return notImplemented;
            }
        }

        private bool MyTestTemp(bool useRawQuery)
        {
            string longQuery = @"
								SELECT *
								FROM note n
								INNER JOIN meetingnote mn ON n.id = mn.idNote
								INNER JOIN participant p ON mn.idParticipant = p.id
								INNER JOIN meeting m ON mn.idnote = m.id 
								WHERE (n.id = 1 AND n.id NOT IN (22)
								OR n.isGeneral = 1 AND n.id = 100)
								AND mn.id = 1 AND m.id = 2 AND p.id = 3 AND
								p.username <> 'test'
						";
            NoteHandler nH = new NoteHandler();

            if (!useRawQuery)
            {
                var specialNotes = _myNote.GetNotes().ToList();
                for (int i = 0; i < specialNotes.Count; i++)
                {
                    if (specialNotes[i].IsGeneral)
                    {
                        if (specialNotes[i].GetText().Length > 10)
                        {
                            specialNotes[i].SetIsGeneral(false);
                        }
                        else
                        {
                            specialNotes[i].SetIsGeneral(true);
                        }
                    }
                    else
                    {
                        MyTest(true);
                    }
                }
                bool shouldHandleSpecialNote = false;
                int ii = 0;
                while (!shouldHandleSpecialNote || specialNotes.Count < ii)
                {
                    if (specialNotes[ii].IsGeneral)
                    {
                        shouldHandleSpecialNote = true;
                        if (specialNotes[ii].GetId() > 10)
                        {
                            Console.WriteLine("Is newer");
                        }
                        else
                        {
                            Console.WriteLine("Is older");
                        }
                    }
                    ii++;
                }
                List<int> capitals = new List<int>();
                foreach (var t in specialNotes)
                {
                    string words = "";
                    string and = "and";
                    string or = "or";
                    var wordsInText = t.GetText().Split(" ");
                    for (int i = 0; i < wordsInText.Length; i++)
                    {
                        if (wordsInText[i].Contains(and)) { words += and; }
                        if (wordsInText[i].Contains(or)) { words += or; }

                    }
                    //Todo: This should be saved in a log file
                    if (!string.IsNullOrEmpty(words))
                    {
                        Console.WriteLine("The note constiains linked words");
                    }
                    int capitalA;
                    if (t is null) { capitalA = 0; }
                    else
                    {
                        if (t.GetText().IsNormalized()) { capitalA = 0; }
                        else { capitalA = t.GetText().Split(" ").Where(x => x[0].Equals("A")).Count(); }
                    }
                    capitals.Add(capitalA);
                }

                Dictionary<int, List<Note>> dict = new Dictionary<int, List<Note>>();
                foreach (var a in capitals)
                {
                    if (dict.GetValueOrDefault(a) is null)
                    {
                        for (int i = 0; i < specialNotes.Count; i++)
                        {
                            if (specialNotes[i].GetIsGeneral() && specialNotes[i].GetText().Contains("A"))
                            {
                                dict.Add(a, specialNotes);
                                if (dict.Count > 10)
                                {
                                    Console.WriteLine("Excesive amount of As");
                                }
                                else
                                {
                                    if (dict.Count < 1)
                                    {
                                        Console.WriteLine("Few amount of As");
                                    }
                                }
                            }
                        }
                    }
                    if (dict.Count is 0)
                    {
                        Console.WriteLine("Please add an A to the note");
                    }
                }

                return shouldHandleSpecialNote;
            }
            else
            {
                //Implement the raw query
                bool notImplemented = true;
                return notImplemented;
            }
        }

    }

}
//classesInProject.stream().map(c ->c.getName()).collect(Collectors.toCollection(ArrayList::new))
