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
        public InputMapper mapper;
        public event System.Action<InputEvent> OnInputEvent;

        void Awake() {
            if (mapper == null)
                mapper = ScriptableObject.CreateInstance<InputMapper>();
        }

        /// <summary>
        /// Register a new input provider.
        /// </summary>
        public void RegisterProvider(IXRInputProvider provider) {
            if (!providers.Contains(provider)) {
                providers.Add(provider);
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
        }

        void Update() {
            foreach (var provider in providers)
                provider.Update();
        }
    }
}
