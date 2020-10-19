using System;
using System.Collections.Generic;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>();

            dictionary['a'] = "alpha";
            dictionary['b'] = "bravo";
            dictionary['c'] = "charly";
            Console.WriteLine("My complete dictionnary: ");
            foreach(var value in dictionary) { Console.WriteLine($"Key: {value.Key}, value: {value.Value}"); };
            Console.WriteLine("\nMy complete dictionary with only value:");
            foreach (var value in dictionary) { Console.Write($" {value.Value}"); };

            dictionary.Remove('c');
            Console.WriteLine("\nI have deleted letter 'c':");
            Console.WriteLine("\nMy complete dictionary is:");
            foreach (var value in dictionary) { Console.WriteLine($"Key: {value.Key}, value: {value.Value}"); };

            Console.WriteLine("\nMy complete dictionary with only value: ");
            foreach (var value in dictionary) { Console.Write($" {value.Value}"); };

            Console.WriteLine("\n************\n");
            Dictionary<char, List<string>> dictionnaryList = new Dictionary<char, List<string>>();
            List<string> listeA = new List<string>() { "alpha", "around" };
            dictionnaryList['a'] = listeA;
            dictionnaryList['b'] = new List<string>() { "beta", "baba" };
            dictionnaryList['c'] = new List<string>() { "charlie", "charles", "chat" };

            foreach (var value in dictionnaryList)
            {
                Console.WriteLine($"\nDictionnaire à l'index {value.Key}");
                foreach (string val in value.Value) { Console.Write($" {val} "); }
            }

            Console.WriteLine("\n\n************\nAfter remove index 'c'");
            dictionnaryList.Remove('c');
            foreach (var value in dictionnaryList)
            {
                Console.WriteLine($"\nDictionnaire à l'index {value.Key}");
                foreach (string val in value.Value) 
                { 
                    Console.Write($" {val} "); 
                }
            }
        }
    }
}
