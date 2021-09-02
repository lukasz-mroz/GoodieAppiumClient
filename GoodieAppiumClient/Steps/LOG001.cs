using System;
using System.Threading;
using AppiumClient;
using GoodieAppiumClient.Pages;
using NUnit.Framework;
using Shouldly;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class LOG001 : AppiumManager
  {
    private readonly WelcomeScreenPage _welcomeScreen;
    private readonly LoginPage _loginPage;
    private readonly PermissionLocalizationPage _permissionLocalizationPage;
    private readonly ScenarioContext _scenarioContext;

    public LOG001(WelcomeScreenPage welcomeScreen, LoginPage loginPage, PermissionLocalizationPage permissionLocalizationPage, FeatureContext featureContext, ScenarioContext scenarioContext)
    {
      _welcomeScreen = welcomeScreen ?? throw new ArgumentNullException(nameof(welcomeScreen));
      _loginPage = loginPage ?? throw new ArgumentNullException(nameof(loginPage));
      _permissionLocalizationPage = permissionLocalizationPage ?? throw new ArgumentNullException(nameof(permissionLocalizationPage));
      _scenarioContext = scenarioContext ?? throw new ArgumentNullException(nameof(scenarioContext));
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

    [When(@"I try to login on LoginPage screen")]
    public void WhenITryToLogin()
    {
      _loginPage.Login();
    }

    [Then(@"I should see PermissionLocalizationPage")]
    public void ThenIShouldSeeWelcomeScreen()
    {
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
      _permissionLocalizationPage.skipButton.Displayed.ShouldBe(true);
    }
  }
}
