using System.Reflection;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace KyoboTeamsEApproval
{
  /// <summary>
  /// Application Insights GlobalProperties를 설정합니다.
  /// </summary>
  public class TelemetryInitializer : ITelemetryInitializer
  {
    public void Initialize(ITelemetry telemetry)
    {
      // [버전 정보 가져오는 법](https://edi.wang/post/2018/9/27/get-app-version-net-core)
      if (!telemetry.Context.GlobalProperties.ContainsKey("Version"))
      {
        telemetry.Context.GlobalProperties.Add("Version", Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion);
      }
    }
  }
}