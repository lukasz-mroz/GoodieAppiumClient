using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using AppiumClient;
using Castle.Components.DictionaryAdapter;
using GoodieAppiumClient.Pages;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace GoodieAppiumClient
{
  public class LoginPage : BasePage
  {
    /// <summary>
    /// Locators
    /// </summary>
    public AndroidElement loginByFacebook => Driver.FindElementById("pl.goodie.uat.debug:id/loginFacebookBtn");
    public AndroidElement loginByGoogle => Driver.FindElementById("pl.goodie.uat.debug:id/loginGoogleBtn");
    public AndroidElement emaiLoginField => Driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / androidx.appcompat.widget.LinearLayoutCompat[1] / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.EditText");
    public AndroidElement emailPasswordField => Driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / androidx.appcompat.widget.LinearLayoutCompat[2] / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.EditText");
    public AndroidElement loginByEmailButton => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.Button[2]");
    public AndroidElement accountDisplayName => Driver.FindElementById("com.google.android.gms:id/account_display_name");
    public IList<AndroidElement> googleAccounts => Driver.FindElementsById("com.google.android.gms:id/account_particle_disc");
    public AndroidElement snackBar => Driver.FindElementById("pl.goodie.uat.debug:id/snackbar_text");
    public AndroidElement errorValidation => Driver.FindElementById("pl.goodie.uat.debug:id/textinput_error");
    
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="loginType"></param>
    public void Login(ProviderEnum loginType = ProviderEnum.Email)
    {
      switch (loginType)
      {
        case ProviderEnum.Google:
          loginByGoogle.Click();
          break;
        case ProviderEnum.Facebook:
          loginByFacebook.Click();
          break;
        default:
          loginByEmailButton.Click();
          break;
      }
    }

    /// <summary>
    /// Choose random google account
    /// </summary>
    public void ChooseRandomAccount()
    {
      var random = new Random();
      var d = googleAccounts[random.Next(0, 3)];
      d.Click();
    }

    /// <summary>
    /// Login by email using credentials from Specflow file
    /// </summary>
    /// <param name="login"></param>
    /// <param name="password"></param>
    public void LoginByEmail(string login, string password)
    {
      emaiLoginField.SendKeys(login);
      emailPasswordField.SendKeys(password);
    }

    public void VerifyEmailLogin(bool text)
    {
   
    }

  }

}