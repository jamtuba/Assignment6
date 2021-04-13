using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment6
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            var baseAddress = builder.Configuration["baseAddress"] ?? builder.HostEnvironment.BaseAddress;
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
