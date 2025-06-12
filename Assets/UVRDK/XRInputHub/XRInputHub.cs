        public InputMapper mapper;
        public event System.Action<InputEvent> OnInputEvent;

        void Awake() {
            if (mapper == null)
                mapper = ScriptableObject.CreateInstance<InputMapper>();
        }
            if (!providers.Contains(provider)) {
                provider.OnInputEvent += HandleProviderEvent;
            }
        }

        void OnDisable() {
            foreach (var p in providers)
                p.OnInputEvent -= HandleProviderEvent;
        }

        void HandleProviderEvent(InputEvent evt) {
            if (mapper != null && mapper.TryGetCommon(evt.Control, out var common))
                evt.Control = common;
            OnInputEvent?.Invoke(evt);
using System.Collections.Generic;
using UnityEngine;
using UVRDK.Input;

namespace UVRDK {
    /// <summary>
    /// Central hub that collects input from multiple providers and
    /// exposes them through a unified interface.
    /// </summary>
    public class XRInputHub : MonoBehaviour {
        private readonly List<IXRInputProvider> providers = new();

        /// <summary>
        /// Register a new input provider.
        /// </summary>
        public void RegisterProvider(IXRInputProvider provider) {
            if (!providers.Contains(provider))
                providers.Add(provider);
        }

        void Update() {
            foreach (var provider in providers)
                provider.Update();

using UnityEngine;

namespace UVRDK {
    /// <summary>
    /// Placeholder for the XRInputHub component.
    /// </summary>
    public class XRInputHub : MonoBehaviour {
        void Awake() {
            Debug.Log("XRInputHub initialized.");
 main
        }
    }
}
