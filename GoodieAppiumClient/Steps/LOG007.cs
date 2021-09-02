using System;
using AppiumClient;
using GoodieAppiumClient.Pages;
using OpenQA.Selenium.Appium.MultiTouch;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class LoginSteps : AppiumManager
  {
    private readonly PermissionLocalizationPage _permissionLocalizationPage;
    private readonly MainPage _mainPage;
    private readonly ProfilePage _profilePage;

    public LoginSteps(PermissionLocalizationPage permissionLocalizationPage, MainPage mainPage, ProfilePage profilePage)
    {
      _permissionLocalizationPage = permissionLocalizationPage;
      _mainPage = mainPage;
      _profilePage = profilePage;
    }

    [When(@"I skip permissionLocalizationPage")]
    public void WhenISkipPermissionLocalizationPage()
    {
      _permissionLocalizationPage.skipButton.Click();
    }

    [When(@"I go to Profile")]
    public void WhenIGoToProfile()
    {
      _mainPage.Profile.Click();
    }

    [When(@"I scroll down until the end of the screen")]
    public void WhenIScrollDownUntilTheEndOfTheScreen()
    {
      TouchAction action = new TouchAction(Driver);
      action.Press(378, 1909);
      action.MoveTo(338, 177);
      action.Release();
      action.Perform();
      action.Press(600, 1900);
      action.MoveTo(600, 1500);
      action.Release();
      action.Perform();
    }

    [When(@"I click log out")]
    public void WhenIClickLogOut()
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
