using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumClient
{
  public class DriverHelper
  {
    public static AndroidDriver<AndroidElement> Driver { get; set; }

    public AndroidDriver<AppiumWebElement> InitializeAppium()
    {
      var driverOption = new AppiumOptions();
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
      driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "7.0");
      driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "XVV7N17317000281");
      driverOption.AddAdditionalCapability(MobileCapabilityType.App, "D:\\Goodie-epicDPPRD-25787-cps-discount-changes-uat-3.6.393-DEBUG.apk");

      return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"),driverOption);

    }
  }
}