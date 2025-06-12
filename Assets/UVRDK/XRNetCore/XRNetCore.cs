using UnityEngine;

namespace UVRDK.Network {
    /// <summary>
    /// Minimal network stub for sending player state. See
    /// <see cref="TransformBroadcaster"/> and <see cref="TransformReceiver"/> for
    /// a basic example of position replication.
    /// </summary>
    public class XRNetCore : MonoBehaviour {
        public void SendState(Vector3 position) {
            Debug.Log($"Send position {position}");
        }
    }
}
