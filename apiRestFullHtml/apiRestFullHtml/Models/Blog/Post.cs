﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRestFullHtml.Models.Blog
{
	public class Post
	{
		public int userId { get; set; }
		public int Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
	}
}
