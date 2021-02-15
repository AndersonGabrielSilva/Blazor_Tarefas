using Blazor_InjecaoDependencia_Core_3.Servicos;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_InjecaoDependencia_Core_3
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            #region COnfigurando Serviços para injeção de dependencia
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<ServicoSingleton>();
            builder.Services.AddScoped<ServicoScoped>();
            builder.Services.AddTransient<ServicoTransient>();
            #endregion

            await builder.Build().RunAsync();
        }
    }
}
