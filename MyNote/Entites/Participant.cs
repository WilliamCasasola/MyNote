using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
	public class Participant
	{
		[Key]
		[Column("id")]
        public string Id;
		[Column("name")]
        public string Name;
		[Column("email")]
        public string Email;
		[Column("password")]
        public string Password;
		[Column("username")]
        public string UserName;

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

