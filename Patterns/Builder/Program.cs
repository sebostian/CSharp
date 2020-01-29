using System;

namespace Builder
{
	// The Builder pattern is concerned with the creation of complicated objects;
	// that is, objects that cannot be built up in a single-line constructor call.
	class Program
	{
		static void Main(string[] args)
		{
			//DoTestSimpleBuilder();
			//DoTestFluentBuilder();

			DoTestCompositeBuilder();
		}

		private static void DoTestCompositeBuilder()
		{
			Console.WriteLine("-----------------------");
			Console.WriteLine("Using composute builder");
			Console.WriteLine("-----------------------");

			var pb = new CompositeBuilder.PersonBuilder();

			var person = pb
				.Lives
					.At("123 London Road")
					.In("London")
					.WithPostcode("SW12BC")
				.Works
					.At("Fabrikam")
					.AsA("Engineer")
					.Earning(123000)
				.GetPerson();

			Console.WriteLine(person);
		}

		private static void DoTestFluentBuilder()
		{
			Console.WriteLine("--------------------");
			Console.WriteLine("Using fluent builder");
			Console.WriteLine("--------------------");

			var fluentBuilder = new FluentBuilder.HtmlBuilder("ul")
				.AddChild("li", "hello")
				.AddChild("li", "world");
			Console.WriteLine(fluentBuilder.ToString());

			Console.WriteLine("--------------------");
			Console.WriteLine("Using factory");
			Console.WriteLine("--------------------");

			var fabricBuilder = CommunicatingIntent.HtmlElement.Create("ul")
				.AddChild("li", "hello")
				.AddChild("li", "world");
			Console.WriteLine(fabricBuilder.ToString());

		}

		private static void DoTestSimpleBuilder()
		{
			Console.WriteLine("--------------------");
			Console.WriteLine("Without any builder");
			Console.WriteLine("--------------------");

			var words = new[] { "hello", "world" };
			var tag = new HtmlElement("ul", null);
			foreach (var word in words)
			{
				tag.Elements.Add(new HtmlElement("li", word));
			}

			Console.WriteLine(tag); // calls tag.ToString()

			Console.WriteLine("--------------------");
			Console.WriteLine("Using simple builder");
			Console.WriteLine("--------------------");

			var simpleBuilder = new SimpleBuilder.HtmlBuilder("ul");
			simpleBuilder.AddChild("li", "hello");
			simpleBuilder.AddChild("li", "world");
			Console.WriteLine(simpleBuilder.ToString());
		}
	}
}
