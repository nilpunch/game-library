using UnityEngine;

public class Inverse : IShape
{
    private readonly IShape _shape;

    public Inverse(IShape shape)
    {
        _shape = shape;
    }
    
    public float Distance(Vector3 point)
    {
        return -_shape.Distance(point);
    }
}