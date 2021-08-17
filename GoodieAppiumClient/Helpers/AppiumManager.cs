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

    public static void ResetApp()
    {
      if (!AppiumServer.IsServerRunning)
      {
        AppiumServer.StartServerIfShouldRunLocally();
      }

      if (Driver != null)
      {
        Driver.ResetApp();
      }
      else
      {
        InitializeAppium();
      }
    }

    public static AndroidDriver<AndroidElement> InitializeAppium()
    {
      // capabilities of device
      var driverOption = new AppiumOptions();
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, AndroidSettings.platformName);
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, AndroidSettings.platformVersion);
      driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, AndroidSettings.deviceName);
      driverOption.AddAdditionalCapability(MobileCapabilityType.App, AndroidSettings.app);

      // assign instance of specific device to Driver
      Driver = new AndroidDriver<AndroidElement>(AppiumServer.ServerUri, driverOption);
      var driver = Driver;

      return driver;
    }

    public void CloseDriver()
    {
      Driver.Quit();
    }
  }
}