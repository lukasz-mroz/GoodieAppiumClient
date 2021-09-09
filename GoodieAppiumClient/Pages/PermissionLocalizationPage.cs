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

    public void SkipButton()
    {
      skipButton.Click();
    }
  }
}