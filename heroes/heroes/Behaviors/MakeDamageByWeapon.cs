using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heroes.Units;

namespace Heroes.Behaviors
{
	internal class MakeDamageByWeapon : IEnemyDestination
	{
		public void PerformAction(Unit actor, Unit destination)
		{
			// Select goal. It should be enemy.
			destination.Health -= actor.GetAttackPower();
		}
	}
}
