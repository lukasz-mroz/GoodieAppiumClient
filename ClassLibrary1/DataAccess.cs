using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ClassLibrary1;

namespace DbConnect
{
  public class DataAccess
  {
    public void DeletePerson(string email)
    {
      using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WarcraftGame"].ConnectionString))
      {
        var sth = connection.Query();
      }
    }
  }
}
