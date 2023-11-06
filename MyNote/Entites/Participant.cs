using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("Participant")]
    public class Participant
	{
        public string Id { get; set; }        
        public string Name { get; set; }       
        public string Email { get; set; }        
        public string Password { get; set; }        
        public string UserName { get; set; }

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

