using AppiumClient;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace GoodieAppiumClient
{
  public class RegistrationPage : AppiumDriver
  {

    // Locators
    public AndroidElement registrationByFacebook => Driver.FindElementByXPath("/hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.widget.FrameLayout[1] / android.widget.TextView");

    public AndroidElement registrationByGoogle => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.Button");

    public AndroidElement registrationEmailField => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/androidx.appcompat.widget.LinearLayoutCompat[1]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");

    public AndroidElement registrationPasswordField => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/androidx.appcompat.widget.LinearLayoutCompat[2]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");

    public AndroidElement registrationLoginField => Driver.FindElementByXPath("/hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / androidx.appcompat.widget.LinearLayoutCompat[3] / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.EditText");

    public AndroidElement male => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.LinearLayout/android.widget.RelativeLayout[2]/android.widget.TextView");

    public AndroidElement female => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.LinearLayout/android.widget.RelativeLayout[1]/android.widget.TextView");

    public AndroidElement registrationLoginButton => Driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.Button");

    public void SumbitRegistrationData(string login, string password, string loginName)
    {
      registrationEmailField.SendKeys(login);
      registrationPasswordField.SendKeys(password);
      registrationLoginField.SendKeys(loginName);
      male.Click();
    }

    public void ChooseSex(AndroidElement sex)
    {
      if (sex == male)
      {
        male.Click();
      }
      if (sex == female)
      {
        female.Click();
      }
    }

    public void Login()
    {
      throw new System.NotImplementedException();
    }
  }

}
