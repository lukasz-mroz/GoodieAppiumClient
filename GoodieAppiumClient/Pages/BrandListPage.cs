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
    // Locators
    public AndroidElement searchField => Driver.FindElementById("pl.goodie.uat.debug:id/searchButton");
    public AndroidElement editText => Driver.FindElementById("pl.goodie.uat.debug:id/editText");
    public IList<AndroidElement> listOfBrands => Driver.FindElementsById("pl.goodie.uat.debug:id/brandCircle");
    public AndroidElement nextButton => Driver.FindElementById("pl.goodie.uat.debug:id/nextButton");

    public void ClickOnThreeFirstelements()
    {
      var brands = listOfBrands.Take(3);

      foreach (var brand in brands)
      {
        var random = new Random();
        var element = listOfBrands[random.Next(0, 13)];
        element.Click();
      }
    }

    public void ClickOnButton()
    {
      nextButton.Click();
    }

    public void SearchBrandOnSearchField(string brandName)
    {
      searchField.Click();
      editText.SendKeys(brandName);

    }
  }
}