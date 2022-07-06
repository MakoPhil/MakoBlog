using System.Collections.Generic;
using System.Threading.Tasks;
using MakoBlog.Common.MakoBlogCommon.Dtos;

namespace MakoBlog.Client.MakoBlogUi.Services;

public interface IPostService
{
	Task<IEnumerable<Post>> GetPosts(int pageNumber);
}