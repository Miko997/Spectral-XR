using UnityEngine;

namespace UVRDK.Interaction {
    /// <summary>
    /// Provides simple grab interactions for VR objects.
    /// </summary>
    public class XRInteractionSuite : MonoBehaviour {
        public GrabInteractor leftHand;
        public GrabInteractor rightHand;

        void Awake() {
            if (leftHand == null || rightHand == null)
                Debug.LogWarning("GrabInteractors not assigned.");
        }
    }
}
