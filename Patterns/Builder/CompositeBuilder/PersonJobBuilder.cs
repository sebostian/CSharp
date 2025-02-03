namespace Builder.CompositeBuilder
{
	public class PersonJobBuilder : PersonBuilder
	{
		public PersonJobBuilder(Person person)
			: base(person)
		{
			this._person = person;
		}

		public PersonJobBuilder At(string companyName)
		{
			_person.CompanyName = companyName;
			return this;
		}

		public PersonJobBuilder AsA(string position)
		{
			_person.Position = position;
			return this;
		}

		public PersonJobBuilder Earning(int annualIncome)
		{
			_person.AnnualIncome = annualIncome;
			return this;
		}
	}
}