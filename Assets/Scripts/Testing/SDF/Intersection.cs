using UnityEngine;

public class Intersection : IShape
{
    private readonly IShape _first;
    private readonly IShape _second;

    public Intersection(IShape first, IShape second)
    {
        _first = first;
        _second = second;
    }
    
    public float Distance(Vector3 point)
    {
        return Mathf.Max(_first.Distance(point), _second.Distance(point));
    }
}