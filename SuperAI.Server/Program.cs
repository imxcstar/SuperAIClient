using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SuperAI.Shared.Services.StorageService;
using SuperAI.Shared.Services.UIService;
using System.Net;
HttpClient.DefaultProxy = new WebProxy("http://192.168.31.169:7890");
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMasaBlazor(builder =>
{
    builder.ConfigureTheme(theme =>
    {
        theme.Themes.Light.Primary = "#4318FF";
        theme.Themes.Light.Accent = "#4318FF";
        theme.Themes.Light.Error = "#FF5252";
        theme.Themes.Light.Success = "#00B42A";
        theme.Themes.Light.Warning = "#FF7D00";
        theme.Themes.Light.Info = "#37A7FF";
    });
});
builder.Services.AddScoped<IStorageService, JSStorageInterop>();
builder.Services.AddScoped<IScrollService, JSScrollInterop>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
