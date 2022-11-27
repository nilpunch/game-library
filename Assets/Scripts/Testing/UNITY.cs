using System;
using UnityEngine;

namespace GameLibrary.Mathematics
{
    public class UNITY
    {
        public UNITY()
        {
            Vector3 vec = Vector3.back;
            Quaternion q = Quaternion.identity;

            Vector3 res = q * vec;

            var a = Mathf.Epsilon;
        }
    }
}