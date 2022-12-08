using UnityEngine;

namespace SMF
{
    public class Box2D : IConvexShape2D
    {
        private readonly Vector2 _centre;
        private readonly Vector2 _extents;

        public Box2D(Vector2 centre, Vector2 extents)
        {
            _centre = centre;
            _extents = extents;
        }

        public Vector2 SupportPoint(Vector2 direction)
        {
            return _centre + Vector2.Scale(_extents / 2f, Vector.SignComponents(direction));
        }
    }
}
