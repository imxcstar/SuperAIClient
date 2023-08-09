using Microsoft.AspNetCore.Components.WebAssembly.Services;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<LazyAssemblyLoader>();
// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.Configure<StaticFileOptions>(options =>
{
    var provider = new FileExtensionContentTypeProvider();
    provider.Mappings[".tiktoken"] = "application/octet-stream";
    options.ContentTypeProvider = provider;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
