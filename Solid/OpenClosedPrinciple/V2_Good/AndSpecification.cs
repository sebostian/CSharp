namespace OpenClosedPrinciple.V2_Good
{
	public class AndSpecification<T> : ISpecification<T>
	{
		private readonly ISpecification<T> first;
		private readonly ISpecification<T> second;

		public AndSpecification(ISpecification<T> first, ISpecification<T> second)
		{
			this.first = first;
			this.second = second;
		}

		public bool IsSatisfied(T item)
		{
			return first.IsSatisfied(item) && second.IsSatisfied(item);
		}
	}
}
