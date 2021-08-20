using AppiumClient;
using GoodieAppiumClient.Pages;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient
{
  public class PermissionLocalizationPage : BasePage
  {
    // Page locators
    public AndroidElement shareLocalizationButton => Driver.FindElementById("pl.goodie.uat.debug:id/shareLocalizationButton");

    public AndroidElement skipButton => Driver.FindElementById("pl.goodie.uat.debug:id/skipButton");

    public AndroidElement textBestOffers => Driver.FindElementById("pl.goodie.uat.debug:id/askPermissionLocalizationTitle");


    // Pop-up locators
    private AndroidElement permissiongMessage => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.TextView");



    public void SkipButton()
    {
      skipButton.Click();
    }
    public void Login()
    {
      throw new System.NotImplementedException();
    }
  }
}