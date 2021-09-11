using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using GoodieAppiumClient.Settings;
using NUnit.Framework.Internal;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class RegistrationWithProvidersSteps
  {
    [Given(@"I delete an account before I create it\.")]
    public void GivenIDeleteAnAccountBeforeICreateIt_()
    {
      using (IDbConnection db = new SqlConnection(Global.ConnectionString))
      {
        var random = new Random();
        var randomizer = random.Next(100000);

        var query = $"update Characters set Id = polskagoodie@gmail.com and Name = '{randomizer}polskagoodie@gmail.com' where Id = 1";
        db.Execute(query);
      }

    }
  }
}
