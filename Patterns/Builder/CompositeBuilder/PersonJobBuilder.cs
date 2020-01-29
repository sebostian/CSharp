﻿namespace Builder.CompositeBuilder
{
	public class PersonJobBuilder : PersonBuilder
	{
		public PersonJobBuilder(Person person)
			: base(person)
		{
			this.person = person;
		}

		public PersonJobBuilder At(string companyName)
		{
			person.CompanyName = companyName;
			return this;
		}

		public PersonJobBuilder AsA(string position)
		{
			person.Position = position;
			return this;
		}

		public PersonJobBuilder Earning(int annualIncome)
		{
			person.AnnualIncome = annualIncome;
			return this;
		}
	}
}