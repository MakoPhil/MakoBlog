using System;

namespace MakoBlog.Models.Posts
{
	public class PostModel
	{
		public DateTime Date { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public string Category { get; set; }
	}
}