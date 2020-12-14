using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRestFullHtml.Models.Blog
{
	public class Photos
	{
		public int AlbumId { get; set; }
		public int Id { get; set; }
		public string Title { get; set; }
		public string Url { get; set; }
		public string ThumbnailUrl { get; set; }
	}
}
