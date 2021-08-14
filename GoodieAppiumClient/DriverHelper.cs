using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumClient
{
  public class DriverHelper
  {

    private readonly Settings _settings;
    public static AndroidDriver<AndroidElement> Driver { get; set; }

    public AndroidDriver<AppiumWebElement> InitializeAppium()
    {
      var driverOption = new AppiumOptions();
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, _settings.PlatformName);
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, _settings.PlatformVersion);
      driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName,_settings.DeviceName);
      driverOption.AddAdditionalCapability(MobileCapabilityType.App, _settings.App);

      return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"),driverOption);

    }
  }
}