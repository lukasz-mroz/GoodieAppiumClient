using System;
using System.Data;
using GoodieAppiumClient.Settings;
using Google.Protobuf;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;

namespace AppiumClient
{
  public class AppiumManager
  {
    public static AndroidDriver<AndroidElement> Driver { get; set; }
    public static IOSDriver<IOSElement> iOSDriver { get; set; }
   

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
    public static void InitializeAppium()
    {
      // capabilities of device
      var driverOption = new AppiumOptions();
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, Android.platformName);
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, Android.platformVersion);
      driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, Android.deviceName);
      driverOption.AddAdditionalCapability(MobileCapabilityType.App, Android.app);

      var iOSOption = new AppiumOptions();
      iOSOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, iOS.platformName);
      iOSOption.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, iOS.platformVersion);


      // assign instance of specific device to Driver
      Driver = new AndroidDriver<AndroidElement>(AppiumServer.ServerUri, driverOption);
      iOSDriver = new IOSDriver<IOSElement>(AppiumServer.ServerUri, iOSOption);
    }

    public static void CloseDriver()
    {
      Driver.Quit();
    }
  }
}