using UnityEngine;

namespace UVRDK.Interaction {
    public class GrabInteractor : MonoBehaviour {
        private GrabTarget currentTarget;
        private bool isGrabbing;

        void Update() {
            if (isGrabbing && currentTarget) {
                currentTarget.transform.position = transform.position;
            }
        }

        public void BeginGrab(GrabTarget target) {
            currentTarget = target;
            isGrabbing = true;
        }

        public void EndGrab() {
            isGrabbing = false;
            currentTarget = null;
        }

        void OnTriggerEnter(Collider other) {
            var target = other.GetComponent<GrabTarget>();
            if (target != null && !isGrabbing) {
                BeginGrab(target);
            }
        }

        void OnTriggerExit(Collider other) {
            var target = other.GetComponent<GrabTarget>();
            if (target == currentTarget) {
                EndGrab();
            }
        }
    }
}
