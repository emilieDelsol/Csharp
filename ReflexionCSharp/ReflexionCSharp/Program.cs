using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ReflexionCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			
			var reflected = new ReflectedClass();
			Type reflectedType = reflected.GetType();
			var inspector = new InspectorClass(reflectedType);
			Console.WriteLine("This is inspector for reflected class: ");
			inspector.GetAllProperties();
			inspector.GetAllFields();
			inspector.GetAllMethods();

			var newClass = new NewClass();
			Type typeNewClass = newClass.GetType();
			var inspector2 = new InspectorClass(typeNewClass);
			Console.WriteLine("This is inspector for NewClass class: ");
			inspector2.GetAllProperties();
		}
	}
}
