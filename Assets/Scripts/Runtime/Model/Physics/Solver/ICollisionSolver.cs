namespace GameLibrary.Physics
{
	public interface ICollisionSolver
	{
		void Solve(CollisionManifold[] collisionManifolds, long timeStep);
	}
}