using Newtonsoft.Json;

namespace FormsProject1MaliukovCvetkovic.Classes
{
    public static class DataBase
    {
        public static List<SimpleUser> simples = [];
        public static List<Task> tasks = [];
        public static AdminUser admin = new("Karl", "admin", "admin123");
        
        // This holds the current logged-in user
        public static User? CurrentUser { get; set; }

        private static readonly string usersFile = "radnici.json";
        private static readonly string tasksFile = "tasks.json"; // I need a file for tasks

        static DataBase()
        {
            LoadUsers();
            LoadTasks();
        }

        public static void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(simples, Formatting.Indented);
            File.WriteAllText(usersFile, json);
            string adminJson = JsonConvert.SerializeObject(admin, Formatting.Indented);
            File.WriteAllText("admin.json", adminJson);
        }

        public static void LoadUsers()
        {
            if (File.Exists(usersFile))
            {
                string json = File.ReadAllText(usersFile);
                simples = JsonConvert.DeserializeObject<List<SimpleUser>>(json) ?? [];
            }
            if (File.Exists("admin.json"))
            {
                string adminJson = File.ReadAllText("admin.json");
                admin = JsonConvert.DeserializeObject<AdminUser>(adminJson) ?? admin;
            }
        }

        // I need to save the tasks list
        public static void SaveTasks()
        {
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(tasksFile, json);
        }

        // I need to load the tasks list
        public static void LoadTasks()
        {
            if (File.Exists(tasksFile))
            {
                string json = File.ReadAllText(tasksFile);
                tasks = JsonConvert.DeserializeObject<List<Task>>(json) ?? [];
            }
        }
        
        // Authentication logic
        public static bool Authenticate(string username, string password)
        {
            // Check admin first
            if (admin.Username == username && admin.Password == password)
            {
                CurrentUser = admin;
                return true;
            }

            // Then check simple users
            var user = simples.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                CurrentUser = user;
                return true;
            }
            
            return false;
        }
    }
}
