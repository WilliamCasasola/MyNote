namespace MyNote.DTOs
{
	public class MeetingDTO
	{
        private Int64 _id;
        private DateTime _date;
        private string _name;
        private bool _t;

        public Int64 GetId() { return _id; }
        public void SetId(Int64 id) { _id = id; }

        public DateTime GetDate() { return _date; }
        public void SetDate(DateTime date) { _date = date; }
        public string GetName() { return _name; }
        public void SetName(string name) { _name = name; }
        public bool GetT() { return _t; }
        public void SetT(bool t) { _t = t; } 
    }
}

