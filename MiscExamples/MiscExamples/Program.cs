using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiscExamples
{
	class Program
	{
		static void Main(string[] args)
		{
			//Diffrence();
			CheckInc();
		}

		private static void CheckInc()
		{
			int i = 0;
			++i;
			if ((i & 0xFFF) == 0)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
		}

		static void Diffrence()
		{
			// Create the IEnumerable data sources.  
			string[] before = System.IO.File.ReadAllLines(@"before.txt");
			string[] after = System.IO.File.ReadAllLines(@"after.txt");

			// Create the query. Note that method syntax must be used here.  
			IEnumerable<string> differenceQuery = before.Except(after);

			// Execute the query.  
			Console.WriteLine("The following lines are in before.txt but not after.txt. Deleted");
			foreach (string s in differenceQuery)
			{
				Console.WriteLine(s);
			}

			IEnumerable<string> differenceQuery2 = after.Except(before);
			Console.WriteLine("The following lines are in after.txt but not before.txt. Added");
			foreach (string s in differenceQuery2)
			{
				Console.WriteLine(s);
			}

			IEnumerable<string> differenceQuery3 = after.Intersect(before);
			Console.WriteLine("The following lines are in the both files. Updated");
			foreach (string s in differenceQuery3)
			{
				Console.WriteLine(s);
			}

			// Keep the console window open in debug mode.  
			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}

		static void CheckFlag()
		{
			int value    = 0x00001010;
			int checkBit = 0x00000010;
			bool hasBit = (value & checkBit) == checkBit;

			Console.WriteLine(hasBit);
			Console.ReadLine();
		}

		private static void SerializeAnonimousClass()
		{

			//foreach (var i in new List<int>() { 1, 2, 3, 4, 5 })
			//{
			var c = new { X = new List<string> { "one", "two" }, Y = 100, Name = "Test01" };
			//}
			string s = JsonConvert.SerializeObject(c);
			Console.WriteLine(s);

			var c2 = JsonConvert.DeserializeObject(s);
			Console.ReadLine();
		}
	}
}
