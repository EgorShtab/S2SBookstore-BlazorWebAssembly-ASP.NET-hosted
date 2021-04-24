using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using S2SBookstore.Client.Core.HttpClients;
using S2SBookstore.Client.Core.Services;
using S2SBookstore.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace S2SBookstore.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient<IBookApiClient, BookApiClient>(configureClient=>
            {
                configureClient.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
            });

            builder.Services.AddTransient<IBookDataService, BookDataService>();

            await builder.Build().RunAsync();
        }
    }
}
