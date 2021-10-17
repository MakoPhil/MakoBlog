using System.Collections.Generic;

namespace MakoBlog.Models.Settings
{
	public class BlogBasicsModel
	{
		public string BlogName { get; set; }
		public string BlogOwner { get; set; }
		public List<string> BlogTaglines { get; set; }
	}
}