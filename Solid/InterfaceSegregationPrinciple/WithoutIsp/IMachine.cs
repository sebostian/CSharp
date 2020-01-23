namespace InterfaceSegregationPrinciple.WithoutIsp
{
	public interface IMachine
	{
		void Print(string context);
		void Scan(string context);
		void Fax(string context);
	}
}
