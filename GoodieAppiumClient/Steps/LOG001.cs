using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class LOG001
  {
    private readonly WelcomeScreenPage _welcomeScreen;
    private readonly LoginPage _loginPage;
    private readonly PermissionLocalizationPage _permissionLocalizationPage;

    public LOG001(WelcomeScreenPage welcomeScreen, LoginPage loginPage, PermissionLocalizationPage permissionLocalizationPage)
    {
      _welcomeScreen = welcomeScreen;
      _loginPage = loginPage;
      _permissionLocalizationPage = permissionLocalizationPage;
    }


    [Given(@"I click login")]
    public void GivenIClickLogin()
    {
      Thread.Sleep(3000);
      _welcomeScreen.LoginIn();
    }

    [Given(@"I enter (.*) and (.*)")]
    public void GivenIEnterAnd(string p0, string p1)
    {
      _loginPage.LoginByEmail(p0,p1);
    }

    [When(@"I try to login")]
    public void WhenITryToLogin()
    {
      _loginPage.LoginTap();
    }

    [Then(@"I should see WelcomeScreen")]
    public void ThenIShouldSeeWelcomeScreen()
    {
      Thread.Sleep(4000);
      var visibleButton = _permissionLocalizationPage.skipButton.Displayed;
      Assert.AreEqual(true, visibleButton);
    }
  }
}
