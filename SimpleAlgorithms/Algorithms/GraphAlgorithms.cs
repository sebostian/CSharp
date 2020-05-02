using Algorithms.Graphs;
using System.Collections.Generic;

namespace Algorithms
{
	public class GraphAlgorithms
	{
		public static void DepthFirstSearch(Graph graph, out List<int> visited)
		{
			visited = new List<int>();
			List<int> vertexes = new List<int>();
			int startVertex = 1;
			Dfs(startVertex, graph, visited);

		}

		public static void BreathFirstSearch(Graph graph, int startVertex, out Dictionary<int, int> distances)
		{
			distances = new Dictionary<int, int>
			{
				[startVertex] = 0
			};

			Queue<int> queue = new Queue<int>();
			queue.Enqueue(startVertex);
			int currentVertex;

			while (queue.Count > 0)
			{
				currentVertex = queue.Dequeue();
				foreach (int vertex in graph.GetNeighbours(currentVertex))
				{
					if (!distances.ContainsKey(vertex))
					{
						queue.Enqueue(vertex);
						distances[vertex] = distances[currentVertex] + 1;
					}
				}
			}
		}

		// Finds and returns the shortest path from startVertex to endVertex
		public static void GetShortestPath(Graph graph, int startVertex, int endVertex, out List<int> path)
		{
			Dictionary<int, int> parents = new Dictionary<int, int>()
			{
				[startVertex] = 0
			};


			path = new List<int>();

			Dictionary<int, int> distances = new Dictionary<int, int>
			{
				[startVertex] = 0
			};

			Queue<int> queue = new Queue<int>();
			queue.Enqueue(startVertex);
			int currentVertex;

			while (queue.Count > 0)
			{
				currentVertex = queue.Dequeue();
				foreach (int vertex in graph.GetNeighbours(currentVertex))
				{


					if (!distances.ContainsKey(vertex))
					{
						parents.Add(vertex, currentVertex);
						queue.Enqueue(vertex);
						distances[vertex] = distances[currentVertex] + 1;
					}
				}
			}

			int ver = endVertex;
			while (ver != startVertex)
			{
				path.Add(parents[ver]);
				ver = parents[ver];
			}
			path.Reverse();
		}

		public static void SortByBynaryTree(IEnumerable<int> unsorted, IEnumerable<int> sorted)
		{
			Graph tree = new Graph();
			foreach (var item in unsorted)
			{

			}
		}

		#region Private methods
		private static void Dfs(int startVertex, Graph graph, List<int> visited)
		{
			visited.Add(startVertex);
			foreach (int vertex in graph.GetNeighbours(startVertex))
			{
				if (!visited.Contains(vertex))
				{
					Dfs(vertex, graph, visited);
				}
			}
		}

		#endregion
	}
}
