using System.Collections.Generic;
using System.Threading.Tasks;
using MakoBlog.Common.MakoBlogCommon.Dtos;
using RestSharp;

namespace MakoBlog.Client.MakoBlogUi.Services;

public class PostService : IPostService
{
	private RestClient _client;

	public PostService(RestClient client)
	{
		_client = client;
	}

	public async Task<IEnumerable<Post>> GetPosts(int pageNumber)
	{
		return await _client.GetJsonAsync<IEnumerable<Post>>("Posts", new { Page = pageNumber });
	}
}