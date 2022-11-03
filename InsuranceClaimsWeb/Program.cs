using AspNetCoreSample.Model;
using AspNetCoreSample.Model.DbInitializer;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AspNetSampleDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:LocalDbConnectionString"]);
});


var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


app.MapGet("/", (IConfiguration configuration, AspNetSampleDbContext context) =>
{
   var claims = context.Claims;
   var myValue = configuration.GetValue<string>("MyKey");

   return  $"Hello World! from {Process.GetCurrentProcess().ProcessName} and key MyKey={myValue} from app settings" +
           $"There is an amount of {claims.Count()} of claims";
});

DbInitializer.Seed(app);
app.Run();
