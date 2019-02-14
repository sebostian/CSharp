using Heroes.Units;

namespace Heroes.Behaviors
{
	internal class MarkAsCursed : IEnemyDestination
	{
		public void PerformAction(Unit actor, Unit destination)
		{
			// Choise goal. Should be enemy
			// should remove advanced
			destination.RemoveTag(Unit.Tag.Advanced);
		}
	}
}
