using AppiumClient;
using GoodieAppiumClient.Pages;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient
{
  public class WelcomeScreenPage : BasePage
  {
    // Locators
    AndroidElement guestButton => Driver.FindElementById("pl.goodie.uat.debug:id/guestLoginButton");
    AndroidElement registrationButton => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.Button[2]");
    AndroidElement loginButton => Driver.FindElementById("pl.goodie.uat.debug:id/loginButton");


    public void EnterAsAGuest()
    {
      guestButton.Click();
    }

    public void Registrate()
    {
      registrationButton.Click();
    }

    public void LoginIn()
    {
      loginButton.Click();
    }
  }
}