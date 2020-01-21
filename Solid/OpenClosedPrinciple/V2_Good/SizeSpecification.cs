namespace OpenClosedPrinciple.V2_Good
{
	public class SizeSpecification : ISpecification<Product>
	{
		private readonly Size size;
		public SizeSpecification(Size size)
		{
			this.size = size;
		}

		public bool IsSatisfied(Product item)
		{
			return item.Size == size;
		}
	}
}
