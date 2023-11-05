using Microsoft.EntityFrameworkCore;
using CryptoCalc.Server.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CryptoCalcServerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CryptoCalcServerContext") ?? throw new InvalidOperationException("Connection string 'CryptoCalcServerContext' not found.")));

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");
app.Run();
