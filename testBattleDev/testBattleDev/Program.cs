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
				//
				// Lisez les données et effectuez votre traitement */
				//
				/*Console.WriteLine("Enter an integer between 3 and 100");*/
				Int32 firstInteger = Convert.ToInt32(Console.ReadLine());
				
				Dictionary<Int32, Int32> dict = new Dictionary<Int32, Int32>();
				for (int i = 0; i < firstInteger; i++)
				{
					dict.Add(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
					
				}
				
				Int32 flag;
				Int32 compromise;
				
				foreach(var value in dict)
                {
					flag = value.Value;
					int test = 0;
					foreach (var secondValue in dict)
                    {
						if (flag!=secondValue.Value)
                        {
							test += 1;
                        }
                    }
					if (test>1)
                    {
						compromise = value.Key;
						Console.WriteLine(compromise);
						// Console.Error.WriteLine(compromise);
					}

                }
				
				
			}

			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		}
	}
}
/*
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

/*namespace CSharpContestProject
{
	class Program
	{
		static void Main(string[] args)
		{
			string line;
			Dictionary<string, string> dict = new Dictionary<string, string>();

			while ((line = Console.ReadLine()) != null)
			{
				int number;
				IEnumerable<String> i = line.Split(' ');
				if (i.Count() > 1)
				{
					Console.Error.WriteLine("Ligne de production " + String.Join(" -> ", i));

					foreach (string j in i) { Console.Error.WriteLine(j); }
					string[] key = i.ToArray();

					Console.Error.WriteLine($"key = {key[0]}, value={key[1]} ");
					dict.Add(key[0], key[1]);
				}
				else
				{
					Console.Error.WriteLine("Déclaration du nombre de lignes de production");
					number = Convert.ToInt32(String.Join("", i));
					Console.Error.WriteLine(number);
				}
			}
			//
			// Lisez les données et effectuez votre traitement */

			/*string flag;
			string compromise;

			foreach (var value in dict)
			{
				flag = value.Value;
				int test = 0;
				foreach (var secondValue in dict)
				{
					if (flag != secondValue.Value)
					{
						test += 1;
					}
				}
				if (test > 1)
				{
					compromise = value.Key;
					Console.WriteLine(compromise);
					Console.Error.WriteLine($"Compromise is {compromise}");
				}

			}*/
			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		/*}
	}
}
*/