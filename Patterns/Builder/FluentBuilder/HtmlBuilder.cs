namespace Builder.FluentBuilder;

public class HtmlBuilder(string rootName)
{
	private readonly HtmlElement _root = new()
	{
		Name = rootName,
	};

	public HtmlBuilder AddChild(string childName, string childText)
	{
		HtmlElement e = new (childName, childText);
		_root.Elements.Add(e);
		return this;
	}

	public override string ToString()
	{
		return _root.ToString();
	}
}

