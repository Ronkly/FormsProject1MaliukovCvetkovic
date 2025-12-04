using Newtonsoft.Json;

namespace FormsProject1MaliukovCvetkovic.Classes
{
    public static class DataBase
    {
        public static List<SimpleUser> simples = [];

        //statican objekat koji mozemo svuda da koristimo i da proveravamo
        public static AdminUser admin = new("karl", "admin", "admin123");

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
            string json = JsonConvert.SerializeObject(simples, Formatting.Indented);
            File.WriteAllText(fajl, json);
        }
        public static void Ucitaj()
        {
            if (!File.Exists(fajl)) { return; }
            string json = File.ReadAllText(fajl);
            simples = JsonConvert.DeserializeObject<List<SimpleUser>>(json);
        }
    }
}
