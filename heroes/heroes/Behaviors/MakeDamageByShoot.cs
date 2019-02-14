using Heroes.Units;

namespace Heroes.Behaviors
{
	internal class MakeDamageByShoot : IEnemyDestination
	{
		public void PerformAction(Unit actor, Unit destination)
		{
			// Select goal. It should be enemy.
			destination.Health -= ((Shooter)actor).GetShootPower();
		}
	}
}
