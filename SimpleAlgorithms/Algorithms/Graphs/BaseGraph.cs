using System.Collections.Generic;

namespace Algorithms.Graphs
{
	public abstract class BaseGraph
	{
		protected readonly Dictionary<int, List<int>> _adjacencyList;

		protected BaseGraph()
		{
			_adjacencyList = new Dictionary<int, List<int>>();
		}

		
	}
}
