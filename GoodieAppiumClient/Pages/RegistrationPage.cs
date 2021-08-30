using System;
using System.Collections.Generic;
using System.Linq;
using AppiumClient;
using GoodieAppiumClient.Pages;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace GoodieAppiumClient
{
  public class RegistrationPage : BasePage
  {
    // ID Locators
    public AndroidElement registrationByFacebook => Driver.FindElementById("pl.goodie.uat.debug:id/registerWithFacebook");
    public AndroidElement registrationByGoogle => Driver.FindElementById("pl.goodie.uat.debug:id/registerWithGoogle");
    public IList<AndroidElement> genderList => Driver.FindElementsById("pl.goodie.uat.debug:id/optionSelectText");
    public AndroidElement registrationLoginButton => Driver.FindElementById("pl.goodie.uat.debug:id/registerWithEmail");

    // Xpath locators
    public AndroidElement registrationEmailField => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/androidx.appcompat.widget.LinearLayoutCompat[1]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
    public AndroidElement registrationPasswordField => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/androidx.appcompat.widget.LinearLayoutCompat[2]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
    public AndroidElement registrationLoginField => Driver.FindElementByXPath("/hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / androidx.appcompat.widget.LinearLayoutCompat[3] / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.EditText");


    public void SumbitRegistrationData(string login, string password, string loginName)
    {
      registrationEmailField.SendKeys(login);
      registrationPasswordField.SendKeys(password);
      registrationLoginField.SendKeys(loginName);
    }

    public void ChooseGender()
    {
      var random = new Random();
      var dealer = genderList[random.Next(0, 2)];
      dealer.Click();
    }

    public void Login()
    {
      registrationLoginButton.Click();
    }
  }

}
