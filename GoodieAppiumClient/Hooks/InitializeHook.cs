using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Hooks
{
  [Binding]
  class InitializeHook
  {
    private readonly ScenarioContext _scenarioContext;

    public InitializeHook(ScenarioContext scenarioContext)
    {
      _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public void Initialize()
    {
      AndroidDriver appiumDriver = new AppiumDriver();
      _scenarioContext.Set(appiumDriver.I);
    }

  }
}
