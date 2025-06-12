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
        }
    }
}
