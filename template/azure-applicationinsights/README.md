# Hi

> ๐จ **ํด๋น ์ฝ๋๋ index ์ญํ ๋ง ํ๊ณ  ์์ธํ ๊ฑด ๊ณต์๋ฌธ์๋ฅผ ํ์ธํ์ธ์.** ๐จ

ASP.NET Core์์ Azure Application Insights๋ฅผ ์ฌ์ฉํ๊ธฐ ์ํ ์ํ ์ฝ๋ ์๋๋ค.  
์ฝ๋๋ง ๊ทธ๋๋ก ๊ฐ์ ธ์จ ๊ฒ์ด๊ธฐ ๋๋ฌธ์ ๋ฆฐํธ ์๋ฌ๊ฐ ๋ฐ์ํฉ๋๋ค.  
๋์ค์ ์ฌ์ฉํ  ๋ ์ฝ๋๋ฅผ ์ ์ดํดํ๊ณ  ์ฌ์ฉํ๋ฉด ๋ฉ๋๋ค.

> ๋น ์ง ์ฝ๋๋ ๋ง์ต๋๋ค. ์๋ฅผ ๋ค์ด `appsettings.json` , ์์กด์ฑ ๋ฑ๋ฑ

๋น๋์๋ฌ๊ฐ ๋ฐ์ํ์ฌ ํ์ฅ์๋ฅผ `.txt` ์ผ๋ก ๋ณ๊ฒฝํ์์ต๋๋ค.

# ํธ์ถ ์ฝ๋

## Startup.cs

```c#
// ์ฑ ์ธ์ฌ์ดํธ ํ์ฑํ
services.AddApplicationInsightsTelemetry();
// ์ข์์ฑ ์ฃผ์ ์ปจํ์ด๋์ ์ฑ ์ธ์ฌ์ดํธ ์ฑ๊ธํด ์ธ์คํด์ค ์ถ๊ฐ
services.AddSingleton<ITelemetryInitializer, TelemetryInitializer>();
```

## Program.cs

```c#
// ์๊ฒฉ ๋ถ์ ํํฐ๋ง
var ProcessorChainBuilder = aiConfig.TelemetryProcessorChainBuilder;
ProcessorChainBuilder.Use((next) => new TelemetryProcessor(next));
ProcessorChainBuilder.Build();
```
