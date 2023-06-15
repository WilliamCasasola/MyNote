using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MyNote.Entites
{
	[Table("Table")]
	public class Note
	{
        private int Id;
        private String Text;
        private bool IsGeneral;

        public Note()
		{
		}

        public int GetId() { return Id; }
        public void SetId(int id) { Id = id; }

        public bool GetIsGeneral() { return IsGeneral; }
        public void SetIsGeneral(bool isGeneral) { IsGeneral = isGeneral; }
        public string GetText() { return Text; }
        public void SetText(string text) { Text = text; }
    }
}

