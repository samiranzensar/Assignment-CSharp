using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConAssign
{
	abstract class Quadrilateral
	{
		public int length;
		public abstract int Area();
		
	}

	class Square : Quadrilateral
	{
		public Square(int x)
		{
			length = x;
		}
		public override int Area()
		{
			return length*length;
		}
	}

	class Rectangle : Quadrilateral
	{
		public int breadth;

		public bool IsSquare 
		{

			get
			{
				if (breadth == length)
				{
					return true;

				}
				return false;
			}
		}
		public Rectangle(int x, int y)
		{
			breadth = y;
			length = x;
		}
		public override int Area()
		{
			return (breadth * length);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Square sq = new Square(5);
			Rectangle rect = new Rectangle(4,6);
			int sqareArea = sq.Area();
			int reactangleArea = rect.Area();

			if (sqareArea > reactangleArea)
			{
				Console.WriteLine("Square area is greater than Rectangle area");
			}
			else
			{
				Console.WriteLine("Square area is not greater than Rectangle area");
			}
			if (rect.IsSquare)
			{
				Console.WriteLine("Reactangle is a square");
			}

		}
	}
}

