using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 정적 파일 서빙 설정
app.UseDefaultFiles();   // wwwroot/index.html, default.html 등을 기본 문서로 자동 매핑
app.UseStaticFiles();    // wwwroot 하위 모든 파일을 정적 파일로 서빙

// SPA나 딥링크 지원을 위해 나머지 요청은 index.html로 포워딩 (선택)
app.MapFallbackToFile("index.html");

app.Run();
