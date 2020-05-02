using System.Collections.Generic;

namespace Algorithms
{
	public class Math
	{
		/// <summary>
		/// Calculates Fibonacci sequence
		/// such that each number is the sum of preciding ones, starting from 0 and 1
		/// </summary>
		/// <param name="number">count of sequence</param>
		/// <param name="result">sequence</param>
		public static void Fibonacci(int number, out int[] result)
		{
			result = new int[number];
			result[0] = 0;
			result[1] = 1;
			for (int i = 2; i < number; i++)
			{
				result[i] = result[i - 2] + result[i - 1];
			}
		}

		/// <summary>
		/// Calculates number of possible and valid jumps for achiving goal point
		/// Possible jumps: +1, +2, +3
		/// </summary>
		/// <param name="goalPoint">Point that has to be achieved</param>
		/// <param name="deprecatedPoints">Point that should not be visited</param>
		/// <param name="result"></param>
		public static void TrackNumbers(int goalPoint, List<int> deprecatedPoints, out List<int> result)
		{
			result = new List<int>(goalPoint)
			{
				0,
				deprecatedPoints.Contains(1) ? 0 : 1,
				deprecatedPoints.Contains(2) ? 0 : 1
			};

			for (int i = 3; i < goalPoint; i++)
			{
				if (!deprecatedPoints.Contains(i))
				{
					result.Add(result[i - 3] + result[i - 2] + result[i - 1]);
				}
				else
				{
					result.Add(0);
				}
			}
		}
		/// <summary>
		/// Calculates minimum cost for achiving goalPoint
		/// Possible jumps are +1, +2
		/// </summary>
		/// <param name="goalPoint"></param>
		/// <param name="prices">Price of each point</param>
		/// <param name="result">Costs of achiving all points</param>
		/// <param name="path">Path to GoalPoint with minimum cost</param>
		public static void CalculateMinimumCost(int goalPoint, List<decimal> prices, out List<decimal> result, out List<int> path)
		{
			result = new List<decimal>(goalPoint)
			{
				0m,
				prices[1]
			};

			path = new List<int>(goalPoint);

			for (int i = 2; i < goalPoint; i++)
			{
				if (i > 2)
				{

					int pathPoint = result[i - 2] > result[i - 1] ? i - 1 : i - 2;
					if (!path.Contains(pathPoint))
					{
						path.Add(pathPoint);
					}
				}

				result.Add(System.Math.Min(result[i - 2], result[i - 1]) + prices[i]);
			}

			path.Add(goalPoint);
		}
	}
}
