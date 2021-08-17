using System;
using System.Data;
using GoodieAppiumClient.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumClient
{
  public class AppiumManager
  {

    //private readonly Settings _settings;
    public static AndroidDriver<AndroidElement> Driver { get; set; }
    public static PlatfornEnum Platform { get; set; }
    public static bool IsOnIOS => Platform == PlatfornEnum.IOS;
    public static bool IsOnAndroid => Platform == PlatfornEnum.Android;


    public AndroidDriver<AndroidElement> InitializeAppium()
    {
      // capabilities of device
      var driverOption = new AppiumOptions();
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, AndroidSettings.platformName);
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, AndroidSettings.platformVersion);
      driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, AndroidSettings.deviceName);
      driverOption.AddAdditionalCapability(MobileCapabilityType.App, AndroidSettings.app);
      var url = new Uri(Global.ServerUri);

      // assign instance of specific device to Driver
      Driver = new AndroidDriver<AndroidElement>(url, driverOption);
      var driver = Driver;

      return driver;
    }

    public void CloseDriver()
    {
      Driver.Quit();
    }
  }
}