using System;

namespace InterfaceSegregationPrinciple.WithoutIsp
{
	public class JustScanner : IMachine
	{
		public void Fax(string context)
		{
			throw new NotImplementedException();
		}

		public void Print(string context)
		{
			throw new NotImplementedException();
		}

		public void Scan(string context)
		{
			Console.WriteLine("Scan done");
		}
	}
}
