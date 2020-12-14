using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRestFullHtml.Models.Blog
{
	public class Comments
	{
		public int PostId { get; set; }
		public int id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Body { get; set; }
		
	}
}