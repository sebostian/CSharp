using System;
using System.Collections.Generic;

namespace Algorithms.Graphs
{
	public class BinaryTree
	{
		public class Node
		{
			public Node(int value)
			{
				Value = value;
			}

			public int Value { get; protected set; }
			public Node Left { get; set; }
			public Node Right { get; set; }

			internal void AddValue(int value)
			{
				if (Left == null)
				{
					Left = new Node(value);
					return;
				}

				if (value < Left.Value)
				{
					Left.AddValue(value);
				}
				else
				{
					if (Right == null)
					{
						Right = new Node(value);
					}
					else
					{
						Right.AddValue(value);
					}
				}
			}

			internal void Visit(List<int> list)
			{
				
				if (Left != null)
				{
					Left.Visit(list);
				}

				list.Add(Value);

				if (Right != null)
				{
					Right.Visit(list);
				}
			}
		}

		public Node Root { get; set; }

		public void AddValue(int value)
		{
			if (Root == null)
			{
				Root = new Node(value);
				return;
			}

			Root.AddValue(value);
		}

		public void Traverse(List<int> d)
		{
			Root.Visit(d);
		}
	}
}
