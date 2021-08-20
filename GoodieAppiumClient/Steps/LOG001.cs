using System;
using System.Threading;
using AppiumClient;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class LOG001 : AppiumManager
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


    [Given(@"I click login on WelcomeScreen")]
    public void GivenIClickLogin()
    {
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
      _welcomeScreen.LoginIn();
    }

    [Given(@"I enter on LoginPage (.*) and (.*)")]
    public void GivenIEnterAnd(string p0, string p1)
    {
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
      _loginPage.LoginByEmail(p0,p1);

    }

    [When(@"I try to login on LoginPage")]
    public void WhenITryToLogin()
    {
      _loginPage.Login(3);
    }

    [Then(@"I should see PermissionLocalizationPage")]
    public void ThenIShouldSeeWelcomeScreen()
    {
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
      var visibleButton = _permissionLocalizationPage.skipButton.Displayed;
      Assert.AreEqual(true, visibleButton);
    }
  }
}
