using System;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
    [Binding]
    public class Logging
    {
      private readonly LoginPage _loginPage;
      private readonly WelcomeScreenPage _welcomeScreenPage;
      public Logging(WelcomeScreenPage welcomeScreenPage, LoginPage loginPage)
      {
        _welcomeScreenPage = welcomeScreenPage;
        _loginPage = loginPage;
      }

        [Given(@"I enter email and password")]
        public void GivenIEnterEmailAndPassword()
        {
          _welcomeScreenPage.LoginIn();
          _loginPage.LoginByEmail("all@moakt.cc","123456");
        }
        
        [Given(@"I choose Male gender")]
        public void GivenIChooseMaleGender()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see WelcomeScreen")]
        public void ThenIShouldSeeWelcomeScreen()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
