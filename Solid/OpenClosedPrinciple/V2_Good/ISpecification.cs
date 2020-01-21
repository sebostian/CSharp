using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.V2_Good
{
	public interface ISpecification<T>
	{
		bool IsSatisfied(T item);
	}
}
