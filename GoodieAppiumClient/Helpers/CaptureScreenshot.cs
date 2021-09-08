using System;
using GoodieAppiumClient.Settings;
using Microsoft.VisualBasic;
using NUnit.Framework.Internal.Execution;

namespace AppiumClient
{
  public class CaptureScreenshot : AppiumManager
  {
    public static void CaptureScreenshots()
    {
      var random = new Random();
      var randomInt = random.Next(10000000);

      var screenshot = Driver.GetScreenshot();
      screenshot.SaveAsFile(Global.ScreenshotsFolder + $"{randomInt}.png");
    }
  }
}