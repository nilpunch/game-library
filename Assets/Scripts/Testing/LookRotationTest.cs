using GameLibrary.Mathematics;
using UnityEngine;

public class LookRotationTest : MonoBehaviour
{
    [SerializeField] private Transform _first;
    [SerializeField] private Transform _second;
    [SerializeField] private Transform _up;
    [SerializeField] private float _duration = 0.01f;

    private void Update()
    {
        if (_first == null || _second == null || _up == null)
            return;

        Vector3 direction = _second.position - _first.position;
        Vector3 upDirection = _up.position - _first.position;

        SoftVector3 softDirection = new SoftVector3((SoftFloat)direction.x, (SoftFloat)direction.y, (SoftFloat)direction.z);
        SoftVector3 softUpDirection = new SoftVector3((SoftFloat)upDirection.x, (SoftFloat)upDirection.y, (SoftFloat)upDirection.z);

        SoftUnitQuaternion v = new SoftUnitQuaternion();
        
        SoftUnitQuaternion lookRotation = SoftUnitQuaternion.LookRotation(softDirection, softUpDirection);
        //Quaternion lookRotation2 = Quaternion.LookRotation(direction, Vector3.up * 100f);

        SoftVector3 softLookForwardResult = lookRotation * SoftVector3.Forward;
        SoftVector3 softLookUpResult = lookRotation * SoftVector3.Up;

        Vector3 unityUpResult = new Vector3((float)softLookUpResult.X, (float)softLookUpResult.Y, (float)softLookUpResult.Z);
        Vector3 unityForwardResult = new Vector3((float)softLookForwardResult.X, (float)softLookForwardResult.Y, (float)softLookForwardResult.Z);
        Quaternion unityRotation = new Quaternion((float)lookRotation.X, (float)lookRotation.Y, (float)lookRotation.Z, (float)lookRotation.W);

        _first.rotation = unityRotation;
        
        Debug.DrawLine(_first.position, _first.position + unityForwardResult * 2f, Color.green, _duration);
        Debug.DrawLine(_first.position, _first.position + unityUpResult, Color.red, _duration);
    }
}