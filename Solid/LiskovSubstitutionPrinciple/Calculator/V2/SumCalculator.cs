using System.Linq;

namespace LiskovSubstitutionPrinciple.Calculator.V2
{
	public class SumCalculator
	{
		protected readonly int[] _numbers;

		public SumCalculator(int[] numbers)
		{
			_numbers = numbers;
		}

		public virtual int Calculate() => _numbers.Sum();
	}
}
