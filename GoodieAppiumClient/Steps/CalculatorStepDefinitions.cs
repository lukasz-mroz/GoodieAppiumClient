using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Steps
{
  [Binding]
  public sealed class CalculatorStepDefinitions
  {

    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
      _scenarioContext = scenarioContext;
    }

    [Given(@"I enter email and password")]
    public void GivenIEnterEmailAndPassword(Table table)
    {
    }

    [Given(@"I do sth")]
    public void GivenIDoSth()
    {
    }

    [Then(@"I select sth")]
    public void ThenISelectSth()
    {
    }

  }
}
