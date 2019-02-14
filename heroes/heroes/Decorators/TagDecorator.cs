using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heroes.Units;

namespace Heroes.Decorators
{
	internal abstract class TagDecorator : Units.Unit
	{
		protected Unit _unit;

		public TagDecorator(Unit unit)
			: base()
		{
			_unit = unit;
		}

		public TagDecorator(Kind kind, int numberOfActions, string name, byte health, byte attackPower) 
			: base(kind, numberOfActions, name, health, attackPower)
		{
		}
	}
}
