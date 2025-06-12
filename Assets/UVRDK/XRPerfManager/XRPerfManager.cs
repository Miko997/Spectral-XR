using UnityEngine;
using UnityEngine.UI;

namespace UVRDK {
    /// <summary>
    /// Displays a simple FPS counter in a UI Text element.
    /// </summary>
    public class XRPerfManager : MonoBehaviour {
        public Text hudText;
        private float deltaTime;

        void Update() {
            deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
            if (hudText != null) {
                float fps = 1f / deltaTime;
                hudText.text = $"FPS: {fps:F1}";
            }
        }
    }
}
