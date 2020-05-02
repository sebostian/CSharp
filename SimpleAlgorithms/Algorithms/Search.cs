namespace Algorithms
{
	public class Search
	{
		/// <summary>
		/// Search key in data. Array data has to be sorted. 
		/// We are searching left boundary (previous index before key)
		/// and right boundary (ne) 
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="key">key - what we are searching</param>
		/// <returns>left boundary in 0 index, right boundary in 1 index</returns>
		public static int[] BinarySearch(int[] data, int key)
		{
			int[] result = new int[2];
			result[0] = GetLeftBoundary(data, key);
			result[1] = GetRightBoundary(data, key);
			return result;
		}

		private static int GetRightBoundary(int[] data, int key)
		{
			int left = -1;
			int right = data.Length;
			while (right - left > 1)
			{
				int middle = (left + right) / 2;

				if (data[middle] <= key)
				{
					left = middle;
				}
				else
				{
					right = middle;
				}
			}
			return right;
		}

		private static int GetLeftBoundary(int[] data, int key)
		{
			int left = -1;
			int right = data.Length;
			while (right - left > 1)
			{
				int middle = (left + right) / 2;

				if (data[middle] < key)
				{
					left = middle;
				}
				else
				{
					right = middle;
				}
			}
			return left;
		}
	}
}
