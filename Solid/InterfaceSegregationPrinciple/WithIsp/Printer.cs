using System;

namespace InterfaceSegregationPrinciple.WithIsp
{
	public class Printer : IPrinter
	{
		public void Print(string context)
		{
			Console.WriteLine("Print done");
		}
	}
}
