using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using GoodieAppiumClient.Settings;
using OpenQA.Selenium.Appium.Service;

namespace AppiumClient
{
  public class AppiumServer
  {
    private static AppiumLocalService _localService;
    public static event DataReceivedEventHandler OutputDataReceived;
    public static Uri ServerUri { get; private set; }

    public static bool IsServerRunning => ServerUri != null;

    public static void StartServerIfShouldRunLocally()
    {
      if (String.IsNullOrEmpty(Global.ServerUri))
      {
        _localService = new AppiumServiceBuilder()
          .WithAppiumJS(
            new FileInfo(Global.AppiumJS))
          .UsingAnyFreePort()
          .Build();

        _localService.OutputDataReceived += OnOutputDataReceived;
        _localService.Start();

        ServerUri = _localService.ServiceUrl;
      }
      else
      {
        ServerUri = new Uri(Global.ServerUri);
      }
    }

    public static void StopLocalService()
    {
      if (_localService != null && _localService.IsRunning)
      {
        _localService?.Dispose();
        _localService = null;
      }
    }
    private static void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
    {
      OutputDataReceived?.Invoke(sender, e);
    }


  }
}