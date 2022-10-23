namespace GameLibrary.Sample.MV
{
	public interface ICharacter
	{
		bool IsAlive { get; }
		
		void TakeDamage(int damage);
	}
}