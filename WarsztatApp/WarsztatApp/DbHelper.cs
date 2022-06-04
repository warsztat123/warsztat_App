using System.Configuration;

namespace WarsztatApp
{
    public class DbHelper
    {
        internal static string GetConnectionString()
        {
            return ConfigurationManager
                .ConnectionStrings["WarsztatApp.Properties.Settings.WarsztatConnectionString"]
                .ConnectionString;
        }
        internal static string GetConnectionString(string login, string password)
        {
            string authData = $"User ID={login};Password={password};";
            return GetConnectionString().Replace("Integrated Security=true", authData);
        }
    }
}
