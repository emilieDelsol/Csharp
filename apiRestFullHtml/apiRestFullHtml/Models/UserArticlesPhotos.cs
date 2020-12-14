using apiRestFullHtml.Controllers;
using apiRestFullHtml.Models.Blog;
using apiRestFullHtml.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRestFullHtml.Models
{
	public class UserArticlesPhotos
	{
		public List<Article> Articles { get; set; }
		public List<UserAlbum> userAlbums { get; set; }
	}
}
