using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient.Pages
{
  public class ProfilePage : BasePage
  {
    public AndroidElement nameLabel => Driver.FindElementById("pl.goodie.uat.debug:id/nameLabel");
    public AndroidElement mailLabel => Driver.FindElementById("pl.goodie.uat.debug:id/mailLabel");
    public AndroidElement myBrands => Driver.FindElementById("pl.goodie.uat.debug:id/myBrands");
    public AndroidElement likedDiscount => Driver.FindElementById("pl.goodie.uat.debug:id/likedDiscounts");
    public AndroidElement notifications => Driver.FindElementById("pl.goodie.uat.debug:id/notifications");
    public AndroidElement myData => Driver.FindElementsById("pl.goodie.uat.debug:id/menuItemTV").ElementAt(1);
    public AndroidElement myLocalization => Driver.FindElementsById("pl.goodie.uat.debug:id/menuItemTV").ElementAt(2);
  }
}