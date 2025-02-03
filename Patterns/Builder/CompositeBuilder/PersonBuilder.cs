using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CompositeBuilder;

public class PersonBuilder
{
	protected Person _person;

	public PersonBuilder()
	{
		_person = new Person();
	}

	protected PersonBuilder(Person person)
	{
		_person = person;
	}

	public Person GetPerson()
	{
		return _person;
	}

	public PersonAddressBuilder Lives => new PersonAddressBuilder(_person);
	public PersonJobBuilder Works => new PersonJobBuilder(_person);
}

