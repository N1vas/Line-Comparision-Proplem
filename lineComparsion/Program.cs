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
			double length1;
			Console.WriteLine("Point1 X Coordinate of line 1");
			x1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Point1 Y Coordinate of line 1");
			y1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Point2 X Coordinate of line 1");
			x2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Point2 Y Coordinate of line 1");
			y2 = Convert.ToDouble(Console.ReadLine());
			length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
			Console.WriteLine("Length of Line1 is:" + length1);
			double m1, n1;
			double m2, n2;
			double length2;
			Console.WriteLine("Point1 X Coordinate of line 1");
			m1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Point1 Y Coordinate of line 1");
			n1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Point2 X Coordinate of line 1");
			m2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Point2 Y Coordinate of line 1");
			n2 = Convert.ToDouble(Console.ReadLine());
			length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
			Console.WriteLine("Legth of Line is:" + length1);
			length2 = Math.Sqrt(((m2 - m1) * (m2 - m1)) + ((n2 - n1) * (n2 - n1)));
			Console.WriteLine("Length of Line2 is:" + length2);
			if (length1 == length2)
			{
				Console.WriteLine("Lines are of equal length");
			}
			else if (length1 > length2)
			{
				Console.WriteLine("Line1 is bigger than Line2");
			}
			else
			{
				Console.WriteLine("Line2 is bigger than Line1");
			}
		}
    }
}
