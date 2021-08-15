using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Steps
{
  [Binding]
  public sealed class AppiumTest
  {

    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;
    private readonly WelcomeScreenPage _welcomeScreenPage;
    private readonly LoginPage _loginPage;
    private readonly PermissionLocalizationPage _permissionLocalizationPage;

    public AppiumTest(ScenarioContext scenarioContext, WelcomeScreenPage welcomeScreenPage, LoginPage loginPage)
    {
      _scenarioContext = scenarioContext;
      _welcomeScreenPage = welcomeScreenPage;
      _loginPage = loginPage;
    }

    [Given(@"I enter email and password")]
    public void GivenIEnterEmailAndPassword()
    {
      _welcomeScreenPage.LoginIn();
      _loginPage.LoginByEmail("all@moakt.cc", "123456");
    }


  }
}
