using System;

namespace UVRDK.Input {
    public enum InputEventType {
        ButtonDown,
        ButtonUp,
        Axis
    }

    public struct InputEvent {
        public InputEventType Type;
        public string Control;
        public float Value;
    }

    public interface IXRInputProvider {
        event Action<InputEvent> OnInputEvent;
        void PollInput();
    }
}
