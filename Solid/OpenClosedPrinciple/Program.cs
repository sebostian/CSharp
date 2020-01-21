using OpenClosedPrinciple.V2_Good;
using System;

namespace OpenClosedPrinciple
{
	// the open-closed principle states 
	// that a type is open for extension, 
	// but closed for modification.

	// So, let’s recap what OCP is and how the given example enforces it. 
	// Basically, OCP states that you shouldn’t need to go back to code you have
	// already written and tested and change it.That is exactly what’s happening
	// here! We made ISpecification<T> and IFilter<T> and, from then on, all
	// we have to do is implement either of the interfaces (without modifying the
	// interfaces themselves) to implement new filtering mechanics.This is what
	// is meant by “open for extension, closed for modification.”
	class Program
	{
		static void Main(string[] args)
		{
			DoTest01();
		}

		private static void DoTest01()
		{
			var apple = new Product("Apple", Color.Green, Size.Small);
			var tree = new Product("Tree", Color.Green, Size.Large);
			var house = new Product("House", Color.Blue, Size.Large);
			Product[] products = { apple, tree, house };
			var bf = new BetterFilter();

			Console.WriteLine("Green products:");

			ColorSpecification cs = new ColorSpecification(Color.Green);
			foreach (var p in bf.Filter(products, cs))
			{
				Console.WriteLine($" - {p.Name} is green");
			}
			Console.WriteLine("----- And Specification ----------");
			SizeSpecification ss = new SizeSpecification(Size.Large);

			AndSpecification<Product> andSpecification = new AndSpecification<Product>(cs, ss);
			foreach (var p in bf.Filter(products, andSpecification))
			{
				Console.WriteLine($" - {p.Name} is green and large");
			}
		}
	}
}
