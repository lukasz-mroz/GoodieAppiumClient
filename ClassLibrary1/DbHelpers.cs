using System;
using System.Configuration;

namespace ClassLibrary1
{
  public static class DbHelpers
  {
    public static string CnnVal(string name)
    {
      return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
  }
}
