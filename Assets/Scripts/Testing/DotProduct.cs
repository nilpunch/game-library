using System;
using GameLibrary.Mathematics;
using UnityEngine;

public class DotProduct : MonoBehaviour
{
    [SerializeField] private Transform _first;
    [SerializeField] private Transform _second;

    private void Update()
    {
        Quaternion first = _first.rotation;
        SoftQuaternion firstSoftQuaternion = new SoftQuaternion((SoftFloat) first.x, (SoftFloat) first.y,
            (SoftFloat) first.z, (SoftFloat) first.w);
        
        Quaternion second = _second.rotation;
        SoftQuaternion secondSoftQuaternion = new SoftQuaternion((SoftFloat) second.x, (SoftFloat) second.y,
            (SoftFloat) second.z, (SoftFloat) second.w);
        
        // Debug.Log("Dot = " + SoftQuaternion.Dot(firstSoftQuaternion, secondSoftQuaternion));
    }
}