using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;
using System.Reflection;

namespace KyoboTeamsDownload
{
  public class TelemetryInitializer : ITelemetryInitializer
  {
    public void Initialize(ITelemetry telemetry)
    {
      // ref: https://edi.wang/post/2018/9/27/get-app-version-net-core
      if (!telemetry.Context.GlobalProperties.ContainsKey("Version"))
      {
        telemetry.Context.GlobalProperties.Add("Version", Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion);
      }
    }
  }
}