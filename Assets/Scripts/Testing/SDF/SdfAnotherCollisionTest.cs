using System;
using UnityEngine;

public class SdfAnotherCollisionTest : MonoBehaviour
{
    [SerializeField] private Transform _objectA;
    [SerializeField] private Transform _objectB;

    private void OnDrawGizmos()
    {
        if (_objectA == null || _objectB == null)
            return;


    }
}
