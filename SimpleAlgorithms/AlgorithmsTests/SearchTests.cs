using Algorithms;
using NUnit.Framework;

namespace AlgorithmsTests
{
	class SearchTests
	{
		[Test]
		public void BinarySearchTest()
		{
			int[] data = new int[] { 1, 2, 3, 4, 5, 5, 5, 5, 5, 8, 10 };
			int key = 5;
			int[] result = Search.BinarySearch(data, key);
			int[] expected = new int[] { 3, 9 };
			Assert.That(expected, Is.EqualTo(result), "Binary search (for identical key) is invalid");

			key = 3;
			result = Search.BinarySearch(data, key);
			expected = new int[] { 1, 3 };
			Assert.That(expected, Is.EqualTo(result), "Binary search (for single key) is invalid");

			key = 6;
			result = Search.BinarySearch(data, key);
			expected = new int[] { 8, 9 };
			Assert.That(expected, Is.EqualTo(result), "Binary search (for absent key) is invalid");

			key = 11;
			result = Search.BinarySearch(data, key);
			expected = new int[] { 10, 11 };
			Assert.That(expected, Is.EqualTo(result), "Binary search (for absent key > last item) is invalid");

			key = -9;
			result = Search.BinarySearch(data, key);
			expected = new int[] { -1, 0 };
			Assert.That(expected, Is.EqualTo(result), "Binary search (for absent key < first item) is invalid");


		}
	}
}
