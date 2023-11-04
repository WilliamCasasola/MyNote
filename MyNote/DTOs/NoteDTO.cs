using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.DTOs
{
	public class NoteDTO
	{
        public Int64 _id;
        public String _text;
        public bool _isGeneral;


        public Int64 GetId() { return _id; }
        public void SetId(Int64 id) { _id = id; }
        public bool GetIsGeneral() { return _isGeneral; }
        public void SetIsGeneral(bool isGeneral) { _isGeneral = isGeneral; }
        public string GetText() { return _text; }
        public void SetText(string text) { _text = text; }
    }
}

