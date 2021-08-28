using System;
using System.Collections.Generic;
using System.Text;
using AppiumClient;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SpecResults;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Hooks
{
  [Binding]
  class InitializeHook
  {

    [BeforeTestRun]
    public static void BeforeTestRun()
    {
      AppiumServer.StartServerIfShouldRunLocally();
    }

    [AfterTestRun]
    public static void AfterTestRun()
    {
      AppiumManager.CloseDriver();
      AppiumServer.StopLocalService();
    }

    [BeforeScenario]
    public void Initialize()
    {
      AppiumManager.ResetApp();
    }

    [AfterScenario]
    public void RunAfterScenario()
    {
    }

  }
}
