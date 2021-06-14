using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using System;

public class TelemetryProcessor : ITelemetryProcessor
{
  private ITelemetryProcessor Next { get; set; }

  // 다음은 체인의 다음 원격 측정 프로세서를 가리킵니다.
  public TelemetryProcessor(ITelemetryProcessor next)
  {
    this.Next = next;
  }

  public void Process(ITelemetry item)
  {
    if (item is DependencyTelemetry dependencyTelemetry)
    {
      Console.WriteLine(dependencyTelemetry);
    }
    if (item is RequestTelemetry request)
    {
      Console.WriteLine(request.Name);
    }
    if (item is ExceptionTelemetry exceptionTelementry)
    {
      var exception = exceptionTelementry.Exception;
      var exceptionType = exception.GetType();
      Console.WriteLine(exception);
      Console.WriteLine(exceptionType);
    }

    this.Next.Process(item);
  }
}