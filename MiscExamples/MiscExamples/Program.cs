using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscExamples
{
	class Program
	{
		static void Main(string[] args)
		{
			int value    = 0x00001010;
			int checkBit = 0x00000010;
			bool hasBit = (value & checkBit) == checkBit;

			Console.WriteLine(hasBit);
			Console.ReadLine();
		}
	}
}
