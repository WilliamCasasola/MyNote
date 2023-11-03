using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Helpers
{
	public class LeaderSelector
	{
        private string _id;
        private string _name;
        private string _email;
        private string _userName;
        private Int16 _age;
        private Int16 _experience;

        public LeaderSelector()
		{
		}

        public Int16 GetAge()
        {
            Random rnd = new Random();
            _age = (short)rnd.Next(1, 13);
            return _age;
        }
        public Int16 GetExperience()
        {
            Random rnd = new Random();
            _experience = (short)rnd.Next(1, 25);
            return _experience;
        }
        public string GetId() { return _id; }
        public string GetName() { return _name; }
        public string GetEmail() { return _email; }
        public string GetUserName() { return _userName; }
        public void SetId(string id) { _id = id; }
        public void SetName(string name) { _name = name; }
        public void SetEmail(string email) { _email = email; }
        public void SetUserName(string userName) { _userName = userName; }
    }
}

