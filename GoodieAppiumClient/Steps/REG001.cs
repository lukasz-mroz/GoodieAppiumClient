using System;
using System.Threading;
using AppiumClient;
using GoodieAppiumClient.Pages;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class REG001 : AppiumManager
  {
    private readonly WelcomeScreenPage _welcomeScreenPage;
    private readonly RegistrationPage _registrationPage;
    private readonly BrandListPage _brandListPage;

    public REG001(RegistrationPage registrationPage, WelcomeScreenPage welcomeScreenPage)
    {
      _registrationPage = registrationPage;
      _welcomeScreenPage = welcomeScreenPage;
    }


    [Given(@"I click registration on WelcomeScreen")]
    public void GivenIClickRegistrationOnWelcomeScreen()
    {
      Thread.Sleep(3000);
      _welcomeScreenPage.Registrate();
    }

    [Given(@"I enter registration data User and Password on RegistrationPage")]
    public void GivenIEnterRegistrationDataUserAndPasswordOnRegistrationPage()
    {
      Thread.Sleep(3000);
      var randomValue = new Random();
      var randomInt = randomValue.Next(10000000);
      
      _registrationPage.SumbitRegistrationData($"all{randomInt}@moakt.cc", "123456", $"{randomInt}");
    }

    [Given(@"I choose Gender on RegistrationPage")]
    public void GivenIChooseGenderOnRegistrationPage()
    {
      _registrationPage.Login();
    }

    [When(@"I click register on RegistrationPage")]
    public void WhenIClickRegisterOnRegistrationPage()
    {
      
    }

    [Then(@"I should see PermissionLocalizationPage screen")]
    public void ThenIShouldSeePermissionLocalizationPageScreen()
    {
      Thread.Sleep(60000);
    }
  }
}
