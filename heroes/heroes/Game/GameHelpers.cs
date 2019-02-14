using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Game
{
	static class GameHelpers
	{
		private static Random _random = new Random();
		public static int GetRandomValue(int maxValue)
		{
			return _random.Next(1, maxValue);
		}
	}
}
