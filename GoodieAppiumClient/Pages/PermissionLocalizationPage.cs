using AppiumClient;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient
{
  public class PermissionLocalizationPage : AppiumDriver
  {
    // Page locators
    public AndroidElement shareLocalizationButton => Driver.FindElementByXPath(
      "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.view.ViewGroup/android.widget.Button");

    public AndroidElement skipButton => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.view.ViewGroup/android.widget.TextView[3]");

    public AndroidElement textBestOffers => Driver.FindElementByXPath("	/hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout / android.widget.ScrollView / android.view.ViewGroup / android.widget.TextView[1]");


    // Pop-up locators
    private AndroidElement permissiongMessage => Driver.FindElementByXPath(
      "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.TextView");



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