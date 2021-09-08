using System;
using System.Collections.Generic;
using System.Text;
using AppiumClient;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SpecResults;
using SpecResults.Model;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Hooks
{
  [Binding]
  class InitializeHook
  {
    private readonly ISpecFlowContext _scenarioContext;

    public InitializeHook(ScenarioContext scenarioContext)
    {
      _scenarioContext = scenarioContext;
    }

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
      if (_scenarioContext.TestError != null)
      {
        CaptureScreenshot.CaptureScreenshots();
      }
    }

  }
}
