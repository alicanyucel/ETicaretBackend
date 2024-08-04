
using Microsoft.Extensions.Configuration;

namespace ETicaret.Persistance;

static class Configuration
{
    static public string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../ETicaret.API"));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString("SqlServer");

        }
    }
}
