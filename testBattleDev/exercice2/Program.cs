using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*******
 * Read input from Console
 * Use: Console.WriteLine to output your result to STDOUT.
 * Use: Console.Error.WriteLine to output debugging information to STDERR;
 *       
 * ***/

namespace CSharpContestProject
{
	class Program
	{
		static void Main(string[] args)
		{
			string line;
			while ((line = Console.ReadLine()) != null)
			{

				Console.Error.WriteLine(line);

				string[] i = line.Split(' ');
				string valeur = "";
				for (int n = 1; n < i.Length-1; n++)
				{
					Console.Error.WriteLine($"index {n} valeur: {i[n]}");
					valeur = i[n];
				}

				Console.Error.WriteLine($"La valeur de ma variable est {valeur}");

				char[] charArray = valeur.ToCharArray();

				for(int turn=0; turn<)
				
				/*
			    IEnumerable<String> i = line.Split(' ');
				if (i.Count() > 1)
				{
					Console.Error.WriteLine("message " + String.Join(" -> ", i));

					foreach (string j in i) { Console.Error.WriteLine(j); }
					

				}
				else
				{
					Console.Error.WriteLine("Déclaration du nombre N");
					int number = Convert.ToInt32(String.Join("", i));
					Console.Error.WriteLine(number);
				}/*/
				//
				// Lisez les données et effectuez votre traitement */
				//
			}

			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		}
	}
}