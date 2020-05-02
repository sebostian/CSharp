using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graphs
{
	// Implemented using adjacency list
	public class Graph : BaseGraph
	{
		// Fills graph by using edges
		public void FillGraph(List<Edge> edges)
		{
			foreach (Edge item in edges)
			{
				// Add vetex1
				if (!_adjacencyList.ContainsKey(item.Vertex1))
				{
					_adjacencyList.Add(item.Vertex1, new List<int> { item.Vertex2 });
				}
				else
				{
					if (!_adjacencyList[item.Vertex1].Contains(item.Vertex2))
					{
						_adjacencyList[item.Vertex1].Add(item.Vertex2);
					}
				}
				// Add vertex2
				if (!_adjacencyList.ContainsKey(item.Vertex2))
				{
					_adjacencyList.Add(item.Vertex2, new List<int> { item.Vertex1 });
				}
				else
				{
					if (!_adjacencyList[item.Vertex2].Contains(item.Vertex1))
					{
						_adjacencyList[item.Vertex2].Add(item.Vertex1);
					}
				}
			}

			NumberOfEdge = CalculateNumberOfEdges();
		}

		public int NumberOfVertex { get { return _adjacencyList.Keys.Count; } }
		public int NumberOfEdge { get; private set; }

		public List<int> GetVertexes()
		{
			return _adjacencyList.Keys.ToList();
		}

		public List<int> GetNeighbours(int vertex)
		{
			List<int> neighbours;
			if (!_adjacencyList.TryGetValue(vertex, out neighbours))
			{
				neighbours = new List<int>();
			}
			return neighbours;
		}

		#region Private methods
		private int CalculateNumberOfEdges()
		{
			int freedom = 0;
			foreach (int vertex in _adjacencyList.Keys)
			{
				freedom += _adjacencyList[vertex].Count;
			}
			return freedom / 2;
		}
		#endregion
	}
}
