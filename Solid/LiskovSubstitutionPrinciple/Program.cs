using LiskovSubstitutionPrinciple.LspBroken;
using System;

namespace LiskovSubstitutionPrinciple
{
	// Liskov Substitution Principle states that if 
	// an interface takes an object of type Parent, it should equally take an object
	// of type Child with out anything breaking.

	class Program
	{
		static void Main(string[] args)
		{
			DoLspBrokenExample();
		}

		private static void DoLspBrokenExample()
		{
			var r = new Rectangle(2, 3);
			UseRectangle(r);

			var s = new Square(5);
			UseRectangle(s);
		}

		public static void UseRectangle(Rectangle r)
		{
			r.Height = 10;
			Console.WriteLine($"Expected area of {10 * r.Width}, got {r.Area}");
		}
	}
}
