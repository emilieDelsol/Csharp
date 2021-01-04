using System;
using System.Collections.Generic;
using System.Linq;

namespace ReflexionCSharp
{
	internal class ReflectedClass
	{
		private Int32 _id;
		private String Name { get; set; }
		private String FirstName  { get; set; }
        private List<Int32> Notes { get; set; }
		public ReflectedClass()
        {
            _id = 1;
            Name = String.Empty;
            FirstName = "Toto";
            Notes = new List<Int32> { 10, 12, 20, 15, 16, 18 };
        }

        private Int32 Average() 
        {
            return Notes.Sum()/Notes.Count();
        }
        private void DoSomething()

        {

            Console.WriteLine($"I am doing something ... The average of this student is {Average()}");

        }

    }
}