namespace FormsProject1MaliukovCvetkovic.Classes
{
    internal class Helper
    {
        public static bool IsValidUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username) && username.Length >= 3 && username.Length <= 20;
        }
        public static bool IsValidPassword(string password)
        {
            bool result = password.Any(char.IsLetter) && password.Any(char.IsDigit) && password.Length >= 6;
            return result;
        }
    }
}
