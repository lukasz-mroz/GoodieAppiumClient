using System.IO;
using Microsoft.Extensions.Configuration;


namespace AppiumClient
{
  public class ConfigurationProvider
  {
    private readonly IConfiguration _configuration;

    public ConfigurationProvider()
    {
      _configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", false, true)
        .Build();
    }
  }
}