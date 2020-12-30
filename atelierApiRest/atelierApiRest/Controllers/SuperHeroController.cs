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
	[Route("favorite/heroes")]
	public class SuperHeroController : Controller
	{
		public IActionResult Index()
		{
			WebClient webClient = new WebClient();
			var ironMan = webClient.DownloadString("https://www.superheroapi.com/api.php/2854972614829284/732");
			Hero heroe = JsonConvert.DeserializeObject<Hero>(ironMan);
			return View(heroe);
		}
	}
}
