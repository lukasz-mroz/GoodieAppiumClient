using AppiumClient;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient
{
  public class YourGoodiePage : AppiumDriver
  {
    // Locators
    private AndroidElement searchField => Driver.FindElementById("pl.goodie.uat.debug:id/search");

    public void TypeInSearch(string text)
    {
      searchField.SendKeys(text);
    }





  }
}