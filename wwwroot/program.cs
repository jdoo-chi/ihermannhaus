using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ���� ���� ���� ����
app.UseDefaultFiles();   // wwwroot/index.html, default.html ���� �⺻ ������ �ڵ� ����
app.UseStaticFiles();    // wwwroot ���� ��� ������ ���� ���Ϸ� ����

// SPA�� ����ũ ������ ���� ������ ��û�� index.html�� ������ (����)
app.MapFallbackToFile("index.html");

app.Run();
