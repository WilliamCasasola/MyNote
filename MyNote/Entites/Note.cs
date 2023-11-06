using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
	[Table("Note")]
	public class Note
	{
        public Int64 Id { get; set; }
        public String Text { get; set; }
        public bool IsGeneral { get; set; }

        public Int64 GetId() { return Id; }
        public void SetId(Int64 id) { Id = id; }

        public bool GetIsGeneral() { return IsGeneral; }
        public void SetIsGeneral(bool isGeneral) { IsGeneral = isGeneral; }
        public string GetText() { return Text; }
        public void SetText(string text) { Text = text; }
    }
}

