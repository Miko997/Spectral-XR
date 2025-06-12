using UnityEngine;

namespace UVRDK {
    /// <summary>
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
        }
    }
}
