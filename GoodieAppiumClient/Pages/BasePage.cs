using System;
using System.Collections.Generic;
using System.Text;
using AppiumClient;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;

namespace GoodieAppiumClient.Pages
{
  public class BasePage
  { 
    protected AppiumDriver<AndroidElement> Driver => AppiumManager.Driver;
    protected AppiumDriver<IOSElement> iOSDriver => AppiumManager.iOSDriver;
  }
}
