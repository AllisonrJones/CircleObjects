using System;
namespace CircleObject
{
	public class Circle
	{

		double area;
		double circumference;
		double formattedArea;
		double formattedCircumference;

		public double radius { get; set; }

		public Circle(double Radius)
		{
			this.radius = Radius;
	
        }
		private double FormatNumber(double Radius)
		{

			return Math.Round(Radius, 2);
            
		}
		public double CalculateCircumference(double Radius)
		{
			return circumference = 2 * (Math.PI * Radius);
		}
		public double CalculateFormattedCircumference(double Radius, Int32 y)
		{
			return  Math.Round(Radius, 2);
		}
		public double CalculateArea(double Radius)
		{
			return area=  Math.PI * Math.Pow(Radius, 2);

		
		}
		public double CalculateFormattedArea(double Radius, Int32 y)
		{
			return  Math.Round(Radius, 2);
		}
		
	}
}

//Console.WriteLine($"The radius is {radius}");
//			Console.WriteLine();
//			Console.WriteLine($"Circumference: {CalculateFormattedCircumference}");
//			Console.WriteLine();
//			Console.WriteLine($"Area: {CalculateFormattedArea}");
//			Console.Clear();