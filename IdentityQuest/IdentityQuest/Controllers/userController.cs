using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityQuest.Controllers
{
	[Authorize]
	public class userController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
