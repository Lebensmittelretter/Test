using Microsoft.Extensions.Configuration;

namespace WebApp
{
    public class AppConfig
    {
        public string? ConnectionString { get; }
        public AppConfig(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("defaultConnection");
        }
    }
}