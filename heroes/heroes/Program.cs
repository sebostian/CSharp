using System;
using Heroes.Behaviors;
using Heroes.Game;
using Heroes.Units;

namespace Heroes
{
	class Program
	{
		static void Main(string[] args)
		{
			UnitBehaviors unitBehaviors = new UnitBehaviors();

			Army humanArmy = new Army(unitBehaviors, Unit.Kind.Humans);
			Army orcArmy = new Army(unitBehaviors, Unit.Kind.Orcs);

			while (true)
			{
				DoAttack(humanArmy, orcArmy);
				DoAttack(orcArmy, humanArmy);
			}
		}

		private static void DoAttack(Army army, Army enemyArmy)
		{
			// Choose unit
			int unitNumber = GameHelpers.GetRandomValue(3);
			Unit unit = army.GetUnit(unitNumber);
			Unit destinationUnit;
			int numberOfActions = unit.GetNumberOfActions();
			int actionNumber = GameHelpers.GetRandomValue(numberOfActions);
			if (unit.IsEnemyDestination((Unit.ActionIndex)actionNumber))
			{
				int enemyNumber = GameHelpers.GetRandomValue(3);
				destinationUnit = enemyArmy.GetUnit(enemyNumber);
			}
			else
			{
				int allyNumber = GameHelpers.GetRandomValue(3);
				destinationUnit = enemyArmy.GetUnit(allyNumber);
			}

			unit.PerformAction((Unit.ActionIndex)actionNumber, destinationUnit);
		}
	}
}
