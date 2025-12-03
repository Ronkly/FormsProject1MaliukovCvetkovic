namespace FormsProject1MaliukovCvetkovic
{
    public class User
    {
        private string _username;
        private string _password;
        private readonly string _id;
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            _id = GenerateId();
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
                    // Handle invalid username case
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
                    // Handle invalid password case
                    _password = "default123";
                }
            }
        }

        private string GenerateId()
        {
            return System.Guid.NewGuid().ToString();
        }
    }

    public class SimpleUser : User
    {
        public SimpleUser(string username, string password) : base(username, password)
        {
        }

        public void DeleteAccount()
        {
            // Logic to delete the account
        }
    }



    public class AdminUser : User
    {
        public AdminUser(string username, string password) : base(username, password)
        {
        }
    }
}
