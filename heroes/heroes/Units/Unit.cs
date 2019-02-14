using Heroes.Behaviors;
using System;
using System.Collections.Generic;

namespace Heroes.Units
{
	internal abstract class Unit
	{
		protected IBehavior[] _actions;
		protected double _attackPower;
		protected readonly List<Tag> _tags;

		public enum ActionIndex : byte
		{
			TheFirst = 0,
			TheSecond = 1,
		}
		
		public enum Kind : byte
		{
			Humans = 1,
			Orcs = 2,
			Elfs = 3,
			Undeads = 4
		}

		public enum Tag : byte
		{
			Advanced = 1,
			Weaked = 2,
		}

		public string Name { get; protected set; }
		public double Health { get; set; }
		public Kind KindOf { get; protected set; }

		public double GetAttackPower()
		{
			return _attackPower * GetAttackModifier();
		}

		public void AddTag(Tag tag)
		{
			_tags.Add(tag);
		}

		public void RemoveTag(Tag tag)
		{
			_tags.Remove(tag);
		}

		public List<Tag> GetTags()
		{
			return _tags;
		}

		public abstract double GetAttackModifier();

		public int GetNumberOfActions()
		{
			return _actions.Length;
		}

		public bool Alife()
		{
			return Health > 0;
		}

		public Unit()
		{
			_tags = new List<Tag>();
			_actions = new IBehavior[2];
		}

		public Unit(Kind kind, int numberOfActions, string name, double health, double attackPower)
		{
			KindOf = kind;
			Name = name;
			Health = health;
			_tags = new List<Tag>();
			_attackPower = attackPower;
			_actions = new IBehavior[numberOfActions];
		}

		public void SetAction(ActionIndex index,  IBehavior behavior)
		{
			// TODO SB add checking
			_actions[(byte)index] = behavior;
		}

		public void PerformAction(ActionIndex index, Unit destination)
		{
			// TODO SB add checking
			_actions[(byte)index].PerformAction(this, destination);
		}

		public bool IsEnemyDestination(ActionIndex index)
		{
			return _actions[(byte)index] is IEnemyDestination;
		}
	}
}
