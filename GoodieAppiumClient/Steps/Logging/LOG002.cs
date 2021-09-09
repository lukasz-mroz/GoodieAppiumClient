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

    public LOG002(WelcomeScreenPage welcomeScreen, LoginPage loginPage, PermissionLocalizationPage permissionLocalizationPage, ScenarioContext scenarioContext)
    {
      _welcomeScreen = welcomeScreen ?? throw new ArgumentNullException(nameof(welcomeScreen));
      _loginPage = loginPage ?? throw new ArgumentNullException(nameof(loginPage));
      _permissionLocalizationPage = permissionLocalizationPage ?? throw new ArgumentNullException(nameof(permissionLocalizationPage));
    }


    [Given(@"I enter on google account on LoginPage")]
    public void GivenIEnterOnGoogleAccountOnLoginPage()
    {
      _loginPage.Login(ProviderEnum.Google);
    }

    [When(@"I try to login using Google Account")]
    public void WhenITryToLoginUsingGoogleAccount()
    {
      _loginPage.ChooseRandomAccount();
    }
  }
}
