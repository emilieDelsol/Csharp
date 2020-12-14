
using apiRestFullHtml.Models.Blog;
using System.Collections.Generic;

namespace apiRestFullHtml.Models
{
	public class Article
	{
		public Post Post { get; set; }

		public List<Comments> ListComments { get; set; }
	}
}