using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class LOG001Steps
  {
    private readonly WelcomeScreenPage _welcomeScreen;
    private readonly LoginPage _loginPage;
    private readonly PermissionLocalizationPage _permissionLocalizationPage;

    public LOG001Steps(WelcomeScreenPage welcomeScreen, LoginPage loginPage, PermissionLocalizationPage permissionLocalizationPage)
    {
      _welcomeScreen = welcomeScreen;
      _loginPage = loginPage;
      _permissionLocalizationPage = permissionLocalizationPage;
    }

    [Given(@"I click login \(under buttons\)")]
    public void GivenIClickLoginUnderButtons()
    {
      Thread.Sleep(3000);
      _welcomeScreen.LoginIn();
    }

    [Given(@"I enter own data \(email and password\)")]
    public void GivenIEnterOwnDataEmailAndPassword()
    {
      Thread.Sleep(3000);
      _loginPage.LoginByEmail("all@moakt.cc", "123456");
    }

    [When(@"I press try to log in")]
    public void WhenIPressTryToLogIn()
    {
      _loginPage.LoginTap();
    }

    [Then(@"Welcome screen should be visible")]
    public void ThenWelcomeScreenShouldBeVisible()
    {
      Thread.Sleep(4000);
      var visibleButton = _permissionLocalizationPage.skipButton.Displayed;
      Assert.AreEqual(true, visibleButton);
    }
  }
}
