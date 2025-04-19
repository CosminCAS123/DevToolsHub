using DevToolsHub;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using System.Runtime.CompilerServices;
using DevToolsHub.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
AddToolServices();
await builder.Build().RunAsync();


 void AddToolServices()
{
    builder.Services.AddTransient<UuidService>();
    builder.Services.AddTransient<ClipboardService>();
}