using UnityEngine;
using UnityEngine.XR;

namespace UVRDK {
    /// <summary>
    /// Adjusts eye texture resolution scale based on achieved frame rate.
    /// </summary>
    public class DynamicResolutionController : MonoBehaviour {
        public float minScale = 0.6f;
        public float maxScale = 1f;
        public float targetFPS = 90f;
        public float adjustSpeed = 0.05f;
        float deltaTime;

        void Update() {
            deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
            float fps = 1f / Mathf.Max(deltaTime, 0.0001f);
            float scale = XRSettings.eyeTextureResolutionScale;
            if (fps < targetFPS - 5f)
                scale = Mathf.Max(minScale, scale - adjustSpeed * Time.deltaTime);
            else if (fps > targetFPS + 5f)
                scale = Mathf.Min(maxScale, scale + adjustSpeed * Time.deltaTime);
            XRSettings.eyeTextureResolutionScale = scale;
        }
    }
}
