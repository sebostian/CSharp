using System.Collections.Generic;
using System.Text;

namespace Builder.CommunicatingIntent;

public abstract class HtmlElement
{
	private const int _indentSize = 2;
	public string Name { get; set; }
	public string Text { get; set; }

	protected readonly List<HtmlElement> Elements = [];

	protected HtmlElement()
	{
	}

	protected HtmlElement(string name, string text)
	{
		Name = name;
		Text = text;
	}

	public static FluentBuilder.HtmlBuilder CreateBuilder(string name)
	{
		return new FluentBuilder.HtmlBuilder(name);
	}

	private string ToStringImpl(int indent)
	{
		var sb = new StringBuilder();
		var i = new string(' ', _indentSize * indent);
		sb.Append($"{i}<{Name}>\n");
		if (!string.IsNullOrWhiteSpace(Text))
		{
			sb.Append(new string(' ', _indentSize * (indent + 1)));
			sb.Append(Text);
			sb.Append('\n');
		}

		foreach (HtmlElement e in Elements)
		{
			sb.Append(e.ToStringImpl(indent + 1));
		}

		sb.Append($"{i}</{Name}>\n");
		return sb.ToString();
	}

	public override string ToString()
	{
		return ToStringImpl(0);
	}
}

