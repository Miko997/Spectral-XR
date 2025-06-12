using UnityEngine;

namespace UVRDK {
    /// <summary>
    /// Basic smooth locomotion using the Unity CharacterController.
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class XRLocomotion : MonoBehaviour {
        public float moveSpeed = 1.5f;
        public float dashDistance = 3f;
        public float dashCooldown = 1f;
        private float dashTimer;
        private CharacterController controller;

        void Awake() {
            controller = GetComponent<CharacterController>();
        }

        void Update() {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 move = transform.forward * v + transform.right * h;
            controller.Move(move * moveSpeed * Time.deltaTime);

            if (dashTimer > 0f)
                dashTimer -= Time.deltaTime;
            if (Input.GetButtonDown("Jump") && dashTimer <= 0f) {
                controller.Move(transform.forward * dashDistance);
                dashTimer = dashCooldown;
            }
        }
    }
}
