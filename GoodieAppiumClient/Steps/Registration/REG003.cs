using System;
using GoodieAppiumClient.Pages;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Steps.Registration
{
    [Binding]
    public class REG003
    {
      private readonly RegistrationPage _registrationPage;

      public REG003(RegistrationPage registrationPage)
      {
        _registrationPage = registrationPage;
      }

      [Given(@"I click on Zarejestruj się z Google")]
        public void GivenIClickOnZarejestrujSieZGoogle()
        {
            _registrationPage.Registrate(ProviderEnum.Google);
        }
    }
}
