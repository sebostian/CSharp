using Heroes.Behaviors;
using Heroes.Units;
using System.Collections.Generic;

namespace Heroes.Game
{
	class Army
	{
		protected readonly List<Unit> _units;
		protected readonly Unit.Kind _kind; 

		public Army(UnitBehaviors behaviors, Unit.Kind kind)
		{
			_units = new List<Unit>();
			_kind = kind;
			FillArmy(behaviors);
		}

		public Unit GetUnit(int index)
		{
			return _units[index];
		}

		private void FillArmy(UnitBehaviors behaviors)
		{
			switch (_kind)
			{
				case Units.Unit.Kind.Humans:
					Unit humanWarrior = new Warrior(Units.Unit.Kind.Humans, 1, "Warrior", 100, 18);
					humanWarrior.SetAction(Units.Unit.ActionIndex.TheFirst, behaviors.MakeDamageByWeapon);
					_units.Add(humanWarrior);

					Unit humanArcher = new Shooter(Units.Unit.Kind.Humans, 2, "Archer", 100, 3, 5);
					humanArcher.SetAction(Units.Unit.ActionIndex.TheFirst, behaviors.MakeDamageByWeapon);
					humanArcher.SetAction(Units.Unit.ActionIndex.TheSecond, behaviors.MakeDamageByShoot);
					_units.Add(humanArcher);

					Unit humanMage = new Mage(Units.Unit.Kind.Humans, 2, "Mage", 100, 4);
					humanMage.SetAction(Units.Unit.ActionIndex.TheFirst, behaviors.MakeDamageByWeapon);
					humanMage.SetAction(Units.Unit.ActionIndex.TheSecond, behaviors.MarkAsAdvance);
					_units.Add(humanMage);

					break;
				case Unit.Kind.Orcs:
					Unit orcWarrior = new Warrior(Units.Unit.Kind.Orcs, 1, "Goblin", 100, 20);
					orcWarrior.SetAction(Units.Unit.ActionIndex.TheFirst, behaviors.MakeDamageByWeapon);
					_units.Add(orcWarrior);

					Unit orcArcher = new Shooter(Units.Unit.Kind.Orcs, 2, "OrcArcher", 100, 2, 3);
					orcArcher.SetAction(Units.Unit.ActionIndex.TheFirst, behaviors.MakeDamageByWeapon);
					orcArcher.SetAction(Units.Unit.ActionIndex.TheSecond, behaviors.MakeDamageByShoot);
					_units.Add(orcArcher);

					Unit orcMage = new Mage(Units.Unit.Kind.Orcs, 2, "Shaman", 100, 0);
					orcMage.SetAction(Units.Unit.ActionIndex.TheFirst, behaviors.MarkAsCursed);
					orcMage.SetAction(Units.Unit.ActionIndex.TheSecond, behaviors.MarkAsAdvance);
					_units.Add(orcMage);
					break;
				case Unit.Kind.Elfs:
					break;
				case Unit.Kind.Undeads:
					break;
				default:
					break;
			}
		}
	}
}
