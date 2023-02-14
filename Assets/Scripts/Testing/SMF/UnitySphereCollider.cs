using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;
using UnityEngine;
using BoxCollider = UnityEngine.BoxCollider;
using Rigidbody = GameLibrary.Physics.Rigidbody;
using SphereCollider = GameLibrary.Physics.SupportMapping.SphereCollider;

namespace SMF
{
    public class UnitySphereCollider : SmfCollider
    {
        [SerializeField] private float _radius = 1f;

        private ISMCollider _smCollider;

        public override IRigidbody Rigidbody { get; set; }
        public override SoftVector3 Centre => _smCollider.Centre;

        private void Awake()
        {
            Rigidbody = new Rigidbody();
            Rigidbody.IsStatic = IsStatic;
            _smCollider = new DynamicCollider(Rigidbody, new SphereCollider(transform.position.ToSoft(), (SoftFloat)_radius));
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

            Gizmos.DrawWireSphere(transform.position, _radius);
        }
    }
}
