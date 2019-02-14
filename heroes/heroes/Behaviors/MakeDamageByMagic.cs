using Heroes.Units;

namespace Heroes.Behaviors
{
	//TODO SB Rename classes. Make... isn't good name for classes
	internal class MakeDamageByMagic : IEnemyDestination
	{
		public void PerformAction(Unit actor, Unit destination)
		{
			double attackPower = actor.GetAttackPower();
			destination.Health -= attackPower;
		}
	}
}
