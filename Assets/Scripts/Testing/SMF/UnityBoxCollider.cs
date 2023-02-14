using System;
using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;
using UnityEngine;
using BoxCollider = GameLibrary.Physics.SupportMapping.BoxCollider;
using Rigidbody = GameLibrary.Physics.Rigidbody;
using SphereCollider = GameLibrary.Physics.SupportMapping.SphereCollider;

namespace SMF
{
    public class UnityBoxCollider : SmfCollider
    {
        [SerializeField] private Vector3 _extents = Vector3.one;
        [SerializeField] private bool _solidGizmo = false;

        private ISMCollider _smCollider;

        public override IRigidbody Rigidbody { get; set; }
        public override SoftVector3 Centre => _smCollider.Centre;

        private void Awake()
        {
            Rigidbody = new Rigidbody();
            Rigidbody.IsStatic = IsStatic;
            _smCollider = new DynamicCollider(Rigidbody, new BoxCollider(transform.position.ToSoft(), (_extents / 2f).ToSoft()));
        }

        public override SoftVector3 SupportPoint(SoftVector3 direction)
        {
            return _smCollider.SupportPoint(direction);
        }

        private void OnDrawGizmos()
        {
            if (Collided)
                Gizmos.color = Color.red;
            else
                Gizmos.color = Color.green;

            if (!_solidGizmo)
                Gizmos.DrawWireCube(transform.position, _extents);
            else
                Gizmos.DrawCube(transform.position, _extents);
        }
    }
}
