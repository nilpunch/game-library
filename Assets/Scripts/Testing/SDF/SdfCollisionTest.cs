using System;
using UnityEngine;

public class SdfCollisionTest : MonoBehaviour
{
    [SerializeField] private Transform _firstSphere;
    [SerializeField] private float _firstRadius;

    [SerializeField] private Transform _secondSphere;
    [SerializeField] private float _secondRadius;

    [SerializeField] private Transform _boxOrigin;
    [SerializeField] private Vector3 _boxExtents;

    [Space] [SerializeField] private Transform _testPointHandle;

    [Space] [SerializeField] private float _gridScale = 50f;
    [SerializeField] private int _gridSize = 40;
    [SerializeField] private float _rayLength = 1f;

    private void Update()
    {
        var sphere = new Translation(_firstSphere.position, new Sphere(_firstRadius));
        var sphere2 = new Translation(_secondSphere.position, new Sphere(_secondRadius));

        
        
    }

    private void OnDrawGizmos()
    {
        if (_firstSphere == null || _testPointHandle == null || _secondSphere == null || _boxOrigin == null)
            return;

        DrawHandles();

        int gridSize = _gridSize;


        var sphere = new Translation(_firstSphere.position, new Sphere(_firstRadius));
        var sphere2 = new Translation(_secondSphere.position, new Sphere(_secondRadius));

        var box = new Translation(_boxOrigin.position, new Box(_boxExtents));

        // Gizmos.DrawSphere(Collision(sphere2, sphere, (_firstSphere.position + _secondSphere.position) / 2f), 0.2f);

        // var shape1 = sphere;
        var shape1 = new Translation(_boxOrigin.position, new Box(_boxExtents));

        for (int x = 0; x < gridSize; ++x)
        {
            for (int y = 0; y < gridSize; ++y)
            {
                for (int z = 0; z < gridSize; ++z)
                {
                    Vector3 position = transform.position + (new Vector3(x, y, z) / gridSize - Vector3.one / 2f) * _gridScale;
        
                    if (shape1.Distance(position) > 0.0f)
                        Gizmos.color = Color.yellow - new Color(0f, 0f, 0f, 1f) * 0.8f;
                    else
                        Gizmos.color = Color.red - new Color(0f, 0f, 0f, 1f) * 0.7f;

                    // var sdfGradient = SDF.Gradient(position, shape1);
                    // Color xColor = (Color.red - new Color(0f, 0f, 0f, 1f) * 0.8f) * sdfGradient.x ;
                    // Color yColor = (Color.green - new Color(0f, 0f, 0f, 1f) * 0.8f) * sdfGradient.y;
                    // Color zColor = (Color.blue - new Color(0f, 0f, 0f, 1f) * 0.8f) * sdfGradient.z;
                    // Gizmos.color = xColor + yColor + zColor;

                    float radius = Mathf.Pow(shape1.Distance(position), _rayLength);
                    
                    Gizmos.DrawSphere(position, radius);
                }
            }
        }
    }

    private void DrawHandles()
    {
        Gizmos.color = Color.green - new Color(0f, 0f, 0f, 1f) * 0f;

        Gizmos.DrawWireSphere(_firstSphere.position, _firstRadius);

        Gizmos.DrawWireSphere(_secondSphere.position, _secondRadius);

        Gizmos.DrawCube(_boxOrigin.position, _boxExtents);

        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(_testPointHandle.position, 0.1f);
    }
}