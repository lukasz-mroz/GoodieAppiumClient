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
      action.Press(371, 1690);
      action.MoveTo(359, 463);
      action.Release();
      action.Perform();
      action.Press(531, 858);
      action.MoveTo(564, 122);
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
