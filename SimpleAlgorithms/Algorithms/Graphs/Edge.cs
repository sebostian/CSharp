namespace Algorithms.Graphs
{
	public class Edge
	{
		public enum Direction
		{
			None,
			Both,
			OneToTwo,
			TwoToOne,
		}

		public int Vertex1 { get; private set; }
		public int Vertex2 { get; private set; }
		public Direction EdgeDirection { get; private set; }

		public Edge(int vertex1, int vertex2, Direction direction)
		{
			Vertex1 = vertex1;
			Vertex2 = vertex2;
			EdgeDirection = direction;
		}
	}
}
