using System.Collections.Generic;

namespace OpenClosedPrinciple.V2_Good
{
	public interface IFilter<T>
	{
		IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
	}
}
