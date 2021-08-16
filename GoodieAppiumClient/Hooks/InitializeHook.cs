using System;
using System.Collections.Generic;
using System.Text;
using AppiumClient;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Hooks
{
  [Binding]
  class InitializeHook
  {
    private readonly ScenarioContext _scenarioContext;
    private readonly AppiumDriver _appium;

    public InitializeHook(ScenarioContext scenarioContext, AppiumDriver appium)
    {
      _scenarioContext = scenarioContext;
      _appium = appium;
    }

    [BeforeScenario]
    public void Initialize()
    {
      _appium.InitializeAppium();
    }

    [AfterScenario]
    public void RunAfterScenario()
    {
    }

  }
}
