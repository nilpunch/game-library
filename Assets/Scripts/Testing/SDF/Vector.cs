using UnityEngine;

public static class Vector
{
    public static Vector3 AbsComponents(Vector3 vector)
    {
        return new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
    }
    
    public static Vector3 SignComponents(Vector3 vector)
    {
        return new Vector3(Mathf.Sign(vector.x), Mathf.Sign(vector.y), Mathf.Sign(vector.z));
    }
    
    public static Vector3 MinComponents(Vector3 first, Vector3 other)
    {
        return new Vector3(Mathf.Min(first.x, other.x), Mathf.Min(first.y, other.y), Mathf.Min(first.z, other.z));
    }
    
    public static Vector3 MaxComponents(Vector3 first, Vector3 other)
    {
        return new Vector3(Mathf.Max(first.x, other.x), Mathf.Max(first.y, other.y), Mathf.Max(first.z, other.z));
    }
}