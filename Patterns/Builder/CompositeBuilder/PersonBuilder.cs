using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CompositeBuilder
{
	public class PersonBuilder
	{
		protected Person person;

		public PersonBuilder()
		{
			person = new Person();
		}

		protected PersonBuilder(Person person)
		{
			this.person = person;
		}

		public Person GetPerson()
		{
			return this.person;
		}

		public PersonAddressBuilder Lives => new PersonAddressBuilder(person);
		public PersonJobBuilder Works => new PersonJobBuilder(person);
	}
}
