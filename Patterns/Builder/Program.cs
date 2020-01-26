using Builder.Example1;
using System;

namespace Builder
{
	// The Builder pattern is concerned with the creation of complicated objects;
	// that is, objects that cannot be built up in a single-line constructor call.
	class Program
	{
		static void Main(string[] args)
		{
			DoTestExample1();
		}

		private static void DoTestExample1()
		{
			var words = new[] { "hello", "world" };
			var tag = new HtmlElement("ul", null);
			foreach (var word in words)
			{
				tag.Elements.Add(new HtmlElement("li", word));
			}

			Console.WriteLine(tag); // calls tag.ToString()
		}
	}
}
