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
    private readonly ScenarioContext _scenarioContext;
    private readonly AppiumManager _appium;

    public InitializeHook(ScenarioContext scenarioContext, AppiumManager appium)
    {
      _scenarioContext = scenarioContext;
      _appium = appium;
    }

    [BeforeScenario]
    public void Initialize()
    {
      AppiumServer.StartServerIfShouldRunLocally();
      AppiumManager.InitializeAppium();
      
    }

    [AfterScenario]
    public void RunAfterScenario()
    {
      _appium.CloseDriver();
    }

  }
}
