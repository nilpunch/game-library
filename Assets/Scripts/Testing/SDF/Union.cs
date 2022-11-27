using UnityEngine;

public class Union : IShape
{
    private readonly IShape _first;
    private readonly IShape _second;

    public Union(IShape first, IShape second)
    {
        _first = first;
        _second = second;
    }
    
    public float Distance(Vector3 point)
    {
        return Mathf.Min(_first.Distance(point), _second.Distance(point));
    }
}