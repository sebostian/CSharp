using System;

namespace InterfaceSegregationPrinciple.WithIsp
{
	public class MultifunctionalPrinter : IPrinter, IScanner, IFax
	{
		public void Fax(string context)
		{
			Console.WriteLine("Fax done");
		}

		public void Print(string context)
		{
			Console.WriteLine("Print done");
		}

		public void Scaningn(string context)
		{
			Console.WriteLine("Scan done");
		}
	}
}
