using Heroes.Units;

namespace Heroes.Behaviors
{
	internal class MarkAsWeaked : IEnemyDestination
	{
		public void PerformAction(Unit actor, Unit destination)
		{
			destination.AddTag(Unit.Tag.Weaked);
		}
	}
}
