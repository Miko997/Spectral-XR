using UnityEngine;

 qk9gpq-codex/create-uvrdk-project-plan

6g5t8x-codex/create-uvrdk-project-plan
 main
namespace UVRDK.Interaction {
    /// <summary>
    /// Provides simple grab interactions for VR objects.
    /// </summary>
    public class XRInteractionSuite : MonoBehaviour {
        public GrabInteractor leftHand;
        public GrabInteractor rightHand;

        void Awake() {
            if (leftHand == null || rightHand == null)
 qk9gpq-codex/create-uvrdk-project-plan
                Debug.LogWarning("GrabInteractors not assigned.");

                Debug.LogWarning("GrabInteractors not assigned.")
namespace UVRDK {
    /// <summary>
    /// Placeholder for the XRInteractionSuite component.
    /// </summary>
    public class XRInteractionSuite : MonoBehaviour {
        void Awake() {
            Debug.Log("XRInteractionSuite initialized.");
main
 main
        }
    }
}
