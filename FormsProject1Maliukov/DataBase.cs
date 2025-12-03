using Newtonsoft.Json;

namespace FormsProject1MaliukovCvetkovic
{
    public static class DataBase
    {
        public static Dictionary<int, SimpleUser> simples = [];

        //statican objekat koji mozemo svuda da koristimo i da proveravamo
        public static AdminUser admin = new("admin", "admin123");

        private static readonly string fajl = "radnici.json";

        static DataBase()
        {
            if (File.Exists(fajl))
            {
                Ucitaj();
            }
            else
            {
                simples.Clear();
                Sacuvaj();
            }
        }

        public static void Sacuvaj()
        {
            string json = JsonConvert.SerializeObject(simples, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fajl, json);
        }
        public static void Ucitaj()
        {
            if (!File.Exists(fajl)) { return; }
            string json = File.ReadAllText(fajl);
            simples = JsonConvert.DeserializeObject<Dictionary<int, SimpleUser>>(json);
        }
    }
}
