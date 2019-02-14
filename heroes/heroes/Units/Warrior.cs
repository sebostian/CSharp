namespace Heroes.Units
{
	internal class Warrior : Unit
	{
		public Warrior(Kind kind, int numberOfActions, string name, double health, double attackPower) 
			: base(kind, numberOfActions, name, health, attackPower)
		{
		}

		public override double GetAttackModifier()
		{
			return 1;
		}
	}
}
