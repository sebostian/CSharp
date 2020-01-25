using System;
using System.Linq;

namespace DependencyInvertionPrinciple.WithoutDip
{
	// Bad approach. Dip is violated. A high- level 
	// module Research directly depends on the low-level module Relationships.
	public class Research
	{
		public Research(Relationships relationships)
		{
			// high-level: find all of John's children
			var relations = relationships.Relations;
			foreach (var r in relations.Where(x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent))
			{
				Console.WriteLine($"John has a child called {r.Item3.Name}");
			}
		}
	}
}