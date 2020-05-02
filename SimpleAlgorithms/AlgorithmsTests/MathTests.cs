using NUnit.Framework;
using System.Collections.Generic;

namespace AlgorithmsTests
{
	class MathTests
	{
		[Test]
		public void FibbonaciTest()
		{
			int number = 10;
			int[] expectedResult = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

			int[] result;
			Algorithms.Math.Fibonacci(number, out result);

			Assert.That(expectedResult, Is.EqualTo(result), "Method Fibonacci is invalid");
		}

		[Test]
		public void TrackNumbersTest()
		{
			int number = 8;
			int[] expectedResult = new int[] { 0, 1, 0, 0, 1, 1, 2, 4 };
			List<int> depricated = new List<int> { 2, 3 };
			List<int> result;
			Algorithms.Math.TrackNumbers(number, depricated, out result);

			Assert.That(expectedResult, Is.EqualTo(result), "Method TrackNumbers is invalid");
		}

		[Test]
		public void CalculateMinimumCostTest()
		{
			int number = 7;
			List<decimal> prices = new List<decimal>() { 0m, 1m, 4m, 1m, 6m, 7m, 2m };
			List<decimal> expectedResult = new List<decimal> { 0m, 1m, 4m, 2m, 8m, 9m, 10m };
			List<int> expectedPath = new List<int> { 1, 3, 4, 7 };

			List<decimal> result;
			List<int> path;
			Algorithms.Math.CalculateMinimumCost(number, prices, out result, out path);

			Assert.That(expectedResult, Is.EqualTo(result), "Method CalculateMinimumCost is invalid. Result");
			Assert.That(expectedPath, Is.EqualTo(path), "Method CalculateMinimumCost is invalid. Path");
		}
	}
}
