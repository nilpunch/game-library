using UnityEngine;

namespace SMF
{
    public class Circle2D : IConvexShape2D
    {
        private readonly Vector2 _centre;
        private readonly float _radius;

        public Circle2D(Vector2 centre, float radius)
        {
            _centre = centre;
            _radius = radius;
        }

        public Vector2 SupportPoint(Vector2 direction)
        {
            return _centre + _radius * direction.normalized;
        }
    }
}
