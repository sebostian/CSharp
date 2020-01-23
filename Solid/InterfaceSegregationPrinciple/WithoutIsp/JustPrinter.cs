using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.WithoutIsp
{
	public class JustPrinter : IMachine
	{
		public void Fax(string context)
		{
			throw new NotImplementedException();
		}

		public void Print(string context)
		{
			Console.WriteLine("Print Done");
		}

		public void Scan(string context)
		{
			throw new NotImplementedException();
		}
	}
}
