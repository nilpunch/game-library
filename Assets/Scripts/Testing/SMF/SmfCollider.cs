using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;
using UnityEngine;

namespace SMF
{
    public abstract class SmfCollider : MonoBehaviour, ISMCollider
    {
        [field: SerializeField] public bool IsStatic { get; set; }

        public abstract IRigidbody Rigidbody { get; set; }

        public abstract SoftVector3 Centre { get; }
        public abstract SoftVector3 SupportPoint(SoftVector3 direction);

        public bool Collided { get; set; }
    }
}
