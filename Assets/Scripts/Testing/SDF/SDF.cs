using UnityEngine;

public static class SDF
{
    public static Vector3 Gradient(Vector3 point, IShape shape, float eps = 0.001f)
    {
        Vector3 dfdx;

        dfdx.x = shape.Distance(point + Vector3.right * eps) - shape.Distance(point + Vector3.right * -eps);
        dfdx.y = shape.Distance(point + Vector3.up * eps) - shape.Distance(point + Vector3.up * -eps);
        dfdx.z = shape.Distance(point + Vector3.forward * eps) - shape.Distance(point + Vector3.forward * -eps);
        dfdx /= 2.0f * eps;

        return Vector3.Normalize(dfdx);
    }
}