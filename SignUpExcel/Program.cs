using Microsoft.Extensions.FileProviders;
using Prometheus;
using Prometheus.DotNetRuntime;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
// Add services to the container.
builder.Services.AddControllersWithViews();
DotNetRuntimeStatsBuilder.Default().StartCollecting();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

//app.UseDirectoryBrowser();

app.UseDirectoryBrowser(
                    new DirectoryBrowserOptions()
                    {
                        FileProvider = new PhysicalFileProvider(
                        Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/excelFiles")),
                        RequestPath = new PathString("/excelFiles"),
                        Formatter = new Microsoft.AspNetCore.StaticFiles.SortedHtmlDirectoryFormatter()
                    }
                ) ;
app.UseMetricServer();
app.UseRouting();

app.UseHttpMetrics();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
