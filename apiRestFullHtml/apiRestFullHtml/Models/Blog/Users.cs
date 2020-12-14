using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRestFullHtml.Models.Blog
{
	class Users
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public Adress adress { get; set; }
		public string Phone { get; set; }
		public string Website { get; set; }
		public Company company { get; set; }
	}
}
