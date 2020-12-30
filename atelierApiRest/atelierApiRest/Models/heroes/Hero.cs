using atelierApiRest.Models.heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atelierApiRest.Models
{
	public class Hero
	{
		public int id { get; set;  }
		public String Name { get; set;  }
		public Powerstats Powerstats { get; set; }
		public Biography Biography { get; set;  }
		public Work work { get; set; }
		public ImageSuperHero Image { get; set;  }

	}
}
