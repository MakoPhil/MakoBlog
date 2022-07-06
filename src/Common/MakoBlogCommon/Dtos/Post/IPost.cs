using NodaTime;

namespace MakoBlog.Common.MakoBlogCommon.Dtos;

public interface IPost
{
	Instant PublishedDate { get; }
	string Title { get; }
	string Body { get; }
	string[] Tags { get; }
}