using System;
using System.Collections.Generic;
using System.Linq;
using GameLibrary.Mathematics;
using GameLibrary.Physics.SupportMapping;
using GameLibrary.Physics.SupportPoint;
using UnityEditor;
using UnityEngine;
using BoxCollider = GameLibrary.Physics.SupportMapping.BoxCollider;
using SphereCollider = GameLibrary.Physics.SupportMapping.SphereCollider;

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

        [SerializeField] private Transform _boxOrigin2;
        [SerializeField] private Vector3 _boxExtents2 = Vector3.one;

        [SerializeField, Range(1, 100)] private int _gjkIterations = 20;
        [SerializeField, Range(1, 10)] private int _epaIterations = 20;

        private void OnDrawGizmos()
        {
            if (_firstSphere == null || _secondSphere == null || _boxOrigin == null)
                return;

            var sphere = new SphereCollider(_firstSphere.position.ToSoft(), (SoftFloat)_firstRadius);
            var sphere2 = new SphereCollider(_secondSphere.position.ToSoft(), (SoftFloat)_secondRadius);
            var box = new BoxCollider(_boxOrigin.position.ToSoft(), (_boxExtents / 2f).ToSoft());
            var box2 = new BoxCollider(_boxOrigin2.position.ToSoft(), (_boxExtents2 / 2f).ToSoft());

            var shapeA = box;
            var shapeB = box2;

            GjkAlgorithm.Result result = GjkAlgorithm.Calculate(shapeA, shapeB, _gjkIterations);

            // Gizmos.color = Color.magenta;
            // foreach (var (a, b) in result.Simplex.DistinctPairs((a, b) => (a, b)))
            // {
            //     Gizmos.DrawLine(a.ToUnity(), b.ToUnity());
            // }

            if (result.CollisionHappened)
            {
                var epaResult = EpaAlgorithm.Calculate(result.Simplex, shapeA, shapeB, _epaIterations, out var specialPoints);

                Gizmos.color = Color.magenta;
                foreach (var face in epaResult.polytopeFaces)
                {
                    Gizmos.DrawLine(epaResult.polytope[face.A].ToUnity(), epaResult.polytope[face.B].ToUnity());
                    Gizmos.DrawLine(epaResult.polytope[face.A].ToUnity(), epaResult.polytope[face.C].ToUnity());
                    Gizmos.DrawLine(epaResult.polytope[face.B].ToUnity(), epaResult.polytope[face.C].ToUnity());
                }

                Gizmos.color = Color.cyan;
                foreach (var specialPoint in specialPoints)
                {
                    Gizmos.DrawSphere(specialPoint.ToUnity(), 0.05f);
                }

                // var collision = EpaAlgorithm.Calculate(result.Simplex, sphere, sphere2, _epaIterations);

                Debug.Log(epaResult.collision.PenetrationNormal);

                Gizmos.color = Color.blue;
                Gizmos.DrawLine(Vector3.zero, (epaResult.collision.PenetrationNormal).ToUnity());

                // foreach (var (a, b) in result.Simplex.DistinctPairs((a, b) => (a, b)))
                // {
                //     Gizmos.DrawLine(a.ToUnity(), b.ToUnity());
                // }

                Gizmos.color = Color.green;
            }
            else
            {
                Gizmos.color = Color.yellow;
                // foreach (var (a, b) in result.Simplex.DistinctPairs((a, b) => (a, b)))
                // {
                //     Gizmos.DrawLine(a.ToUnity(), b.ToUnity());
                // }

                Gizmos.color = Color.red;
            }


            // Debug.Log(result.Iterations + ": " + result.Direction);

            // Gizmos.DrawWireSphere(Vector3.Scale(_firstSphere.position, new Vector3(1f, 1f, 1f)), _firstRadius);
            //
            // Gizmos.DrawWireSphere(Vector3.Scale(_secondSphere.position, new Vector3(1f, 1f, 1f)), _secondRadius);

            // if (GJK2D.IsColliding(box, sphere) || GJK2D.IsColliding(box, sphere2))
            //     Gizmos.color = Color.green;
            // else
            //     Gizmos.color = Color.red;

            Gizmos.DrawWireCube(Vector3.Scale(_boxOrigin.position, new Vector3(1f, 1f, 1f)),
                Vector3.Scale(_boxExtents, new Vector3(1f, 1f, 1f)));
            Gizmos.DrawWireCube(Vector3.Scale(_boxOrigin2.position, new Vector3(1f, 1f, 1f)),
                Vector3.Scale(_boxExtents2, new Vector3(1f, 1f, 1f)));
        }
    }
}
