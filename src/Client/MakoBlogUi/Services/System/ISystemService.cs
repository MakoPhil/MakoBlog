using System.Threading.Tasks;
using MakoBlog.Common.MakoBlogCommon.Dtos;

namespace MakoBlog.Client.MakoBlogUi.Services;

public interface ISystemService
{
	Task<ISystemInformation> LoadSystemInformation();
}