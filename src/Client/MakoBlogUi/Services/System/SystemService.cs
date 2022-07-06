using System.Threading.Tasks;
using MakoBlog.Common.MakoBlogCommon.Dtos;
using RestSharp;

namespace MakoBlog.Client.MakoBlogUi.Services;

public class SystemService : ISystemService
{
	private RestClient _client;

	public SystemService(RestClient client)
	{
		_client = client;
	}

	public async Task<ISystemInformation> LoadSystemInformation()
	{
		return await _client.GetJsonAsync<SystemInformation>("System");
	}
}
