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
			var inspector = new InspectorClass(reflected);
			inspector.GetAllProperties();
			inspector.GetAllFields();
			inspector.GetAllMethods();
		}
	}
}
