using Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AlgorithmsTests
{
	class BackpackTests
	{
		[Test]
		public void FillTest()
		{
			int capacity = 4;
			List<Tuple<string, decimal, decimal>> things = new List<Tuple<string, decimal, decimal>>()
			{
				Tuple.Create("Guitar", 1m, 1500m),
				Tuple.Create("Stereo", 4m, 3000m),
				Tuple.Create("Laptop", 3m, 2000m),
			};

			decimal expectedResult = 3500m;

			decimal actualResult = Backpack.Fill(capacity, things);

			Assert.AreEqual(expectedResult, actualResult, "Backpack.Fill is invalid");
		}
	}
}
