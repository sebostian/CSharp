using Heroes.Units;

namespace Heroes.Decorators
{
	internal class Advanced : TagDecorator
	{
		public Advanced(Unit unit)
			: base(unit)
		{
		}

		public override double GetAttackModifier()
		{
			return _unit.GetAttackPower() * 1.5;
		}
	}
}
