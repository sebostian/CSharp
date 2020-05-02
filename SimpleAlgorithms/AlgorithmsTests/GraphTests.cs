using Algorithms;
using Algorithms.Graphs;
using NUnit.Framework;
using System.Collections.Generic;

namespace AlgorithmsTests
{
	class GraphTests
	{
		[Test]
		public void BaseOperations()
		{
			Graph g = new Graph();
			g.FillGraph(new List<Edge> {
				new Edge(1,2, Edge.Direction.Both),
				new Edge(2,3, Edge.Direction.Both),
				new Edge(1,3, Edge.Direction.Both),
				new Edge(3,4, Edge.Direction.Both),
			});

			List<int> actual = g.GetNeighbours(1);
			Assert.That(new List<int>() { 2, 3 }, Is.EquivalentTo(actual), "Invalid GetNeighbours(1)");

			actual = g.GetNeighbours(5);
			Assert.That(new List<int>(), Is.EquivalentTo(actual), "Invalid GetNeighbours(5)");

			List<int> actualVertexes = g.GetVertexes();

			Assert.That(new List<int>() { 1, 2, 3, 4 }, Is.EquivalentTo(actualVertexes), "Invalid GetVertexes()");

			Assert.AreEqual(4, g.NumberOfVertex, "Invalid number of vertex");
			Assert.AreEqual(4, g.NumberOfEdge, "Invalid number of edges");
		}

		[Test]
		public void DephtFirstSearchTest()
		{
			Graph g = new Graph();
			g.FillGraph(new List<Edge> {
				new Edge(0,1, Edge.Direction.OneToTwo),
				new Edge(2,3, Edge.Direction.Both),
				new Edge(1,3, Edge.Direction.Both),
				new Edge(2,1, Edge.Direction.TwoToOne),
				new Edge(3,4, Edge.Direction.Both),
			});

			List<int> visited;
			GraphAlgorithms.DepthFirstSearch(g, out visited);
		}

		[Test]
		public void BreadthFirstSearchTest()
		{
			Graph g = CreateGraph();

			Dictionary<int, int> distances;
			GraphAlgorithms.BreathFirstSearch(g, 0, out distances);

			Assert.AreEqual(0, distances[0], "Distance from 0");
			Assert.AreEqual(1, distances[11], "Distance from 11");
			Assert.AreEqual(2, distances[6], "Distance from 6");
			Assert.AreEqual(3, distances[5], "Distance from 5");
		}

		[Test]
		public void GetShortestPathTest()
		{
			Graph g = CreateGraph();

			List<int> path;
			GraphAlgorithms.GetShortestPath(g, 0, 5, out path);


		}

		private Graph CreateGraph()
		{
			Graph g = new Graph();
			g.FillGraph(new List<Edge> {
				new Edge(0,1, Edge.Direction.Both),
				new Edge(0,12, Edge.Direction.Both),
				new Edge(0,11, Edge.Direction.Both),
				new Edge(0,10, Edge.Direction.Both),

				new Edge(1,7, Edge.Direction.Both),

				new Edge(7,13, Edge.Direction.Both),

				new Edge(13,5, Edge.Direction.Both),

				new Edge(5,8, Edge.Direction.Both),

				new Edge(8,12, Edge.Direction.Both),

				new Edge(11,12, Edge.Direction.Both),

				new Edge(11,9, Edge.Direction.Both),

				new Edge(11,3, Edge.Direction.Both),

				new Edge(11,14, Edge.Direction.Both),

				new Edge(10,4, Edge.Direction.Both),

				new Edge(6,10, Edge.Direction.Both),

				new Edge(6,4, Edge.Direction.Both),

				new Edge(6,2, Edge.Direction.Both),

			});

			return g;
		}

	}
}
