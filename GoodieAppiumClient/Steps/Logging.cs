using System;
using System.Threading;
using AppiumClient;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
    [Binding]
    public class Logging : AppiumDriver
    {
      private readonly LoginPage _loginPage;
      private readonly WelcomeScreenPage _welcomeScreenPage;
      private readonly PermissionLocalizationPage _permissionLocalizationPage;
      public Logging(WelcomeScreenPage welcomeScreenPage, LoginPage loginPage)
      {
        _welcomeScreenPage = welcomeScreenPage;
        _loginPage = loginPage;
      }

        [Given(@"I enter email and password")]
        public void GivenIEnterEmailAndPassword()
        {
          Thread.Sleep(5000);
          _welcomeScreenPage.LoginIn();
          _loginPage.LoginByEmail("all@moakt.cc","123456");
        }
        
        
        [Then(@"I should see WelcomeScreen")]
        public void ThenIShouldSeeWelcomeScreen()
        {
          Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
          
          var expText = "Najlepsze okazje w Twojej okolicy";
          var actText = _permissionLocalizationPage.textBestOffers.Text;
          Assert.AreEqual(expText, actText);

          _permissionLocalizationPage.SkipButton();
        }
    }
}
