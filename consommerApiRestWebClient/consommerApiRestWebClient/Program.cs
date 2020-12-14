using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace consommerApiRestWebClient
{
	class Program
	{
		static void Main(string[] args)
		{
			WebClient webClient = new WebClient();
			Console.WriteLine("quelle planete voulez-vous voir?");
			string planetNumber = Console.ReadLine();
			string response= webClient.DownloadString($"https://swapi.dev/api/planets/{planetNumber}/");
			Planet planet = JsonConvert.DeserializeObject<Planet>(response);
			string resident = "";
			foreach(string residents in planet.Residents)
			{
				resident = resident + " " + residents;
			}
			string films = "";
			foreach (string film in planet.Films)
			{
				films = films + " " + film;
			}
			Console.WriteLine($"Name: {planet.Name} \nRotation period: {planet.RotationPeriod} \nOrbital period: {planet.OrbitalPeriod}\nDiameter: {planet.Diameter}\nClimate: {planet.Climate}\nGravity: {planet.Gravity}\nTerrain: {planet.Terrain}\nSurface water: {planet.SurfaceWater}\nPopulation: {planet.Population}\nResidents: {resident}\nFilms: {films}\nCreated: {planet.Created}\nEdited: {planet.Edited}\nUrl: {planet.Url}");

			XElement table = new XElement("table");
			table.Add(new XAttribute("border", "1"));
			table.Add(new XAttribute("style", "width:300px"));
			XElement tr = new XElement("tr");
		

			XElement tr2 = new XElement("tr");
			tr2.Add(new XElement("td", "Name"),
					new XElement("td", planet.Name));

			XElement tr3 = new XElement("tr");
			tr3.Add(new XElement("td", "Rotation period"),
					new XElement("td", planet.RotationPeriod));

			XElement tr4 = new XElement("tr");
			tr4.Add(new XElement("td", "Orbital period"),
					new XElement("td", planet.OrbitalPeriod));

			XElement tr5 = new XElement("tr");
			tr5.Add(new XElement("td", "Diameter"),
					new XElement("td", planet.Diameter));

			XElement tr6 = new XElement("tr");
			tr6.Add(new XElement("td", "Gravity"),
					new XElement("td", planet.Gravity));

			XElement tr7 = new XElement("tr");
			tr7.Add(new XElement("td", "Terrain"),
					new XElement("td", planet.Terrain));

			XElement tr8 = new XElement("tr");
			tr8.Add(new XElement("td", "Surface water"),
					new XElement("td", planet.SurfaceWater));

			XElement tr9 = new XElement("tr");
			tr9.Add(new XElement("td", "Population"),
					new XElement("td", planet.Population));

			XElement tr10 = new XElement("tr");
			tr10.Add(new XElement("td", "Residentsr"),
					new XElement("td", resident));

			XElement tr11 = new XElement("tr");
			tr11.Add(new XElement("td", "Films"),
					new XElement("td", films));

			XElement tr12 = new XElement("tr");
			tr12.Add(new XElement("td", "Created"),
					new XElement("td", planet.Created));
			
			XElement tr13 = new XElement("tr");
			tr13.Add(new XElement("td", "Edited"),
					new XElement("td", planet.Edited));

			XElement tr14 = new XElement("tr");
			tr14.Add(new XElement("td", "Url"),
					new XElement("td", planet.Url));

			table.Add(tr, tr2, tr3, tr4, tr5, tr6, tr7,tr8,tr9,tr10,tr11,tr12,tr13);
			File.WriteAllText("mytable.html", table.ToString());
			Console.WriteLine(table); // display in browser
		}
	}
}
