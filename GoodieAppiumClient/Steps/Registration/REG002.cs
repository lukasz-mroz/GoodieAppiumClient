using System;
using GoodieAppiumClient.Pages;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Steps.Registration
{
    [Binding]
    public class REG002
    {
      private readonly RegistrationPage _registrationPage;

      public REG002(RegistrationPage registrationPage)
      {
        _registrationPage = registrationPage;
      }

        [Given(@"I click on Zarejestruj się z Faceboook")]
        public void GivenIClickOnZarejestrujSieZFaceboook()
        {
            _registrationPage.Registrate(ProviderEnum.Facebook);
        }
    }
}
