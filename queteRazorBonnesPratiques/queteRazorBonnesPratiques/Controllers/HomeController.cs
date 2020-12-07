using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using queteRazorBonnesPratiques.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace queteRazorBonnesPratiques.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			IEnumerable<Int32> salary = new Int32[] { 1500, 1500, 1600, 1700, 1000, 1700, 1200 ,1100, 1400, 1600, 1500, 1500 };
			Int32 sum = salary.Sum();

			return View(sum);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
