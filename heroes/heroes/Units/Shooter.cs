using System;

namespace Heroes.Units
{
	internal class Shooter : Unit
	{
		protected double _shootPower;
		
		public Shooter(Kind kind, int numberOfActions, string name, double health, double attackPower, double shootPower) 
			: base(kind, numberOfActions, name, health, attackPower)
		{
			_shootPower = shootPower;
		}

		public override double GetAttackModifier()
		{
			return 1;
		}

		public double GetShootPower()
		{
			return _shootPower * GetAttackModifier();
		}

	}
}
