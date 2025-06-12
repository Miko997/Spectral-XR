using UnityEngine;

namespace UVRDK.Interaction {
    [RequireComponent(typeof(Collider))]
    public class SnapSocket : MonoBehaviour {
        public Transform snapPoint;
        private GrabTarget current;

        void OnTriggerEnter(Collider other) {
            var target = other.GetComponent<GrabTarget>();
            if (target != null && current == null) {
                current = target;
                target.transform.position = snapPoint.position;
                target.transform.rotation = snapPoint.rotation;
                if (target.Rb != null) {
                    target.Rb.velocity = Vector3.zero;
                    target.Rb.angularVelocity = Vector3.zero;
                    target.Rb.isKinematic = true;
                }
            }
        }

        void OnTriggerExit(Collider other) {
            if (other.GetComponent<GrabTarget>() == current) {
                if (current.Rb != null) current.Rb.isKinematic = false;
                current = null;
            }
        }
    }
}
