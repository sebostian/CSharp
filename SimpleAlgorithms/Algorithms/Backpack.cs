using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class Backpack
	{
		// TODO SB will finish
		/// <summary>
		/// Calculates max cost of things that fit to the backpack
		/// </summary>
		/// <param name="capatity"></param>
		/// <param name="things"></param>
		/// <returns>Max cost of things that fit to the backpack</returns>
		public static decimal Fill(int capatity, List<Tuple<string, decimal, decimal>> things)
		{
			decimal result = 0;
			int thingIndex = 1;

			decimal[,] maxCost = new decimal[capatity + 1, things.Count + 1];
			for (int j = 0; j <= things.Count; j++)
			{
				decimal weightOfThing = things[j + thingIndex].Item2;
				decimal costOfThing = things[j + thingIndex].Item3;

				for (int i = 0; i <= capatity; i++)
				{
					int restWeigth = (int)(i - weightOfThing);

					decimal c1 = 0, c2 = 0;


					if (restWeigth > 0)
					{
						c1 = costOfThing + maxCost[restWeigth, i - 1];
					}
					else
					{
						c2 = maxCost[j - 1, i];
					}

					maxCost[i, j] = System.Math.Max(c1, c2);

				}
			}
			return result;
		}
	}
}
