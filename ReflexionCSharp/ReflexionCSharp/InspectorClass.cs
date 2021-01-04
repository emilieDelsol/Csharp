using System;
using System.Reflection;

namespace ReflexionCSharp
{
	internal class InspectorClass
	{
		private Type _objectType;
		public InspectorClass(Type objectType)
		{
			_objectType = objectType;
		}

		internal void GetAllProperties()
		{
			PropertyInfo[] properties = _objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
			Console.WriteLine("\n The properties of reflected class are:");
			foreach(var property in properties) { Console.WriteLine($"\t {property} \n\t\t Name: {property.Name} \n\t\t Property type: {property.PropertyType} \n\t\t Can Write?:{property.CanWrite} \n\t\tcan read:  {property.CanRead} \n\t\tattributes: {property.Attributes} \n\t\t custom attributes:{property.CustomAttributes} \n\t\t declaring type: {property.DeclaringType}"); }
		}

		internal void GetAllFields()
		{
			FieldInfo[] fields = _objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
			Console.WriteLine("\nThe fields infos of reflected class are:");
			foreach (var field in fields) { Console.WriteLine($"\n just field: {field} \n details: \n\t Name: {field.Name} \n\t type: {field.FieldType} \n\t declaring type: {field.DeclaringType} \n\t is public:{field.IsPublic} \n\t attribute: {field.Attributes}"); }
		}

		internal void GetAllMethods()
		{
			MethodInfo[] methods = _objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
			Console.WriteLine("\n The method infos of reflected class are:");
			foreach (var method in methods) { Console.WriteLine($"\n just method {method} \n\t Method name:  {method.Name} \n\t\t declaring type: {method.DeclaringType} \n\t\t return type: {method.ReturnType} \n\t\t attributes: {method.Attributes}\n\t\t Calling convention: {method.CallingConvention} \n\t\t Contains generic parameters:{method.ContainsGenericParameters}"); }

		}
	}
}