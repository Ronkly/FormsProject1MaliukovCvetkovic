namespace FormsProject1MaliukovCvetkovic.Classes
{
    public class User
    {
        private string _name;
        private string _username;
        private string _password;
        private readonly string _id;
        
        // I need to be able to read the ID publicly
        public string Id => _id; 

        public User(string name, string username, string password)
        {
            Username = username;
            Password = password;
            _id = GenerateId();
        }
        public string Name
        { 
            get => _name;
            set => _name = !string.IsNullOrEmpty(value) ? value : "Unkown name";
        }
        public string Username
        {
            get => _username;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _username = value;
                }
                else
                {
                    _username = "Unknown user";
                }
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 6)
                {
                    _password = value;
                }
                else
                {
                    _password = "default123";
                }
            }
        }
        
        // I want to update my profile data
        public void UpdateProfile(string newName, string newUsername, string newPassword)
        {
            Name = newName;
            Username = newUsername;
            Password = newPassword;
        }

        private string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
    }

    public class SimpleUser : User
    {
        public SimpleUser(string name, string username, string password) : base(name, username, password)
        {
        }

        public void DeleteAccount()
        {
            // I'll add logic to delete the account and all tasks here
        }
    }

    public class AdminUser : User
    {
        public AdminUser(string name, string username, string password) : base(name, username, password)
        {
        }
    }
}
