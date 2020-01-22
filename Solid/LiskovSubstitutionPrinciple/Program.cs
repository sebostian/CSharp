using LiskovSubstitutionPrinciple.Calculator.V1;
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
			//DoLspBrokenExample();
			// We should be able to store a reference to an EvenNumbersSumCalculator as a SumCalculator variable 
			// and nothing should change. But it isn't true.
			DoCalculatorExampleNotGood();
			Console.WriteLine("----------------------");
			// Now we can replace EvenNumbersSumCalculator as a SumCalculator variable
			DoCalculatorExampleBetter();
		}

		private static void DoCalculatorExampleBetter()
		{
			var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

			Calculator.V2.SumCalculator sum = new Calculator.V2.SumCalculator(numbers);
			Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

			Console.WriteLine();

			Calculator.V2.SumCalculator evenSum = new Calculator.V2.EvenNumbersSumCalculator(numbers);
			Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
		}

		private static void DoCalculatorExampleNotGood()
		{
			var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

			SumCalculator sum = new SumCalculator(numbers);
			Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

			Console.WriteLine("");

			EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
			Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
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
