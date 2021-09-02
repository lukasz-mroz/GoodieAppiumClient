﻿using AppiumClient;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient.Pages
{
  public class YourBrandsWidget : AppiumManager
  {
    public AndroidElement content => Driver.FindElementById("pl.goodie.uat.debug:id/brandCircleImageView");

    public bool CheckIfThereIsContent()
    {
      if (content.Displayed)
        return true;
      {
        return false;
      }
    }

  }
}