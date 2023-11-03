using MyNote.Entites;

namespace MyNote.Data.RepoHelper
{
	public class NoteHandler
	{
		public NoteHandler()
		{
		}

        public Note AttachDecoration(Note note)
		{
			if(note.GetText().Length is 0)
			{
				note.SetText(note.GetId() + " " + note.GetId());
				return note;
			}
			return note;
		}

		public string FindLinkWords(string text)
		{
			string words = "";
			string and = "and";
			string or = "or";
			var wordsInText = text.Split(" ");
			for(int i = 0; i < wordsInText.Length; i++)
			{
				if (wordsInText[i].Contains(and)) { words += and; }
				if (wordsInText[i].Contains(or)) { words += or; }

            }
            return words;
		}
	}
}

