using System;

namespace InterfaceSegregationPrinciple.WithIsp
{
	public class Scan : IScanner
	{
		public void Scaningn(string context)
		{
			Console.WriteLine("Scan done");
		}
	}
}
