using Heroes.Units;

namespace Heroes.Behaviors
{
	class MarkAsAdvanced : IAllyDestination
	{
		public void PerformAction(Unit actor, Unit destination)
		{
			destination.AddTag(Unit.Tag.Advanced);
		}
	}
}
