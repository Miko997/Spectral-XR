using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace UVRDK.Input {
    public class UnityXRInputProvider : MonoBehaviour, IXRInputProvider {
        public event System.Action<InputEvent> OnInputEvent;
        private InputDevice leftHand;
        private InputDevice rightHand;

        void Start() {
            var leftHandDevices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, leftHandDevices);
            if (leftHandDevices.Count > 0)
                leftHand = leftHandDevices[0];

            var rightHandDevices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightHandDevices);
            if (rightHandDevices.Count > 0)
                rightHand = rightHandDevices[0];
        }

        public void PollInput() {
            if (leftHand.isValid && leftHand.TryGetFeatureValue(CommonUsages.trigger, out float leftTrigger)) {
                OnInputEvent?.Invoke(new InputEvent {
                    Type = InputEventType.Axis,
                    Control = "LeftTrigger",
                    Value = leftTrigger
                });
            }

            if (rightHand.isValid && rightHand.TryGetFeatureValue(CommonUsages.trigger, out float rightTrigger)) {
                OnInputEvent?.Invoke(new InputEvent {
                    Type = InputEventType.Axis,
                    Control = "RightTrigger",
                    Value = rightTrigger
                });
            }
        }
    }
}
