using UnityEngine;
using UnityEngine.AI;

namespace UVRDK {
    public class TeleportLocomotion : MonoBehaviour {
        public LayerMask teleportMask = -1;
        public Transform playerRoot;
        public LineRenderer teleportLine;
        public float maxDistance = 10f;
        private bool isAiming;

        void Update() {
            if (Input.GetButtonDown("Fire2")) isAiming = true;
            if (Input.GetButtonUp("Fire2")) {
                TryTeleport();
                isAiming = false;
                teleportLine.enabled = false;
            }

            if (isAiming) {
                UpdateLine();
            }
        }

        void UpdateLine() {
            if (teleportLine == null) return;
            teleportLine.enabled = true;
            Ray ray = new Ray(playerRoot.position, playerRoot.forward);
            teleportLine.SetPosition(0, ray.origin);
            teleportLine.SetPosition(1, ray.origin + ray.direction * maxDistance);
        }

        void TryTeleport() {
            Ray ray = new Ray(playerRoot.position, playerRoot.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, teleportMask)) {
                playerRoot.position = hit.point;
            }
        }
    }
}
