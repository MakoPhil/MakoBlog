using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MakoBlog.Client.MakoBlogUi.Models.Config;
using MakoBlog.Client.MakoBlogUi.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;

namespace MakoBlog.Client.MakoBlogUi;
public class Program
{
	public static async Task Main(string[] args)
	{
		var builder = WebAssemblyHostBuilder.CreateDefault(args);
		builder.RootComponents.Add<App>("app");

		var config = await SetupConfig(builder);

		SetupRestClient(builder, config);

		SetupServices(builder);

		await builder.Build().RunAsync();
	}

	private async static Task<Config> SetupConfig(WebAssemblyHostBuilder builder)
	{
		var configHttpClient = new HttpClient { BaseAddress = new Uri($"{builder.HostEnvironment.BaseAddress}") };
		var config = await configHttpClient.GetFromJsonAsync<Config>("config.json")
			.ConfigureAwait(false);

		builder.Services.AddSingleton<Config>(config);

		return config;
	}

	private static void SetupRestClient(WebAssemblyHostBuilder builder, Config config)
	{
		var httpClient = new HttpClient { BaseAddress = new Uri(config.ApiUrl) };

		builder.Services.AddSingleton<RestClient>(new RestClient(httpClient));

	}

	private static void SetupServices(WebAssemblyHostBuilder builder)
	{
		builder.Services.AddSingleton<ISystemService>(s => new SystemService(s.GetService<RestClient>()));
		builder.Services.AddSingleton<IPostService>(s => new PostService(s.GetService<RestClient>()));
	}
}
