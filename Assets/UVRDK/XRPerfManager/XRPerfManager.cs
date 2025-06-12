using UnityEngine;
 6g5t8x-codex/create-uvrdk-project-plan
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


namespace UVRDK {
    /// <summary>
    /// Placeholder for the XRPerfManager component.
    /// </summary>
    public class XRPerfManager : MonoBehaviour {
        void Awake() {
            Debug.Log("XRPerfManager initialized.");
 main
        }
    }
}
