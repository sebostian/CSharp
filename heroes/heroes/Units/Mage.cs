using System;

namespace Heroes.Units
{
	internal class Mage : Unit
	{
		public Mage(Kind kind, int numberOfActions, string name, double health, double attackPower) 
			: base(kind, numberOfActions, name, health, attackPower)
		{
		}

		public override double GetAttackModifier()
		{
			double result = 1;
			foreach (Tag item in GetTags())
			{
				switch (item)
				{
					case Tag.Advanced:
						result *= 2;
						break;
					case Tag.Weaked:
						result *= 0.5;
						break;
					default:
						throw new ArgumentException(string.Format("Invalid argument {0}", item.ToString()));
				}
			}

			return result;
		}
	}
}
