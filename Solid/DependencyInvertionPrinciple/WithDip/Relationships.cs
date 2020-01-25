using System.Collections.Generic;
using System.Linq;

namespace DependencyInvertionPrinciple.WithDip
{
	public class Relationships : IRelationshipBrowser // low-level
	{
		// no longer public!
		private readonly List<(Person, Relationship, Person)> _relations = 
			new List<(Person, Relationship, Person)>();

		public IEnumerable<Person> FindAllChildrenOf(string name)
		{
			return _relations
				.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent)
				.Select(r => r.Item3);
		}
	}
}
