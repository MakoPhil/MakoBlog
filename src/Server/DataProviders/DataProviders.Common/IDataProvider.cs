using MakoBlog.Common.MakoBlogCommon.Dtos;

namespace MakoBlog.Server.DataProviders.Common;
public interface IDataProvider
{
	static string ProviderSectionName { get; } = string.Empty;
	Task<ISystemInformation> GetSystemInformation();
	Task<IEnumerable<IPost>> GetPosts(int page, int pageSize);
}
