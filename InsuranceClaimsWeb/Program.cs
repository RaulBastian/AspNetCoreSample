using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (IConfiguration configuration) =>
{
   var myValue = configuration.GetValue<string>("MyKey");
   return  $"Hello World! from {Process.GetCurrentProcess().ProcessName} and key MyKey={myValue} from app settings";
});

app.Run();
