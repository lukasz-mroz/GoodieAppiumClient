using System;
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
    // Locators
    AndroidElement loginByFacebook => Driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.widget.FrameLayout[1] / android.widget.Button");
    AndroidElement loginByGoogle => Driver.FindElementByXPath("	/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.Button");
    AndroidElement emaiLoginField => Driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / androidx.appcompat.widget.LinearLayoutCompat[1] / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.EditText");
    AndroidElement emailPasswordField => Driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / androidx.appcompat.widget.LinearLayoutCompat[2] / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.EditText");
    AndroidElement loginByEmailButton => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.Button[2]");
    AndroidElement accountDisplayName => Driver.FindElementById("com.google.android.gms:id/account_display_name");

    public void LoginUsingFacebook()
    {
      loginByFacebook.Click();
    }

    public void LoginUsingGoogle()
    {
      loginByGoogle.Click();
      accountDisplayName.Click();
    }

    public void LoginByEmail(string login, string password)
    {
      emaiLoginField.SendKeys(login);
      emailPasswordField.SendKeys(password);
     
    }

    public void LoginTap()
    {
      loginByEmailButton.Click();
    }
  }
}