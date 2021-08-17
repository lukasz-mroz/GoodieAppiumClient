using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient.Pages
{
  public class BrandListPage : BasePage
  {
    private IEnumerable<AppiumWebElement> listOfBrands => Driver.FindElementsById("pl.goodie.uat.debug:id/brandsList");


    public void ClickOnThree()
    {
    }
  }
}