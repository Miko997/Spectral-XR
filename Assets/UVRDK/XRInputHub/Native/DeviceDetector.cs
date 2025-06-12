using UnityEngine;
using UnityEngine.XR;

namespace UVRDK.Input {
    public enum XRDeviceType {
        Unknown,
        Quest,
        Pico,
        Vive,
        VisionPro,
        OpenXR
    }

    public static class DeviceDetector {
        public static XRDeviceType GetDeviceType() {
            var loaded = XRSettings.loadedDeviceName.ToLower();
            if (loaded.Contains("oculus")) return XRDeviceType.Quest;
            if (loaded.Contains("pico")) return XRDeviceType.Pico;
            if (loaded.Contains("vive")) return XRDeviceType.Vive;
            if (loaded.Contains("vision")) return XRDeviceType.VisionPro;
            if (loaded.Contains("openxr")) return XRDeviceType.OpenXR;
            return XRDeviceType.Unknown;
        }
    }
}
