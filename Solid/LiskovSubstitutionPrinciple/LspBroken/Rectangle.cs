﻿namespace LiskovSubstitutionPrinciple.LspBroken
{
	public class Rectangle
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public Rectangle() { }
		public Rectangle(int width, int height)
		{
			Width = width;
			Height = height;
		}
		public int Area => Width * Height;
	}
}
