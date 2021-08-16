using System;
using System.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumClient
{
  public class AppiumDriver
  {

    //private readonly Settings _settings;
    public static AndroidDriver<AndroidElement> Driver { get; set; }

    public AndroidDriver<AndroidElement> InitializeAppium()
    {
      // capabilities of device
      var driverOption = new AppiumOptions();
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "10.0");
      driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "e589b3bb");
      driverOption.AddAdditionalCapability(MobileCapabilityType.App, "D:\\Goodie-epicDPPRD-25787-cps-discount-changes-uat-3.6.393-DEBUG.apk");
      var url = new Uri("http://localhost:4723/wd/hub");

      
      // assign instance of specific device to Driver
      Driver = new AndroidDriver<AndroidElement>(url, driverOption);
      var driver = Driver;

      return driver;
    }
  }
}