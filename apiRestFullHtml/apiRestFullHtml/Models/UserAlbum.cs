using apiRestFullHtml.Models.Blog;
using apiRestFullHtml.Models;
using System.Collections.Generic;

namespace apiRestFullHtml.Models
{
	public class UserAlbum
	{
			public int AlbumId { get; set; } 
			public List<Photos> PhotosList { get;  set; }
	}
}