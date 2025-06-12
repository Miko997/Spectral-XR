using UnityEngine;

 6g5t8x-codex/create-uvrdk-project-plan
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
