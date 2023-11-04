namespace MyNote.Inputs
{
	public class ParticipantDTO
	{
        public string _id;
        public string _name;
        public string _email;
        public string _password;
        public string _userName;


        public string GetId() { return _id; }

        public void SetId(string id) { _id = id; }

        public string GetName() { return _name; }

        public void SetName(string name) { _name = name; }

        public string GetEmail() { return _email; }

        public void SetEmail(string email) { _email = email; }

        public string GetPassword() { return _password; }

        public void SetPassword(string password) { _password = password; }

        public string GetUserName() { return _userName; }

        public void SetUserName(string userName) { _userName = userName; }
    }
}

