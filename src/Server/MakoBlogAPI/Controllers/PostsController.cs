using MakoBlog.Common.MakoBlogCommon.Dtos;
using MakoBlog.Server.DataProviders.Common;
using Microsoft.AspNetCore.Mvc;

namespace MakoBlog.Server.MakoBlogAPI.Controllers;

[ApiController, Route("[controller]")]
public class PostsController : ControllerBase
{
	private IDataProvider _dataProvider;

	public PostsController(IDataProvider dataProvider)
	{
		_dataProvider = dataProvider;
	}

	[HttpGet(Name = "GetPosts")]
	public async Task<IEnumerable<IPost>> Get([FromQuery] int page)
	{
		return await _dataProvider.GetPosts(page, 100);
	}
}