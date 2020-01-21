namespace OpenClosedPrinciple.V2_Good
{
	public class ColorSpecification : ISpecification<Product>
	{
		private readonly Color color;

		public ColorSpecification(Color color)
		{
			this.color = color;
		}

		public bool IsSatisfied(Product item)
		{
			return item.Color == color;
		}
	}
}
