using System.Linq;

namespace LiskovSubstitutionPrinciple.Calculator.V1
{
	public class EvenNumbersSumCalculator : SumCalculator
	{
		public EvenNumbersSumCalculator(int[] numbers)
				: base(numbers)
		{
		}

		public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
	}
}
