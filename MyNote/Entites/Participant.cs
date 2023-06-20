using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
	public class Participant
	{
		[Key]
		[Column("id")]
		private string Id;
		[Column("name")]
		private string Name;
		[Column("email")]
		private string Email;
		[Column("password")]
		private string Password;
		[Column("username")]
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

