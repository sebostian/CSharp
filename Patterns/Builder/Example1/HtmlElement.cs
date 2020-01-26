using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1
{
	public class HtmlElement
	{
		private const int indentSize = 2;
		private StringBuilder sb = new StringBuilder();
		public string Name { get; set; }
		public string Text { get; set; }

		public List<HtmlElement> Elements = new List<HtmlElement>();

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
			if (Text == null)
			{
				sb.AppendLine($"<{Name}>");
			}
			else
			{
				sb.Append($"<{Name}>{Text}");
			}

			foreach (var item in Elements)
			{
				sb.Append(new String(' ', indentSize));
				sb.Append(item.ToString());
			}

			sb.AppendLine($"</{Name}>");

			return sb.ToString();
		}
	}
}
