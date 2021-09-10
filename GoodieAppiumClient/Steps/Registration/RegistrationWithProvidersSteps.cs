using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class RegistrationWithProvidersSteps
  {
    [Given(@"I delete an account before I create it\.")]
    public void GivenIDeleteAnAccountBeforeICreateIt_()
    {
      using (IDbConnection db = new SqlConnection(Settings.Global.ConnectionString))
      {
        var query = "update Characters set Name = 'Michal' where Id = 1";
        db.Execute(query);
      }

    }
  }
}
