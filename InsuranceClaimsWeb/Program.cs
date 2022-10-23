using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => $"Hello World! from {Process.GetCurrentProcess().ProcessName}");

app.Run();
