using System.Linq;
using AppiumClient;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient.Pages
{
  public class MainPage : AppiumManager
  {
    public AndroidElement Discovery => Driver.FindElementsById("pl.goodie.uat.debug:id/bottomBarItemTitle").ElementAt(0);
    public AndroidElement YourGoodie => Driver.FindElementsById("pl.goodie.uat.debug:id/bottomBarItemTitle").ElementAt(1);
    public AndroidElement Profile => Driver.FindElementsById("pl.goodie.uat.debug:id/bottomBarItemTitle").ElementAt(2);
  }
}