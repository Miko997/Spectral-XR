 qk9gpq-codex/create-uvrdk-project-plan

 6g5t8x-codex/create-uvrdk-project-plan
 main
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
 qk9gpq-codex/create-uvrdk-project-plan
        public InputMapper mapper;
        public event System.Action<InputEvent> OnInputEvent;

        void Awake() {
            if (mapper == null)
                mapper = ScriptableObject.CreateInstance<InputMapper>();
        }

 main

        /// <summary>
        /// Register a new input provider.
        /// </summary>
        public void RegisterProvider(IXRInputProvider provider) {
 qk9gpq-codex/create-uvrdk-project-plan
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

            if (!providers.Contains(provider))
                providers.Add(provider);
 main
        }

        void Update() {
            foreach (var provider in providers)
                provider.Update();
 qk9gpq-codex/create-uvrdk-project-plan


using UnityEngine;

namespace UVRDK {
    /// <summary>
    /// Placeholder for the XRInputHub component.
    /// </summary>
    public class XRInputHub : MonoBehaviour {
        void Awake() {
            Debug.Log("XRInputHub initialized.");
 main
 main
        }
    }
}
