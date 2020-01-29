namespace Builder.SimpleBuilder
{
	public class HtmlBuilder
	{
		protected readonly string rootName;
		protected HtmlElement root = new HtmlElement();

		public HtmlBuilder(string rootName)
		{
			this.rootName = rootName;
			root.Name = rootName;
		}

		public void AddChild(string childName, string childText)
		{
			var e = new HtmlElement(childName, childText);
			root.Elements.Add(e);
		}

		public override string ToString()
		{
			return root.ToString();
		}
	}
}
