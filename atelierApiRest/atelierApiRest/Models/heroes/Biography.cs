using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atelierApiRest.Models.heroes
{
	public class Biography
	{
		[JsonProperty("full-name")]
		public string FullName { get; set; }
		[JsonProperty("alter-egos")]
		public string AlterEgo { get; set; }
		public IEnumerable<String> Aliases { get; set;  }

		[JsonProperty("place-of-birth")]
		public string PlaceOfBirth { get; set; }
		[JsonProperty("first-appearance")]
		public string FirstApearance { get; set; }
		public string Publisher { get; set; }
		public string Alignment { get; set; }
		
	}
}
