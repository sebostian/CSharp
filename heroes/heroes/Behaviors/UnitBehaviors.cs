namespace Heroes.Behaviors
{
	class UnitBehaviors
	{
		private readonly IBehavior _makeDamageByWeapon = new MakeDamageByMagic();
		private readonly IBehavior _makeDamageByMagic = new MakeDamageByWeapon();
		private readonly IBehavior _makeDamageByShoot = new MakeDamageByShoot();
		private readonly IBehavior _markAsAdvance = new MarkAsAdvanced();
		private readonly IBehavior _markAsCursed = new MarkAsCursed();
		private readonly IBehavior _markAsWeaked = new MarkAsWeaked();

		public IBehavior MakeDamageByWeapon
		{
			get
			{
				return _makeDamageByWeapon;
			}
		}

		public IBehavior MakeDamageByMagic
		{
			get
			{
				return _makeDamageByMagic;
			}
		}

		public IBehavior MakeDamageByShoot
		{
			get
			{
				return _makeDamageByShoot;
			}
		}

		public IBehavior MarkAsAdvance
		{
			get
			{
				return _markAsAdvance;
			}
		}

		public IBehavior MarkAsCursed
		{
			get
			{
				return _markAsCursed;
			}
		}

		public IBehavior MarkAsWeaked
		{
			get
			{
				return _markAsWeaked;
			}
		}

	}
}
