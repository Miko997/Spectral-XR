using UnityEngine;

namespace UVRDK.Interaction {
    [RequireComponent(typeof(Rigidbody))]
    public class GrabTarget : MonoBehaviour {
        public Rigidbody Rb { get; private set; }

        void Awake() {
            Rb = GetComponent<Rigidbody>();
        }
    }
}
