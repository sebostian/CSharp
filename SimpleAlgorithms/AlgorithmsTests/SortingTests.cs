using Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AlgorithmsTests
{
	public class SortingTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void MergeSortTest()
		{
			int[] unsorted = new int[] { 4, 3, 6, 9, 1, 0, 2 };

			int[] expectedSorted = new int[] { 0, 1, 2, 3, 4, 6, 9 };
			int[] sorted = Sorting.MergeSort(unsorted);

			Assert.That(sorted, Is.EqualTo(expectedSorted), "MergeSort is invalid");
		}

		[Test]
		public void HoareSortTest()
		{
			int[] unsorted = new int[] { 4, 3, 6, 9, 1, 0, 2 };

			int[] expectedSorted = new int[] { 0, 1, 2, 3, 4, 6, 9 };
			int[] sorted;
			Sorting.HoareSort(unsorted, out sorted);

			Assert.That(sorted, Is.EqualTo(expectedSorted), "HoareSort is invalid");
		}

		[Test]
		public void HoareSortInplaceTest()
		{
			int[] unsorted = new int[] { 4, 3, 9, 6, 1, 0, 2 };

			int[] expectedSorted = new int[] { 0, 1, 2, 3, 4, 6, 9 };
			Sorting.HoareSortInplace(unsorted, 0, unsorted.Length);

			Assert.That(unsorted, Is.EqualTo(expectedSorted), "HoareSort (inplace) is invalid");
		}

		[DebuggerDisplay("Name: {Name} Sex: {Sex}")]
		private class People : IEquatable<People>
		{
			public enum SexValues
			{
				Famale = 0,
				Male = 1
			}

			public People(string name, SexValues sex)
			{
				Name = name;
				Sex = sex;
			}

			public SexValues Sex { get; protected set; }
			public string Name { get; protected set; }

			public bool Equals(People other)
			{
				if (other == null)
				{
					throw new ArgumentException("Invalid other object");
				}
				return this.Name.Equals(other.Name, StringComparison.CurrentCultureIgnoreCase) && this.Sex.Equals(other.Sex);
			}
		}

		[Test]
		public void MergeSortGenericTest()
		{

			List<People> unsorted = new List<People>
			{
				new People("Abby", People.SexValues.Famale),
				new People("Jon", People.SexValues.Male),
				new People("Piter", People.SexValues.Male),
				new People("Anna", People.SexValues.Famale),
				new People("Bob", People.SexValues.Male),
				new People("Olga", People.SexValues.Famale),
			};

			List<People> expectedSorted = new List<People>
			{
				new People("Bob", People.SexValues.Male),
				new People("Jon", People.SexValues.Male),
				new People("Piter", People.SexValues.Male),
				new People("Abby", People.SexValues.Famale),
				new People("Anna", People.SexValues.Famale),
				new People("Olga", People.SexValues.Famale),
			};


			List<People> sorted = Sorting.MergeSort(unsorted, (x, y) =>
			{
				// Should be male first are sorted by Name
				// then female are sorted be Name
				if (x.Sex != y.Sex)
				{
					return y.Sex.CompareTo(x.Sex);
				}

				return string.Compare(x.Name, y.Name, System.StringComparison.CurrentCultureIgnoreCase);
			});

			Assert.That(sorted, Is.EqualTo(expectedSorted), "MergeSort is invalid");
		}

		[Test]
		public void MergeSortInteractiveTest()
		{

			List<People> unsorted = new List<People>
			{
				new People("Abby", People.SexValues.Famale),
				new People("Jon", People.SexValues.Male),
				new People("Piter", People.SexValues.Male),
				new People("Anna", People.SexValues.Famale),
				new People("Bob", People.SexValues.Male),
				new People("Olga", People.SexValues.Famale),
				new People("Mike", People.SexValues.Male),
			};

			List<People> expectedSorted = new List<People>
			{
				new People("Bob", People.SexValues.Male),
				new People("Jon", People.SexValues.Male),
				new People("Mike", People.SexValues.Male),
				new People("Piter", People.SexValues.Male),
				new People("Abby", People.SexValues.Famale),
				new People("Anna", People.SexValues.Famale),
				new People("Olga", People.SexValues.Famale),
			};


			List<People> sorted = Sorting.MergeSortInteractive(unsorted, (x, y) =>
			{
				// Should be male first are sorted by Name
				// then female are sorted be Name
				if (x.Sex != y.Sex)
				{
					return y.Sex.CompareTo(x.Sex);
				}

				return string.Compare(x.Name, y.Name, System.StringComparison.CurrentCultureIgnoreCase);
			});

			Assert.That(sorted, Is.EqualTo(expectedSorted), "MergeSort (interactive) is invalid");
		}
	}
}