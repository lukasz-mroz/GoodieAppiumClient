using System;
using System.Threading;
using AppiumClient;
using GoodieAppiumClient.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
  [Binding]
  public class REG001 : AppiumManager
  {
    private readonly WelcomeScreenPage _welcomeScreenPage;
    private readonly RegistrationPage _registrationPage;
    private readonly BrandListPage _brandListPage;
    private readonly PermissionLocalizationPage _permissionLocalizationPage;

    public REG001(RegistrationPage registrationPage, WelcomeScreenPage welcomeScreenPage, BrandListPage brandListPage, PermissionLocalizationPage permissionLocalizationPage)
    {
      _registrationPage = registrationPage;
      _welcomeScreenPage = welcomeScreenPage;
      _brandListPage = brandListPage;
      _permissionLocalizationPage = permissionLocalizationPage;
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
      _registrationPage.ChooseGender();
    }

    [When(@"I click register on RegistrationPage")]
    public void WhenIClickRegisterOnRegistrationPage()
    {
      _registrationPage.Login();
    }

    [When(@"I select brands and click Next button")]
    public void WhenISelectBrandsAndClickNextButton()
    {
      Thread.Sleep(3000);
      _brandListPage.ClickOnThreeFirstelements();
      _brandListPage.ClickOnButton();
    }


    [Then(@"I should see PermissionLocalizationPage screen")]
    public void ThenIShouldSeePermissionLocalizationPageScreen()
    {
      Thread.Sleep(3000);
      Assert.AreEqual(true,_permissionLocalizationPage.textBestOffers.Displayed);
    }



  }
}
