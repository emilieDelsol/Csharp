using System;

namespace Solid_Liskov
{
	class Program
	{
		static void Main(string[] args)
		{
            Square square = new Square { cote = 8 };
            Rectangle rectangle = new Rectangle { height = 10, width = 5 };
            double areaRectangle = rectangle.Area();
            double areaSquare = square.Area();

            Console.WriteLine($"Square area is: { square.Area()} \nRectangle area is:  { rectangle.Area()}");
        }
        public abstract class Polygone
        {
            public double height { get; set; }
            public double width { get; set; }
            public abstract double Area();

        }
        public class Rectangle : Polygone
        {
            public override double Area()
            {
                return width * height;
            }
        }
        public class Square : Polygone
        {
            public double cote;
            public override double Area()
            {
                height = width = cote;
                return height *width; 
            }
        }
    }
}
