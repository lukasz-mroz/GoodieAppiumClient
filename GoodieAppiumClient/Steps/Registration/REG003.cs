using System;
using System.Threading;
using GoodieAppiumClient.Pages;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Steps.Registration
{
  [Binding]
  public class REG003
  {
    private readonly RegistrationPage _registrationPage;
    private readonly LoginPage _loginPage;

    public REG003(RegistrationPage registrationPage, LoginPage loginPage)
    {
      _registrationPage = registrationPage;
      _loginPage = loginPage;
    }

    [Given(@"I click on Zarejestruj się z Google")]
    public void GivenIClickOnZarejestrujSieZGoogle()
    {
      Thread.Sleep(3000);
      _registrationPage.Registrate(ProviderEnum.Google);
    }

    [When(@"I try to register using Google Account")]
    public void WhenITryToRegisterUsingGoogleAccount()
    {
      _loginPage.ChooseGoogleAccount();
    }

  }
}
