using UnityEngine;

public class Translation : IShape
{
    private readonly Vector3 _offset;
    private readonly IShape _shape;

    public Translation(Vector3 offset, IShape shape)
    {
        _offset = offset;
        _shape = shape;
    }
    
    public float Distance(Vector3 point)
    {
        return _shape.Distance(point - _offset);
    }
}