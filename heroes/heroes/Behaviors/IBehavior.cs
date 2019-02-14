using Heroes.Units;

namespace Heroes.Behaviors
{
	internal interface IBehavior
	{
		void PerformAction(Unit actor, Unit destination);
	}
}