using Microsoft.AspNetCore.Mvc;
using queteTemplatingRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace queteTemplatingRazor.Controllers
{
	public class ExpenditureController : Controller
	{
		public IActionResult Index()
		{
			List<Expenditure> expenditures = new List<Expenditure>()
			{
				new Expenditure() { spentName = "achat nouveau siège", spentDate = DateTime.Now, spentPrice = 149 },
				new Expenditure() { spentName = "achat jeux", spentDate = DateTime.Parse("12/10/2020 8:30:10 AM", System.Globalization.CultureInfo.InvariantCulture), spentPrice = 59 },
				new Expenditure() { spentName = "achat cadeau", spentDate = DateTime.Parse("12/10/2020 8:30:10 AM", System.Globalization.CultureInfo.InvariantCulture), spentPrice = 99 },
			};
			return View(expenditures);
		}
	}
}
