using OpenQA.Selenium.Appium.Android;

namespace GoodieAppiumClient.Pages.ExtensionMethods
{
  public static class AndroidMethods
  {
    public static AndroidElement FindElementByIdAndText(this AndroidDriver<AndroidElement> driver, string id, string text)
    {
      return driver.FindElementByXPath($"//*[@id='pl.goodie.uat.debug:id/{id}' and contains(text(), '{text}')]");
    }


    // TO DO wymysl na uat i preprd string 
  }

}