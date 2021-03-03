using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labs
{
	public class Triangle : Shape
	{
		private double a,b,c;
		public Triangle(double a,double b,double c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			xPos = DataModel.getNewXPos();
			yPos = DataModel.getNewYPos();
		}

		public override double getArea()
		{
			return a * b * c;
		}

		public override double getPerimeter()
		{
			return a + b + c; 
		}

		public override void printData()
		{
			Console.WriteLine();
			Console.WriteLine("My type: " + this.GetType());
			Console.WriteLine("Size of a side 'a' = " + a);
			Console.WriteLine("Size of a side 'b'= " + b);
			Console.WriteLine("Size of a side 'c'= " + c);
			Console.WriteLine("X position = " + xPos);
			Console.WriteLine("Y position = " + yPos);
		}
	}
}

