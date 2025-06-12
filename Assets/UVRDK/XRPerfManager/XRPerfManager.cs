using UnityEngine;
 qk9gpq-codex/create-uvrdk-project-plan

 6g5t8x-codex/create-uvrdk-project-plan
 main
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
 qk9gpq-codex/create-uvrdk-project-plan



namespace UVRDK {
    /// <summary>
    /// Placeholder for the XRPerfManager component.
    /// </summary>
    public class XRPerfManager : MonoBehaviour {
        void Awake() {
            Debug.Log("XRPerfManager initialized.");
 main
 main
        }
    }
}
