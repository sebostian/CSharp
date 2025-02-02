namespace Builder.CompositeBuilder;

public class Person
{
	// address
	public string StreetAddress { get; set; }
	public string Postcode { get; set; }
	public string City { get; set; }
	// employment info
	public string CompanyName { get; set; }
	public string Position { get; set; }
	public int AnnualIncome { get; set; }
	public override string ToString()
	{
		return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, " +
		       $"{nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
	}
}

