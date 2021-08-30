using System;
using AppiumClient;
using NUnit.Framework;
using Shouldly;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
    [Binding]
    public class LOG005 : AppiumManager
    {
      private readonly LoginPage _loginPage;
      public LOG005(LoginPage loginPage)
      {
        _loginPage = loginPage;
      }
      
        [Then(@"I should see tooltip")]
        public void ThenIShouldSeeTooltip()
        {
          _loginPage.snackBar.Displayed.ShouldBe(true);
        }
    }
}
