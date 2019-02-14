using Heroes.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Decorators
{
	internal class Weaked : TagDecorator
	{
		public Weaked(Unit unit)
			: base(unit)
		{
		}

		public override double GetAttackModifier()
		{
			return _unit.GetAttackModifier() * 0.5;
		}
	}
}
