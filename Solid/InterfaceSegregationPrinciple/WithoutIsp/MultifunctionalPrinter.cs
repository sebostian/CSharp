using System;

namespace InterfaceSegregationPrinciple.WithoutIsp
{
	public class MultifunctionalPrinter : IMachine
	{
		public void Fax(string context)
		{
			Console.WriteLine("Fax done");
		}

		public void Print(string context)
		{
			Console.WriteLine("Print done");
		}

		public void Scan(string context)
		{
			Console.WriteLine("Scan done");
		}
	}
}
