using System.Collections.Generic;

namespace DependencyInvertionPrinciple.WithDip
{
	public interface IRelationshipBrowser
	{
		IEnumerable<Person> FindAllChildrenOf(string name);
	}
}

