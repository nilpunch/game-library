using System;
using System.Collections.Generic;
using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;
using UnityEngine;
using Rigidbody = GameLibrary.Physics.Rigidbody;

namespace SMF
{
    public class SmfCollisionTest : MonoBehaviour
    {
        [SerializeField, Range(1, 100)] private int _gjkIterations = 20;
        [SerializeField, Range(1, 100)] private int _epaIterations = 20;
        [SerializeField, Range(1, 100)] private float _gravity = 0.01f;

        private SmfCollider[] _colliders;
        private PhysicSimulation<IRigidbody> _physicSimulation;

        private void Start()
        {
            _colliders = FindObjectsOfType<SmfCollider>();

            var collisionsWorld = new SMCollidersWorld<IRigidbody>(_gjkIterations, _epaIterations);

            _physicSimulation = new PhysicSimulation<IRigidbody>(collisionsWorld, new RigidbodyPositionSolver());

            foreach (var collider in _colliders)
            {
                collisionsWorld.Add(collider, collider.Rigidbody);
            }
        }

        private void FixedUpdate()
        {
            SoftVector3 gravity = SoftVector3.Down * (SoftFloat)_gravity * (SoftFloat)Time.deltaTime;

            foreach (var collider in _colliders)
            {
                IRigidbody colliderRigidbody = collider.Rigidbody;

                if (!colliderRigidbody.IsStatic)
                {
                    colliderRigidbody.Velocity += gravity;
                    colliderRigidbody.Position += colliderRigidbody.Velocity;
                }
            }

            _physicSimulation.Step((long)(Time.fixedDeltaTime * 1000f));
        }

        private void Update()
        {
            foreach (var collider in _colliders)
            {
                collider.Collided = false;
                collider.transform.position = collider.Centre.ToUnity();
            }

            foreach (var pair in _colliders.DistinctPairs((a, b) => (a, b)))
            {
                GjkAlgorithm.Result result = GjkAlgorithm.Calculate(pair.a, pair.b, _gjkIterations);

                if (result.CollisionHappened)
                {
                    pair.a.Collided = true;
                    pair.b.Collided = true;

                    // var epaResult = EpaAlgorithm.Calculate(result.Simplex, pair.a, pair.b, _epaIterations);

                    // foreach (var face in epaResult.polytopeFaces)
                    // {
                    //     Debug.DrawLine(epaResult.polytope[face.A].ToUnity(), epaResult.polytope[face.B].ToUnity(), Color.magenta);
                    //     Debug.DrawLine(epaResult.polytope[face.A].ToUnity(), epaResult.polytope[face.C].ToUnity(), Color.magenta);
                    //     Debug.DrawLine(epaResult.polytope[face.B].ToUnity(), epaResult.polytope[face.C].ToUnity(), Color.magenta);
                    // }

                    // Debug.DrawLine(epaResult.collision.Contacts[0].Position.ToUnity(),
                    //     (epaResult.collision.Contacts[0].Position + epaResult.collision.PenetrationNormal * epaResult.collision.PenetrationDepth).ToUnity(),
                    //     Color.cyan);
                }
            }
        }
    }
}
