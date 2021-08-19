using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient.Pages
{
  public class BrandListPage : BasePage
  {
    public IList<AndroidElement> listOfBrands => Driver.FindElementsById("pl.goodie.uat.debug:id/brandCircle");

    public AndroidElement nextButton => Driver.FindElementById("pl.goodie.uat.debug:id/nextButton");

    public void ClickOnThreeFirstelements()
    {
      var list = listOfBrands.Take(3);

      foreach (var d in list)
      {
        var random = new Random();
        var dealer = listOfBrands[random.Next(0, 15)];
        dealer.Click();
      }
    }

    public void ClickOnButton()
    {
      nextButton.Click();
    }
  }
}