using System.Text.Json;
using MakoBlog.Common.MakoBlogCommon.Dtos;
using MakoBlog.Server.DataProviders.Common;

namespace MakoBlog.Server.DataProviders.JsonDataProvider;
public class JsonDataProvider : IDataProvider
{
	private JsonDataProviderSettings _settings;

	public static string ProviderSectionName => "JsonDataProviderSettings";

	public JsonDataProvider(JsonDataProviderSettings settings)
	{
		_settings = settings;
	}

	public async Task<ISystemInformation> GetSystemInformation()
	{
		var systemInfoJson = await File.ReadAllTextAsync("wwwroot/system.json");

		var systemInfo = JsonSerializer.Deserialize<SystemInformation>(systemInfoJson);

		if (systemInfo == null) throw new FileNotFoundException();

		return systemInfo;
	}

	public async Task<IEnumerable<IPost>> GetPosts(int page, int pageSize)
	{
		var postsJson = await File.ReadAllTextAsync("wwwroot/posts.json");

		var postList = JsonSerializer.Deserialize<PostsListModel>(postsJson);

		if (postList == null) throw new FileNotFoundException();

		return postList.Posts.OrderByDescending(p => p.PublishedDate).Skip(pageSize * (page - 1)).Take(pageSize);
	}
}
