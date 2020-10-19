using System;
using System.Collections.Generic;
namespace listT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List<T>\n************\n");
            List<char> listChar = new List<char>() {'a','b','c' };
            Console.Write("La chaine de caractère complète est :");
            foreach (char value in listChar) { Console.Write($" {value} "); }

            listChar.RemoveAt(0);
            Console.Write("\n************" +
                "\nJ'ai supprimé l'index 0:");
            foreach (char value in listChar) { Console.Write($" {value} "); }

            listChar.Remove('c');
            Console.Write("\n************" +
                "\nJ'ai supprimé la valeur c:");
            foreach (char value in listChar) { Console.Write($" {value} "); }

            listChar[0] = 'd';
            Console.Write("\n************" +
                "\nJ'ai modifié la valeur de l'index 0:");
            foreach (char value in listChar) { Console.Write($" {value} "); }

        }
    }
}
