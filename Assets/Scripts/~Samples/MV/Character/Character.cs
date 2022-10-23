using System;

namespace GameLibrary.Sample.MV
{
	public class Character : ICharacter, ISimulationTick
	{
		private readonly ICharacterView _view;

		private int _health;

		public Character(int health, ICharacterView view)
		{
			_health = health;
			_view = view;
		}

		public bool IsAlive => _health > 0;

		public void ExecuteTick(long elapsedMilliseconds)
		{
			if (!IsAlive)
				throw new Exception();
            
			// Shoot weapon here
		}

		public void TakeDamage(int damage)
		{
			if (!IsAlive)
				throw new Exception();

			_health -= damage;
            
			_view.ShowHealth(_health);
		}
	}
}