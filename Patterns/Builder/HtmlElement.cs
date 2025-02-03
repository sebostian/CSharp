using System.Collections.Generic;
using System.Text;

namespace Builder;

public class HtmlElement
{
	private const int _indentSize = 2;
	public string Name { get; set; }
	public string Text { get; set; }

	public readonly List<HtmlElement> Elements = [];

	public HtmlElement()
	{
		
	}
	
	public HtmlElement(string name, string text)
	{
		Name = name;
		Text = text;
	}
	
	public override string ToString()
	{
		return ToStringImpl(0);
	}

	private string ToStringImpl(int indent)
	{
		StringBuilder sb = new ();
		string valueWithIndent = new (' ', _indentSize * indent);
		sb.Append($"{valueWithIndent}<{Name}>\n");
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

		sb.Append($"{valueWithIndent}</{Name}>\n");
		return sb.ToString();
	}

}

