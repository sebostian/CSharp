using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class Sorting
	{
		#region Merge sorting
		/// <summary>
		/// Sorts unsorted using comparer
		/// </summary>
		/// <typeparam name="T">type of objects</typeparam>
		/// <param name="unsorted">unsorted list</param>
		/// <param name="comparer">comparer</param>
		/// <returns>sorted list</returns>
		public static List<T> MergeSort<T>(List<T> unsorted, Func<T, T, int> comparer)
		{
			int middleIndex = unsorted.Count / 2;
			if (middleIndex == 0)
			{
				return unsorted;
			}

			List<T> leftUnsorted = unsorted.Take(middleIndex).ToList();
			List<T> rightUnsorted = unsorted.Skip(middleIndex).ToList();


			List<T> leftSorted = MergeSort(leftUnsorted, comparer);
			List<T> rightSorted = MergeSort(rightUnsorted, comparer);

			List<T> result;
			Merge(leftSorted, rightSorted, comparer, out result);
			return result;
		}

		/// <summary>
		/// Sorts unsorted usuin comparer
		/// Does not use recursion
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="unsorted"></param>
		/// <param name="comparer"></param>
		/// <returns></returns>
		public static List<T> MergeSortInteractive<T>(List<T> unsorted, Func<T, T, int> comparer)
		{
			List<T> sorted = new List<T>(unsorted.Count);
			Queue<List<T>> queue = new Queue<List<T>>();
			foreach (T item in unsorted)
			{
				queue.Enqueue(new List<T>() { item });
			}

			while (queue.Count > 1)
			{
				List<T> item1 = queue.Dequeue();
				List<T> item2 = queue.Dequeue();
				Merge(item1, item2, comparer, out sorted);
				queue.Enqueue(sorted);
			}

			return sorted;
		}

		/// <summary>
		/// Sorts array unsorted using merge sorting algorithm
		/// </summary>
		/// <param name="unsorted">unsorted array</param>
		/// <returns>sorted array</returns>
		public static int[] MergeSort(int[] unsorted)
		{
			int middleIndex = unsorted.Length / 2;
			if (middleIndex == 0)
			{
				return unsorted;
			}

			int[] leftUnsorted = GetPartOfArray(unsorted, 0, 0, middleIndex);
			int[] rightUnsorted = GetPartOfArray(unsorted, middleIndex, 0, unsorted.Length - middleIndex);


			int[] leftSorted = MergeSort(leftUnsorted);
			int[] rightSorted = MergeSort(rightUnsorted);

			int[] result;
			MergeArrays(leftSorted, rightSorted, out result);
			return result;
		}

		private static int[] GetPartOfArray(int[] wholeArray, int from, int to, int length)
		{
			int[] partOfArray = new int[length];
			Array.Copy(wholeArray, from, partOfArray, to, length);
			return partOfArray;
		}
		/// <summary>
		/// Merges left and right arrays and returns resulted array in result.
		/// Both left and right arrays should be sorted
		/// </summary>
		/// <param name="left">left array</param>
		/// <param name="right">right array</param>
		/// <param name="result">resulted array</param>
		private static void MergeArrays(int[] left, int[] right, out int[] result)
		{
			result = new int[left.Length + right.Length];
			int leftIndex = 0;
			int rightIndex = 0;
			int resultIndex = 0;

			while (leftIndex < left.Length && rightIndex < right.Length)
			{
				if (left[leftIndex] < right[rightIndex])
				{
					result[resultIndex] = left[leftIndex];
					leftIndex++;
				}
				else
				{
					result[resultIndex] = right[rightIndex];
					rightIndex++;
				}

				resultIndex++;
			}

			// in case if there are some elements in any array is necessary to copy the rest of array into result array
			for (int i = leftIndex; i < left.Length; i++)
			{
				result[resultIndex] = left[i];
				resultIndex++;
			}

			for (int i = rightIndex; i < right.Length; i++)
			{
				result[resultIndex] = right[i];
				resultIndex++;
			}
		}

		private static void Merge<T>(List<T> left, List<T> right, Func<T, T, int> comparer, out List<T> result)
		{
			result = new List<T>(left.Count + right.Count);
			int leftIndex = 0;
			int rightIndex = 0;
			int resultIndex = 0;

			while (leftIndex < left.Count && rightIndex < right.Count)
			{
				if (comparer(left[leftIndex], right[rightIndex]) < 0)
				{
					result.Insert(resultIndex, left[leftIndex]);
					leftIndex++;
				}
				else
				{
					result.Insert(resultIndex, right[rightIndex]);
					rightIndex++;
				}

				resultIndex++;
			}

			// in case if there are some elements in any list is necessary to copy the rest of array into result array
			for (int i = leftIndex; i < left.Count; i++)
			{
				result.Insert(resultIndex, left[i]);
				resultIndex++;
			}

			for (int i = rightIndex; i < right.Count; i++)
			{
				result.Insert(resultIndex, right[i]);
				resultIndex++;
			}
		}
		#endregion

		#region Quick Sort
		/// <summary>
		/// Sorts unsorted array using Tom Hoare's algorithm. Uses additional  
		/// </summary>
		/// <param name="unsorted">unsorted array</param>
		/// <param name="sorted">sorted array</param>
		public static void HoareSort(int[] unsorted, out int[] sorted)
		{
			sorted = new int[unsorted.Length];
			if (unsorted.Length == 1)
			{
				sorted[0] = unsorted[0];
				return;
			}

			if (unsorted.Length == 0)
			{
				return;
			}

			int barierValue = unsorted[0];
			int[] less = new int[0];
			int[] equal = new int[0];
			int[] greater = new int[0];

			AddItem(ref equal, barierValue);

			for (int i = 1; i < unsorted.Length; i++)
			{
				if (unsorted[i] < barierValue)
				{
					AddItem(ref less, unsorted[i]);
				}
				else if (unsorted[i] == barierValue)
				{
					AddItem(ref equal, unsorted[i]);
				}
				else
				{
					AddItem(ref greater, unsorted[i]);
				}
			}

			int[] sortedLess;
			HoareSort(less, out sortedLess);
			int[] sortedGreater;
			HoareSort(greater, out sortedGreater);

			int j = 0;
			for (int i = 0; i < sortedLess.Length; i++)
			{
				sorted[j] = sortedLess[i];
				j++;
			}

			for (int i = 0; i < equal.Length; i++)
			{
				sorted[j] = equal[i];
				j++;
			}

			for (int i = 0; i < sortedGreater.Length; i++)
			{
				sorted[j] = sortedGreater[i];
				j++;
			}

		}

		// TODO SB Finish that method
		public static void HoareSortInplace(int[] unsorted, int lo, int hi)
		{
			// We should split array to 2 parts
			// The first part should contains elements that greater then pivot element
			// the second part should contains elements that less or equal pivot element

			if (lo >= hi)
			{
				return;
			}

			int pivotIndex;

			Partition(unsorted, lo, hi, out pivotIndex);

			// Then we heed just sort both parts. pivot item already on place
			HoareSortInplace(unsorted, lo, pivotIndex - 1);
			HoareSortInplace(unsorted, pivotIndex + 1, hi);
		}

		private static void Partition(int[] data, int lo, int hi, out int pivotIndex)
		{
			int left = lo;
			int right = hi - 1;

			pivotIndex = (lo + hi) / 2;
			int pivotValue = data[pivotIndex];

			while (left <= right)
			{
				while (data[left] < pivotValue)
				{
					left++;
				}
				while (data[right] > pivotValue)
				{
					right--;
				}
				if (left <= right)
				{
					Swap(data, left, right);
					left++;
					right--;
				}
			}
			pivotIndex = left;
		}

		private static void Swap(int[] data, int i, int j)
		{
			int tmp = data[i];
			data[i] = data[j];
			data[j] = tmp;
		}

		private static void AddItem(ref int[] arrayToAdd, int value)
		{
			int newSizeArray = arrayToAdd.Length + 1;
			Array.Resize(ref arrayToAdd, newSizeArray);
			arrayToAdd[newSizeArray - 1] = value;

		}
		#endregion
	}
}
