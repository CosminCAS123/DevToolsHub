using DevToolsHub;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using DevToolsHub.Services;
using MudBlazor;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredLocalStorage();
AddToolServices();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PreventDuplicates = true;
    config.SnackbarConfiguration.VisibleStateDuration = 2000;
    config.SnackbarConfiguration.ShowCloseIcon = false;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;
});
await builder.Build().RunAsync();


 void AddToolServices()
{
    builder.Services.AddTransient<UuidService>();
    builder.Services.AddTransient<ClipboardService>();
    builder.Services.AddTransient<Base64Service>();
    builder.Services.AddTransient<UrlService>();
    builder.Services.AddTransient<JsonService>();
    builder.Services.AddTransient<TimestampConverterService>();
    builder.Services.AddTransient<HashingService>();
    builder.Services.AddTransient<RegexService>();

}