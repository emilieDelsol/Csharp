using System;
using System.Collections.Generic;
using System.Text;

namespace consommerApiRestWebClient
{
	public class Planet
	{
		public string Name { get; set; }
		public int RotationPeriod { get; set; }
		public int OrbitalPeriod { get; set; }
		public int Diameter { get; set; }
		public string Climate { get; set; }
		public string Gravity { get; set; }
		public string Terrain { get; set; }
		public int SurfaceWater { get; set; }
		public int Population { get; set; }
		public List<string>	Residents { get; set; }
		public List<string>	Films { get; set; }
		public DateTime Created { get; set; }
		public DateTime Edited { get; set; }
		public string Url { get; set; }

	}

}
