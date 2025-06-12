using UnityEngine;

namespace UVRDK.Network {
    /// <summary>
    /// Minimal network stub for sending player state.
    /// </summary>
    public class XRNetCore : MonoBehaviour {
        public void SendState(Vector3 position) {
            Debug.Log($"Send position {position}");
        }
    }
}
