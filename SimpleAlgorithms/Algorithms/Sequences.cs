using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class Sequences
	{
		public class BinGenerator
		{
			private List<List<int>> _bin = new List<List<int>>();

			public List<List<int>> Generate(int length)
			{
				_bin.Clear();
				Generate(length, new List<int>());
				return _bin;
			}

			private void Generate(int length, List<int> prefix)
			{
				if (length == 0)
				{
					_bin.Add(new List<int>(prefix));
					return;
				}

				prefix.Add(0);
				Generate(length - 1, prefix);
				prefix.RemoveAt(prefix.Count - 1);

				prefix.Add(1);
				Generate(length - 1, prefix);
				prefix.RemoveAt(prefix.Count - 1);
			}
		}

		public static List<List<int>> GetSubsequences(List<int> data)
		{
			BinGenerator binGenerator = new BinGenerator();
			List<List<int>> bin = binGenerator.Generate(data.Count);

			List<List<int>> result = new List<List<int>>();

			foreach (List<int> item in bin)
			{
				List<int> line = new List<int>();

				for (int j = 0; j < item.Count; j++)
				{
					if (item[j] == 1)
					{
						line.Add(data[j]);
					}
				}

				result.Add(line);
			}

			return result;
		}

		/// <summary>
		/// Calculates the longest increasing subsequence
		/// Use dynamic programming
		/// </summary>
		/// <param name="data"></param>
		/// <returns>Length of the longest increasing subsequence</returns>
		public static int GetLengthOfLongestIncreasingSubsequence(List<int> data)
		{
			int result = 0;
			List<int> lengths = new List<int>(data.Count);

			lengths.Add(0);

			for (int i = 0; i < data.Count; i++)
			{
				//if ()
			}

			return result;

		}

		/// <summary>
		/// Finds pi function for string
		/// </summary>
		/// <param name="s"></param>
		/// <returns>pi function</returns>
		public static int GetPiFunction(string s)
		{
			int length = s.Length;

			List<int> pi = new List<int>(length); // we save here pi-function
			for (int i = 0; i < length; i++)
			{
				pi.Add(0);
			}

			for (int i = 1; i < length; i++)
			{
				int p = pi[i - 1];

				while (p > 0 && (s[i] != s[p]))
				{
					p = pi[p + 1];
				}

				if (s[i] == s[p])
				{
					p++;
				}

				pi[i] = p;
			}

			return pi[length - 1];
		}



		public class Bound
		{
			public int Lo { get; set; }
			public int Hi { get; set; }
		}

		// TODO SB will finish
		/// <summary>
		/// Finds the largest commom subsequnce from two sequences
		/// Use the dynamic programming
		/// </summary>
		/// <param name="first">The first suquence</param>
		/// <param name="second">The second sequence</param>
		/// <param name="subSequence">Founded longest subsequence</param>
		/// <returns>Bounds of subsequences</returns>
		public static Bound[] SearchLongestSubsequence(List<Char> first, List<Char> second, out string subSequence)
		{
			subSequence = string.Empty;
			Bound[] result = new Bound[2];

			int[,] f = new int[first.Count + 1, second.Count + 1];

			for (int i = 1; i < f.GetLength(0); i++)
			{
				for (int j = 1; j < f.GetLength(1); j++)
				{
					if (first[i - 1].Equals(second[j - 1]))
					{
						f[i, j] = f[i - 1, j - 1] + 1;
					}
					else
					{
						f[i, j] = System.Math.Max(f[i - 1, j], f[i, j - 1]);
					}
				}
			}

			return result;
		}

		// TODO SB will finish
		/// <summary>
		/// Generates permutations
		/// Use the recursion
		/// </summary>
		/// <param name="countOfNumbers"></param>
		/// <param name="countOfPosition"></param>
		/// <param name="prefix"></param>
		public static void GeneratePermutations(int countOfNumbers, int countOfPosition, List<int> prefix)
		{
			if (countOfPosition == 0)
			{
				Console.WriteLine(MakeString(prefix));
				return;
			}

			for (int i = 1; i <= countOfNumbers; i++)
			{
				if (!prefix.Contains(i))
				{
					prefix.Add(i);
					GeneratePermutations(countOfNumbers, countOfPosition - 1, prefix);
					prefix.RemoveAt(prefix.Count - 1);
				}
			}
		}

		public static void Gen(int n, int m, List<int> prefix)
		{
			if (m == 0)
			{
				Console.WriteLine(MakeString(prefix));
				return;
			}

			for (int i = 0; i < n; i++)
			{

				prefix.Add(i);
				Gen(n, m - 1, prefix);
				prefix.RemoveAt(prefix.Count - 1);
			}

		}

		private static string MakeString(List<int> prefix)
		{
			StringBuilder result = new StringBuilder();
			foreach (var x in prefix)
			{
				result.Append(x);
			}
			return result.ToString();
		}
	}
}
