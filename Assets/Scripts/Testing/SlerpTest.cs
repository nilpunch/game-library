using System;
using GameLibrary.Mathematics;
using UnityEngine;

public class SlerpTest : MonoBehaviour
{
    [SerializeField] private Transform _first;
    [SerializeField] private Transform _second;
    [SerializeField] private float _param = 1f;
    [SerializeField] private float _duration = 1f;
    [SerializeField] private bool _longPath = false;
    [SerializeField] private bool _slerp = false;
    [SerializeField] private bool _lerp = false;
    [SerializeField] private float _scaleFirst = 1f;
    [SerializeField] private float _scaleSecond = 1f;

    private void Update()
    {
        if (_first == null || _second == null)
            return;

        float param = (Mathf.PingPong(Time.time * _param, 1f));
        
        Quaternion first = _first.rotation;
        SoftQuaternion a = new SoftQuaternion((SoftFloat) first.x, (SoftFloat) first.y,
            (SoftFloat) first.z, (SoftFloat) first.w * (SoftFloat)_scaleFirst);
        
        Quaternion second = _second.rotation;
        SoftQuaternion b = new SoftQuaternion((SoftFloat) second.x, (SoftFloat) second.y,
            (SoftFloat) second.z, (SoftFloat) second.w) * (SoftFloat)_scaleSecond;
        
        SoftQuaternion lerp = SoftQuaternion.Nlerp(a, b, (SoftFloat) (param), _longPath);
        SoftQuaternion slerp = SoftQuaternion.Slerp(a, b, (SoftFloat) (param), _longPath);

        SoftVector3 lerpRes = lerp * SoftVector3.Up;
        SoftVector3 slerpRes = slerp * SoftVector3.Up;

        Vector3 lerpUnity = new Vector3((float)lerpRes.X, (float)lerpRes.Y, (float)lerpRes.Z);
        Vector3 slerpUnity = new Vector3((float)slerpRes.X, (float)slerpRes.Y, (float)slerpRes.Z);

        if (_lerp)
            Debug.DrawLine(transform.position, transform.position + lerpUnity, Color.blue, _duration);
        if (_slerp)
            Debug.DrawLine(transform.position, transform.position + slerpUnity, Color.red, _duration);
    }
}