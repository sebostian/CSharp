namespace Algorithms.Graphs
{
	public class WeightedEdge : Edge
	{
		public double Weight { get; private set; }
		public WeightedEdge(int vertex1, int vertex2, Direction direction, double weight)
			: base(vertex1, vertex2, direction)
		{
			Weight = weight;
		}
	}
}
