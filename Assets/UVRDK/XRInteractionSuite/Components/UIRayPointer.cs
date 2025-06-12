using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UVRDK.Interaction {
    /// <summary>
    /// Simple laser pointer that sends click events to Unity UI.
    /// </summary>
    public class UIRayPointer : MonoBehaviour {
        public Camera pointerCamera;
        public float maxDistance = 10f;
        public LayerMask uiMask = -1;

        readonly List<RaycastResult> results = new();

        void Update() {
            if (pointerCamera == null || EventSystem.current == null)
                return;

            var eventData = new PointerEventData(EventSystem.current);
            Ray ray = new Ray(pointerCamera.transform.position, pointerCamera.transform.forward);
            eventData.position = pointerCamera.WorldToScreenPoint(ray.origin + ray.direction * maxDistance);
            results.Clear();
            EventSystem.current.RaycastAll(eventData, results);
            if (results.Count > 0 && Input.GetButtonDown("Fire1")) {
                ExecuteEvents.ExecuteHierarchy(results[0].gameObject, eventData, ExecuteEvents.pointerClickHandler);
            }
        }
    }
}
