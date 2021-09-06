using System;
using GoodieAppiumClient.Pages;
using Shouldly;
using TechTalk.SpecFlow;

namespace GoodieAppiumClient.Features
{
    [Binding]
    public class WID001
    {
      private readonly YourBrandsWidget _yourBrandsWidget;

      public WID001(YourBrandsWidget yourBrandsWidget)
      {
        _yourBrandsWidget = yourBrandsWidget;
      }

        [Then(@"I should see the content of the app")]
        public void ThenIShouldSeeTheContentOfTheApp()
        {
          _yourBrandsWidget.content.Displayed.ShouldBe(true);
        }
    }
}
