using System;
using AppiumClient;
using GoodieAppiumClient.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class LOG002 : AppiumManager
  {
    private readonly WelcomeScreenPage _welcomeScreen;
    private readonly LoginPage _loginPage;
    private readonly PermissionLocalizationPage _permissionLocalizationPage;

    public LOG002(WelcomeScreenPage welcomeScreen, LoginPage loginPage, PermissionLocalizationPage permissionLocalizationPage)
    {
      _welcomeScreen = welcomeScreen;
      _loginPage = loginPage;
      _permissionLocalizationPage = permissionLocalizationPage;
    }

    [Given(@"I click login on Welcome Screen")]
    public void GivenIClickLoginOnWelcomeScreen()
    {
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
      _welcomeScreen.LoginIn();
    }

    [Given(@"I enter on google account on LoginPage")]
    public void GivenIEnterOnGoogleAccountOnLoginPage()
    {
      _loginPage.Login(LoginTypesEnum.LoginByGoogle);
    }

    [When(@"I try to login using Google Account")]
    public void WhenITryToLoginUsingGoogleAccount()
    {
      _loginPage.ChooseRandomAccount();
    }

    [Then(@"I should see next screen")]
    public void ThenIShouldSeeNextScreen()
    {
      Assert.AreEqual(true, _permissionLocalizationPage.textBestOffers.Displayed);
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
    }
  }
}
