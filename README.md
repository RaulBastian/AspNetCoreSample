# ASPNET core sample

1) In process and out of process launch profiles test, obtaned results with:  
   ```
   app.MapGet("/", () => $"Hello World! from {Process.GetCurrentProcess().ProcessName}");
   ```
   Posible values:   
   W3WP (In process IIS)   
   IISEXPRESS (In process IISEXPRESS)   
   ASPNETCoreSample (Out of process IISEXPRESS, ISS and when run from dotnet run)  


2) Obtaining a value from a custom settings key

    ```
    appsettings.json  
    appsettings.development.json  
    environment variable
    ```

3) Custom db data context

    ```
    We register the dependency injector

    builder.Services.AddDbContext<AspNetSampleDbContext>(options => {
      options.UseSqlServer(builder.Configuration["ConnectionStrings:LocalDbConnectionString"]);
    });

    public class AspNetSampleDbContext:DbContext
      {
          public AspNetSampleDbContext(DbContextOptions<AspNetSampleDbContext> options) :base(options)
          {
              
          }

          public DbSet<Claim> Claims { get; set; } = default(DbSet<Claim>)!;
          public DbSet<Appointment> Appointments { get; set; } = default(DbSet<Appointment>)!;
          public DbSet<Expense> Expenses { get; set; } = default(DbSet<Expense>)!;
          public DbSet<Invoice> Invoices { get; set; } = default(DbSet<Invoice>)!;
          public DbSet<PolicyHolder> PolicyHolders { get; set; } = default(DbSet<PolicyHolder>)!;
          public DbSet<Repairer> Repairers { get; set; } = default(DbSet<Repairer>)!;
      }
  