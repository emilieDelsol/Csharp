﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRestFullHtml.Models.Blog
{
	public class Adress
	{
		public string street { get; set; }
		public string suite { get; set; }
		public string city { get; set; }
		public string Zipcode { get; set; }
		public Geo geo { get; set; }
	}
}