using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
	[Table("Note")]
	public class Note
	{
        [Key]
        [Column("id")]
        public int Id;
        [Column("text")]
        public String Text;
        [Column("isGeneral")]
        public bool IsGeneral;

        public Note()
		{
		}

        public Note(int id, string text, bool isGeneral)
        {
            Id = id;
            Text = text;
            IsGeneral = isGeneral;
        }

        public int GetId() { return Id; }
        public void SetId(int id) { Id = id; }

        public bool GetIsGeneral() { return IsGeneral; }
        public void SetIsGeneral(bool isGeneral) { IsGeneral = isGeneral; }
        public string GetText() { return Text; }
        public void SetText(string text) { Text = text; }
    }
}

