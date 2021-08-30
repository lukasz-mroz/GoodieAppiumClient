using System;
using System.Collections.Generic;
using System.Text;
using AppiumClient;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient.Pages
{
  public class BasePage
  { 
    protected AppiumDriver<AndroidElement> Driver => AppiumManager.Driver;
    protected PlatfornEnum Platform => AppiumManager.IsOnIOS ? PlatfornEnum.IOS : PlatfornEnum.Android;
  }
}
