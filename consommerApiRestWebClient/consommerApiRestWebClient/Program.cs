using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace consommerApiRestWebClient
{
	class Program
	{
		static void Main(string[] args)
		{

            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://swapi.dev/api/";
                Console.WriteLine("quelle planete voulez-vous voir?");
                string planet = Console.ReadLine();
                var json = webClient.DownloadString($"planets/{planet}/");

                Console.WriteLine( json);
            }
        }
	}
}
