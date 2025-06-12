using UnityEngine;
using UnityEngine.XR;

namespace UVRDK {
    public class FFRController : MonoBehaviour {
        [Range(0.5f, 1.0f)] public float resolutionScale = 1f;
        public float adjustSpeed = 0.1f;

        void Update() {
            if (Input.GetKey(KeyCode.KeypadMinus))
                resolutionScale = Mathf.Max(0.5f, resolutionScale - adjustSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.KeypadPlus))
                resolutionScale = Mathf.Min(1f, resolutionScale + adjustSpeed * Time.deltaTime);

            XRSettings.eyeTextureResolutionScale = resolutionScale;
        }
    }
}
