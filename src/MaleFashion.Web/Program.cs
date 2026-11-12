using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using MaleFashion.Infrastructure.Extensions;
using MaleFashion.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

var bootstrapLoggerConfig = new LoggerConfiguration()
    .WriteTo.File("Logs/web-log-.log", rollingInterval: RollingInterval.Day);

try
{
    var connString = builder.Configuration.GetConnectionString("DefaultConnection");
    if (!string.IsNullOrWhiteSpace(connString) && !connString.Contains("Your_Server", StringComparison.OrdinalIgnoreCase))
    {
        bootstrapLoggerConfig.WriteTo.MSSqlServer(
            connectionString: connString,
            sinkOptions: new MSSqlServerSinkOptions
            {
                TableName = "Logs",
                AutoCreateSqlTable = true
            });
    }
}
catch
{

}

Log.Logger = bootstrapLoggerConfig.CreateBootstrapLogger();

try
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
        ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");


    var migrationAssembly = typeof(ApplicationDbContext).Assembly;

    builder.Services.AddDatabaseDeveloperPageExceptionFilter();


    #region Identity Configuration
    builder.Services.AddIdentity();
    #endregion

    builder.Services.AddControllersWithViews();

    #region Serilog Configuration
    builder.Host.UseSerilog((context, loggerConfiguration) =>
        loggerConfiguration.MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
            .Enrich.FromLogContext()
            .ReadFrom.Configuration(context.Configuration));

    #endregion

    #region Dependency Injection Configuration
    builder.Services.AddInfrastructureDependency();
    #endregion

    #region DbContext Configuration
    builder.Services.AddDbContext(connectionString, migrationAssembly);
    #endregion

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseMigrationsEndPoint();
    }
    else
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseRouting();

    app.UseAuthorization();

    app.MapStaticAssets();
    app.UseStaticFiles();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
        .WithStaticAssets();

    app.MapRazorPages()
       .WithStaticAssets();

    Log.Information("Application Starting...");

    app.Run();
}
catch(Exception ex)
{
    Log.Fatal(ex, "Application Crashed");
}
finally
{
    Log.CloseAndFlush();
}
