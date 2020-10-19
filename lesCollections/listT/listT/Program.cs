using System;
using System.Collections.Generic;
namespace listT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List<T>\n************\n");
            List<string> listString = new List<string>() {"Hello ","world ","!!!" };
            Console.Write("La chaine de caractère complète est :");
            foreach (string value in listString) { Console.Write($" {value} "); }

            listString.RemoveAt(0);
            Console.Write("\n************" +
                "\nJ'ai supprimé l'index 0:");
            foreach (string value in listString) { Console.Write($" {value} "); }

            listString.Remove("!!!");
            Console.Write("\n************" +
                "\nJ'ai supprimé : !!!:");
            foreach (string value in listString) { Console.Write($" {value} "); }

            listString[0] = "Well done! :p";
            Console.Write("\n************" +
                "\nJ'ai modifié la valeur de l'index 0: ");
            listString.ForEach((String value) => Console.Write(value + " \n\n")
       );
        }
    }
}
