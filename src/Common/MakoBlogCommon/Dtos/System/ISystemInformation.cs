using Semver;

namespace MakoBlog.Common.MakoBlogCommon.Dtos;

public interface ISystemInformation
{
	Guid SystemId { get; }
	string BlogName { get; }
	SemVersion Version { get; }
	string BlogOwner { get; }
	string BlogAvatar { get; }
	string[] BlogTaglines { get; }
}