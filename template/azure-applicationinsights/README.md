# Hi

> 🚨 **해당 코드는 index 역할만 하고 자세한 건 공식문서를 확인하세요.** 🚨

ASP.NET Core에서 Azure Application Insights를 사용하기 위한 샘플 코드 입니다.  
코드만 그대로 가져온 것이기 때문에 린트 에러가 발생합니다.  
나중에 사용할 때 코드를 잘 이해하고 사용하면 됩니다.

> 빠진 코드도 많습니다. 예를 들어 `appsettings.json` , 의존성 등등

# 호출 코드

## Startup.cs

```c#
// 앱 인사이트 활성화
services.AddApplicationInsightsTelemetry();
// 종속성 주입 컨테이너에 앱 인사이트 싱글턴 인스턴스 추가
services.AddSingleton<ITelemetryInitializer, TelemetryInitializer>();
```

## Program.cs

```c#
// 원격 분석 필터링
var ProcessorChainBuilder = aiConfig.TelemetryProcessorChainBuilder;
ProcessorChainBuilder.Use((next) => new TelemetryProcessor(next));
ProcessorChainBuilder.Build();
```
