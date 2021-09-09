using System;
using AppiumClient;
using GoodieAppiumClient.Pages;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class LOG003 : AppiumManager
  {
    private readonly LoginPage _loginPage;

    public LOG003(LoginPage loginPage)
    {
      _loginPage = loginPage;
    }

    [Given(@"I click Zaloguj się z Facebook")]
    public void GivenIClickZalogujSieZFacebook()
    {
      _loginPage.Login(ProviderEnum.Facebook);
    }
  }
}
