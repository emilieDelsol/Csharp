using System;
using System.Reflection;

namespace ReflexionCSharp
{
	internal class InspectorClass
	{
		private Type _objectType;
		public InspectorClass(ReflectedClass reflected)
		{
			Type objectType = reflected.GetType();
			_objectType = objectType;
		}

		internal void GetAllProperties()
		{
			
			PropertyInfo[] properties = _objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
			Console.WriteLine("\n The properties of reflected class are:");
			foreach(var property in properties) { Console.WriteLine($"\t {property}"); }
		}

		internal void GetAllFields()
		{
			FieldInfo[] fields = _objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
			Console.WriteLine("\nThe fields infos of reflected class are:");
			foreach (var field in fields) { Console.WriteLine($"\n\t Name: {field.Name} \n\t type: {field.FieldType} \n\t declaring type: {field.DeclaringType} \n\t is public:{field.IsPublic} \n\t attribute: {field.Attributes}"); }
		}

		internal void GetAllMethods()
		{
			MethodInfo[] methods = _objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
			Console.WriteLine("\n The method infos of reflected class are:");
			foreach (var method in methods) { Console.WriteLine($"\t {method}"); }

		}
	}
}