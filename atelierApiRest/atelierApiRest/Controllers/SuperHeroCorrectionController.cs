using atelierApiRest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace atelierApiRest.Controllers
{
	public class SuperHeroCorrectionController : Controller
	{
		public IActionResult Index()
		{

			//298 green arrow  457 533
			WebClient webClient = new WebClient();
			string qResponse = webClient.DownloadString("https://www.superheroapi.com/api.php/2854972614829284/298");
			string mrFreezeResponse = webClient.DownloadString("https://www.superheroapi.com/api.php/2854972614829284/457");
			string arrowResponse = webClient.DownloadString("https://www.superheroapi.com/api.php/2854972614829284/533");
			Hero q = JsonConvert.DeserializeObject<Hero>(qResponse);
			Hero mrFreeze = JsonConvert.DeserializeObject<Hero>(mrFreezeResponse);
			Hero arrow = JsonConvert.DeserializeObject<Hero>(arrowResponse);

			IEnumerable<Hero> heroes = new List<Hero>
			{
				q,mrFreeze,arrow
			};
			return View(heroes);
		}
	}
}
