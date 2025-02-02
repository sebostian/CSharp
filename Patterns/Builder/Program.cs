using System;
using Builder.CompositeBuilder;
using Builder.FluentBuilder;

namespace Builder;
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
		Console.WriteLine("Using composite builder");
		Console.WriteLine("-----------------------");

		Person person = new PersonBuilder()
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

		HtmlBuilder fluentBuilder = new HtmlBuilder("ul")
			.AddChild("li", "hello")
			.AddChild("li", "world");
		Console.WriteLine(fluentBuilder.ToString());

		Console.WriteLine("--------------------");
		Console.WriteLine("Using factory");
		Console.WriteLine("--------------------");

		HtmlBuilder fabricBuilder = CommunicatingIntent.HtmlElement.Create("ul")
			.AddChild("li", "hello")
			.AddChild("li", "world");
		Console.WriteLine(fabricBuilder.ToString());

	}

	private static void DoTestSimpleBuilder()
	{
		Console.WriteLine("--------------------");
		Console.WriteLine("Without any builder");
		Console.WriteLine("--------------------");

		string[] words = ["hello", "world"];
		HtmlElement tag = new ("ul", null);
		foreach (string word in words)
		{
			tag.Elements.Add(new HtmlElement("li", word));
		}

		Console.WriteLine(tag);

		Console.WriteLine("--------------------");
		Console.WriteLine("Using simple builder");
		Console.WriteLine("--------------------");

		SimpleBuilder.HtmlBuilder simpleBuilder = new ("ul");
		simpleBuilder.AddChild("li", "hello");
		simpleBuilder.AddChild("li", "world");
		Console.WriteLine(simpleBuilder.ToString());
	}
}
