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


  


