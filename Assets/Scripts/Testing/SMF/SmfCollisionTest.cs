using System;
using UnityEditor;
using UnityEngine;

namespace SMF
{
    public class SmfCollisionTest : MonoBehaviour
    {
        [SerializeField] private Transform _firstSphere;
        [SerializeField] private float _firstRadius;

        [SerializeField] private Transform _secondSphere;
        [SerializeField] private float _secondRadius;

        [SerializeField] private Transform _boxOrigin;
        [SerializeField] private Vector3 _boxExtents;

        [Space] [SerializeField] private Transform _testPointHandle;

        private void Update()
        {
            var sphere = new Circle2D(_firstSphere.position, _firstRadius);
            var sphere2 = new Translation(_secondSphere.position, new Sphere(_secondRadius));
            var box = new Translation(_secondSphere.position, new Sphere(_secondRadius));
        }

        private void OnDrawGizmos()
        {
            if (_firstSphere == null || _secondSphere == null || _boxOrigin == null)
                return;

            var sphere = new Circle2D(_firstSphere.position, _firstRadius);
            var sphere2 = new Circle2D(_secondSphere.position, _secondRadius);
            var box = new Box2D(_boxOrigin.position, _boxExtents);


            if (GJK2D.IsColliding(sphere, sphere2).colliding)
                Gizmos.color = Color.green;
            else
                Gizmos.color = Color.red;

            Debug.Log(GJK2D.IsColliding(sphere, sphere2).iterations.ToString());

            // if (GJK2D.IsColliding(sphere, sphere2) || GJK2D.IsColliding(sphere, box))
            //     Gizmos.color = Color.green;
            // else
            //     Gizmos.color = Color.red;

            Gizmos.DrawWireSphere(Vector3.Scale(_firstSphere.position, new Vector3(1f, 1f, 0f)), _firstRadius);

            // if (GJK2D.IsColliding(sphere2, sphere) || GJK2D.IsColliding(sphere2, box))
            //     Gizmos.color = Color.green;
            // else
            //     Gizmos.color = Color.red;

            Gizmos.DrawWireSphere(Vector3.Scale(_secondSphere.position, new Vector3(1f, 1f, 0f)), _secondRadius);

            // if (GJK2D.IsColliding(box, sphere) || GJK2D.IsColliding(box, sphere2))
            //     Gizmos.color = Color.green;
            // else
            //     Gizmos.color = Color.red;

            Gizmos.DrawWireCube(Vector3.Scale(_boxOrigin.position, new Vector3(1f, 1f, 0f)), Vector3.Scale(_boxExtents, new Vector3(1f, 1f, 0f)));
        }
    }
}
