using UnityEngine;

namespace SMF
{
    public interface IConvexShape2D
    {
        Vector2 SupportPoint(Vector2 direction);
    }
}
