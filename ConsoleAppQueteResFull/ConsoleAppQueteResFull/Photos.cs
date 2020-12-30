using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppQueteResFull
{
	class Photos
	{
		public int AlbumId { get; set; }
		public int Id { get; set; }
		public string Title { get; set; }
		public string Url { get; set; }
		public string ThumbnailUrl { get; set; }
		public override string ToString()
		{
			return ($"Photo title {Title} url: {Url}");
		}
	}
}
