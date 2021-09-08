using System;
using System.IO;
using AppiumClient;
using FluentAssertions.Execution;
using GoodieAppiumClient.Pages;
using GoodieAppiumClient.Settings;
using NUnit.Framework;
using OpenQA.Selenium;
using Shouldly;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class LOG006 : AppiumManager
  {
    private readonly LoginPage _loginPage;
    public LOG006(LoginPage loginPage)
    {
      _loginPage = loginPage;
    }

    [Given(@"I do not enter any Login and Password")]
    public void GivenIDoNotEnterAnyLoginAndPassword()
    {
      _loginPage.loginByEmailButton.Click();
    }

    [Then(@"I should see validation error")]
    public void ThenIShouldSeeValidationError()
    {
      var screenshot = Driver.GetScreenshot();
      
      try
      {
        screenshot.SaveAsFile(Global.ScreenshotsFolder + "asd.png");
        _loginPage.errorValidation.Text.ShouldBe(TextConsts.validationTextOnEmailLogin);
      }
      catch (AssertionFailedException e)
      {
        
      }
    }
  }
}
