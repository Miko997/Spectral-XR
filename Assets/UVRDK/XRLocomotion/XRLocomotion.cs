using UnityEngine;

namespace UVRDK {
    /// <summary>
 qk9gpq-codex/create-uvrdk-project-plan

 6g5t8x-codex/create-uvrdk-project-plan
 main
    /// Basic smooth locomotion using the Unity CharacterController.
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class XRLocomotion : MonoBehaviour {
        public float moveSpeed = 1.5f;
 qk9gpq-codex/create-uvrdk-project-plan
        public float dashDistance = 3f;
        public float dashCooldown = 1f;
        private float dashTimer;

 main
        private CharacterController controller;

        void Awake() {
            controller = GetComponent<CharacterController>();
        }

        void Update() {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 move = transform.forward * v + transform.right * h;
            controller.Move(move * moveSpeed * Time.deltaTime);

 qk9gpq-codex/create-uvrdk-project-plan
            if (dashTimer > 0f)
                dashTimer -= Time.deltaTime;
            if (Input.GetButtonDown("Jump") && dashTimer <= 0f) {
                controller.Move(transform.forward * dashDistance);
                dashTimer = dashCooldown;
            }

    /// Placeholder for the XRLocomotion component.
    /// </summary>
    public class XRLocomotion : MonoBehaviour {
        void Awake() {
            Debug.Log("XRLocomotion initialized.");
 main
 main
        }
    }
}
