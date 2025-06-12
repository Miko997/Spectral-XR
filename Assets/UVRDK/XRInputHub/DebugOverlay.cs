using UnityEngine;
using UnityEngine.UI;

namespace UVRDK.Input {
    public class DebugOverlay : MonoBehaviour {
        public Text output;
        private XRInputHub hub;

        void Awake() {
            hub = GetComponent<XRInputHub>();
            if (hub == null) hub = gameObject.AddComponent<XRInputHub>();
        }

        void OnEnable() {
            foreach (var provider in GetComponents<MonoBehaviour>()) {
                if (provider is IXRInputProvider inputProvider)
                    hub.RegisterProvider(inputProvider);
            }
            foreach (var provider in GetComponentsInChildren<MonoBehaviour>()) {
                if (provider is IXRInputProvider inputProvider)
                    hub.RegisterProvider(inputProvider);
            }
        }

        void Start() {
            foreach (var provider in GetComponents<MonoBehaviour>())
                if (provider is IXRInputProvider ip)
                    ip.OnInputEvent += HandleEvent;
        }

        void HandleEvent(InputEvent evt) {
            if (output != null)
                output.text = $"{evt.Control}: {evt.Value:F2}";
        }
    }
}
