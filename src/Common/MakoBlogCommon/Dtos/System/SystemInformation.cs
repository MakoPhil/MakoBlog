using System.Text.Json.Serialization;
using MakoBlog.Common.MakoBlogCommon.JsonConverters;
using Semver;

namespace MakoBlog.Common.MakoBlogCommon.Dtos;

public class SystemInformation : ISystemInformation
{
	public Guid SystemId { get; set; }
	public string BlogName { get; set; } = string.Empty;
	public string BlogOwner { get; set; } = string.Empty;
	public string BlogAvatar { get; set; } = string.Empty;
	public string[] BlogTaglines { get; set; } = Array.Empty<string>();
	[JsonConverter(typeof(SemVersionConverter))]
	public SemVersion Version { get; set; } = Semver.SemVersion.Parse("0.0.0", SemVersionStyles.Strict);
}