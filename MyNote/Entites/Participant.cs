using System;
namespace MyNote.Entites
{
	public class Participant
	{
		private string Id;
		private string Name;
		private string Email;
		private string Password;
		private string UserName;
		public Participant()
		{
		}

		public string GetId() { return Id; }

        public void SetId(string id) { Id = id; }

        public string GetName() { return Name; }

        public void SetName(string name) { Name = name; }

        public string GetEmail() { return Email; }

        public void SetEmail(string email) { Email = email; }

        public string GetPassword() { return Password; }

        public void SetPassword(string password) { Password = password; }

        public string GetUserName() { return UserName; }

        public void SetUserName(string userName) { UserName = userName; }
    }
}

