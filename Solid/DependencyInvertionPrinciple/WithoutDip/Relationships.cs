using System.Collections.Generic;

namespace DependencyInvertionPrinciple.WithoutDip
{
	public class Relationships // low-level
	{
		public List<(Person, Relationship, Person)> Relations = new List<(Person, Relationship, Person)>();

		public void AddParentAndChild(Person parent, Person child)
		{
			Relations.Add((parent, Relationship.Parent, child));
			Relations.Add((child, Relationship.Child, parent));
		}
	}
}
