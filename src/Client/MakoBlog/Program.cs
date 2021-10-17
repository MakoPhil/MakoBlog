using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MakoBlog.Models.Settings;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace MakoBlog
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("app");

			var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };

			builder.Services.AddScoped(sp => httpClient);

			var siteSettings = await httpClient.GetFromJsonAsync<SettingsModel>("settings.json")
				.ConfigureAwait(false);

			builder.Services.AddSingleton<BlogBasicsModel>(siteSettings.BlogBasics);

			await builder.Build().RunAsync();
		}
	}
}
