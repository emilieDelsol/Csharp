using System;
using System.Collections.Generic;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary["a"] = "alpha";
            dictionary["b"] = "bravo";
            dictionary["c"] = "charly";
            Console.WriteLine("My complete dictionnary: ");
            foreach(var value in dictionary) { Console.WriteLine($"Key: {value.Key}, value: {value.Value}"); };
            Console.WriteLine("\nMy complete dictionary with only value:");
            foreach (var value in dictionary) { Console.Write($" {value.Value}"); };

            dictionary.Remove("c");
            Console.WriteLine("\nI have deleted letter 'c':");
            Console.WriteLine("\nMy complete dictionary is:");
            foreach (var value in dictionary) { Console.WriteLine($"Key: {value.Key}, value: {value.Value}"); };

            Console.WriteLine("\nMy complete dictionary with only value: ");
            foreach (var value in dictionary) { Console.Write($" {value.Value}"); };
        }
    }
}
