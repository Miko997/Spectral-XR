using UnityEngine;

    /// Minimal network stub for sending player state. See
    /// <see cref="TransformBroadcaster"/> and <see cref="TransformReceiver"/> for
    /// a basic example of position replication.
namespace UVRDK.Network {
    /// <summary>
    /// Minimal network stub for sending player state.
    /// </summary>
    public class XRNetCore : MonoBehaviour {
        public void SendState(Vector3 position) {
            Debug.Log($"Send position {position}");

namespace UVRDK {
    /// <summary>
    /// Placeholder for the XRNetCore component.
    /// </summary>
    public class XRNetCore : MonoBehaviour {
        void Awake() {
            Debug.Log("XRNetCore initialized.");
 main
        }
    }
}
