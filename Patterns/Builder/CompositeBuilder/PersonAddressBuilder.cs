namespace Builder.CompositeBuilder
{
	public class PersonAddressBuilder : PersonBuilder
	{
		public PersonAddressBuilder(Person person)
			: base(person)
		{
			this._person = person;
		}

		public PersonAddressBuilder At(string streetAddress)
		{
			_person.StreetAddress = streetAddress;
			return this;
		}

		public PersonAddressBuilder WithPostcode(string postcode)
		{
			_person.Postcode = postcode;
			return this;
		}

		public PersonAddressBuilder In(string city)
		{
			_person.City = city;
			return this;
		}
	}
}