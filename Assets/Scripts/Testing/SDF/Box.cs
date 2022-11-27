using System;
using UnityEngine;

public class Box : IShape
{
    private readonly Vector3 _extents;

    public Box(Vector3 extents)
    {
        _extents = extents;
    }

    public float Distance(Vector3 point)
    {
        Vector3 d = Vector.AbsComponents(point) - _extents / 2f;
        return Vector3.Magnitude(Vector3.Max(d, Vector3.zero)) + Mathf.Min(Mathf.Max(d.x, d.y, d.z), 0.0f);
    }
}