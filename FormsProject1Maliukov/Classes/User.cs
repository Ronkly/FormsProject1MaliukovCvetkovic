using Newtonsoft.Json;

namespace FormsProject1MaliukovCvetkovic.Classes
{
    public class User
    {
        private string _name;
        private string _username;
        private string _password;

        public string Id { get; set; }

        public User(string name, string username, string password)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Username = username;
            Password = password;
        }
        [JsonConstructor]
        public User(string name, string username, string password, string id)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public string Name
        {
            get => _name;
            set => _name = !string.IsNullOrEmpty(value) ? value : "Unknown name";
        }
        public string Username
        {
            get => _username;
            set => _username = !string.IsNullOrWhiteSpace(value) ? value : "Unknown user";
        }
        public string Password
        {
            get => _password; set => _password = !string.IsNullOrWhiteSpace(value) && value.Length >= 6 ? value : "default123";
        }

        public void UpdateProfile(string newName, string newUsername)
        {
            Name = newName;
            Username = newUsername;
        }

        public void UpdatePassword(string newPassword)
        {
            Password = newPassword;
        }
    }

    public class SimpleUser : User
    {
        [JsonConstructor]
        public SimpleUser(string name, string username, string password, string id)
            : base(name, username, password, id) { }

        public SimpleUser(string name, string username, string password)
            : base(name, username, password) { }
    }

    public class AdminUser : User
    {
        [JsonConstructor]
        public AdminUser(string name, string username, string password, string id)
            : base(name, username, password, id) { }

        public AdminUser(string name, string username, string password)
            : base(name, username, password) { }
    }
}