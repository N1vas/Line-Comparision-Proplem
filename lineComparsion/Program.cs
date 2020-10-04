using System;

namespace lineComparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line COmparision Computaion Program on master branch");
			Console.WriteLine("Enter the co-ordinates");
			double x1, y1;
			double x2, y2;
			double length;
			Console.WriteLine("Point1 X Coordinate");
			x1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Point1 Y Coordinate");
			y1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Point2 X Coordinate");
			x2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Point2 Y Coordinate");
			y2 = Convert.ToDouble(Console.ReadLine());
			length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
			Console.WriteLine("Legth of Line is:" + length);
		}
    }
}
