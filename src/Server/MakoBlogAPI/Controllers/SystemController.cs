using MakoBlog.Server.DataProviders.Common;
using MakoBlog.Common.MakoBlogCommon.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MakoBlog.Server.MakoBlogAPI.Controllers;

[ApiController, Route("[controller]")]
public class SystemController : ControllerBase
{
	private IDataProvider _dataProvider;

	public SystemController(IDataProvider dataProvider)
	{
		_dataProvider = dataProvider;
	}

	[HttpGet(Name = "GetSystemInformation")]
	public async Task<ISystemInformation> Get()
	{
		return await _dataProvider.GetSystemInformation();
	}
}