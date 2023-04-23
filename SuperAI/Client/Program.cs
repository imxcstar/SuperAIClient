using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SuperAI.Client;
using SuperAI.Client.Services.StorageService;
using SuperAI.Client.Services.UIService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
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
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IStorageService, JSStorageInterop>();
builder.Services.AddSingleton<IScrollService, JSScrollInterop>();

await builder.Build().RunAsync();
