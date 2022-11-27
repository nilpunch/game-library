using UnityEngine;

public class Sphere : IShape
{
    private readonly float _radius;

    public Sphere(float radius)
    {
        _radius = radius;
    }
    
    public float Distance(Vector3 point)
    {
        return Vector3.Magnitude(point) - _radius;
    }
}