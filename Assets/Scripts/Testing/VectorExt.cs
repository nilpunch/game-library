using UnityEngine;

namespace GameLibrary.Mathematics
{
    public static class VectorExt
    {
        public static SoftVector3 ToSoft(this Vector3 vector)
        {
            return new SoftVector3((SoftFloat)vector.x, (SoftFloat)vector.y, (SoftFloat)vector.z);
        }

        public static Vector3 ToUnity(this SoftVector3 vector)
        {
            return new Vector3((float)vector.X, (float)vector.Y, (float)vector.Z);
        }
    }
}
