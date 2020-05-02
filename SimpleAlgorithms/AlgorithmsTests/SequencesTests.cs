using Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTests
{

	class SequencesTests
	{
		[Test]
		public void SearchLongestSubsequenceTest()
		{
			List<Char> first = new List<Char> { 's', 'e', 'q', 'u', 'e', 'n', 'c', 'e' };
			List<Char> second = new List<Char> { 's', 'u', 'c', 'c', 'e', 's', 's' };

			//List<Char> first = new List<Char> { 'a', 'b' };
			//List<Char> second =new List<Char> { 'a', 'b' };


			string subSequence;
			Sequences.Bound[] result = Sequences.SearchLongestSubsequence(first, second, out subSequence);
		}

		[Test]
		public void GetLengthOfLongestIncreasingSubsequenceTest()
		{
			List<int> data = new List<int> { 1, 4, 7, 9, 0, 5, 8, 9, 12, 1 };
			int expectedResult = 5;

			int result = Sequences.GetLengthOfLongestIncreasingSubsequence(data);

			Assert.AreEqual(expectedResult, result, "Method GetLengthOfLongestIncreasingSubsequence is invalid");
		}

		[Test]
		public void GetSubsequencesTest()
		{
			List<int> data = new List<int> { 1, 2, 3, 4 };

			List<List<int>> result = Sequences.GetSubsequences(data);

			foreach (var item in result)
			{
				StringBuilder s = new StringBuilder("[");
				for (int j = 0; j < item.Count; j++)
				{

					s.Append(data[j]);
					if (j < item.Count - 1)
					{
						s.Append(",");
					}

				}
				s.Append("]");
				Console.WriteLine(s);
			}
		}

		[Test]
		public void GetPiFunctionTest()
		{
			string s = "abcdabcda";
			int expectedResult = 5;

			int pi = Sequences.GetPiFunction(s);

			Assert.AreEqual(expectedResult, pi, "GetPiFunction is invalid");
		}
	}
}
