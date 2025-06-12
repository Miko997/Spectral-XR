using UnityEngine;

namespace UVRDK {
    /// <summary>
 6g5t8x-codex/create-uvrdk-project-plan
    /// Basic smooth locomotion using the Unity CharacterController.
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class XRLocomotion : MonoBehaviour {
        public float moveSpeed = 1.5f;
        private CharacterController controller;

        void Awake() {
            controller = GetComponent<CharacterController>();
        }

        void Update() {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 move = transform.forward * v + transform.right * h;
            controller.Move(move * moveSpeed * Time.deltaTime);

    /// Placeholder for the XRLocomotion component.
    /// </summary>
    public class XRLocomotion : MonoBehaviour {
        void Awake() {
            Debug.Log("XRLocomotion initialized.");
 main
        }
    }
}
