using UnityEngine;

namespace UVRDK.Interaction {
    /// <summary>
    /// Moves the character controller opposite to hand movement while a grab button is held.
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class LocomotionHandClimber : MonoBehaviour {
        public Transform hand;
        public string grabButton = "Fire1";

        CharacterController controller;
        bool climbing;
        Vector3 lastPos;

        void Awake() {
            controller = GetComponent<CharacterController>();
        }

        void Update() {
            if (Input.GetButtonDown(grabButton)) {
                climbing = true;
                lastPos = hand.position;
            }
            if (Input.GetButtonUp(grabButton)) {
                climbing = false;
            }
            if (climbing) {
                Vector3 delta = hand.position - lastPos;
                controller.Move(-delta);
                lastPos = hand.position;
            }
        }
    }
}
