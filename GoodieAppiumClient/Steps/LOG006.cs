using System;
using AppiumClient;
using GoodieAppiumClient.Pages;
using NUnit.Framework;
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
      _loginPage.errorValidation.Text.ShouldBe(TextConsts.validationTextOnEmailLogin);
    }
  }
}
