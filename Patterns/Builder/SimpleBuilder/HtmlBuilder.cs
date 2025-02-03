namespace Builder.SimpleBuilder;

public class HtmlBuilder(string rootName)
{
	private readonly HtmlElement _root = new()
	{
		Name = rootName
	};

	public void AddChild(string childName, string childText)
	{
		HtmlElement e = new (childName, childText);
		_root.Elements.Add(e);
	}

	public override string ToString()
	{
		return _root.ToString();
	}
}

