using System.Text.Json.Serialization;
using MakoBlog.Common.MakoBlogCommon.JsonConverters;
using NodaTime;

namespace MakoBlog.Common.MakoBlogCommon.Dtos;

public class Post : IPost
{
	[JsonConverter(typeof(InstantConverter))]
	public Instant PublishedDate { get; set; }
	public string Title { get; set; } = string.Empty;
	public string Body { get; set; } = string.Empty;
	public string[] Tags { get; set; } = Array.Empty<string>();
}