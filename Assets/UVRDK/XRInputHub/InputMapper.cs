using System.Collections.Generic;
using UnityEngine;

namespace UVRDK.Input {
    [CreateAssetMenu(fileName = "InputMapper", menuName = "UVRDK/Input Mapper")]
    public class InputMapper : ScriptableObject {
        [System.Serializable]
        public class MapEntry {
            public string deviceControl;
            public string commonControl;
        }

        public List<MapEntry> mappings = new();

        private Dictionary<string, string> lookup;

        public void BuildLookup() {
            lookup = new Dictionary<string, string>();
            foreach (var m in mappings)
                lookup[m.deviceControl] = m.commonControl;
        }

        public bool TryGetCommon(string deviceControl, out string common) {
            if (lookup == null) BuildLookup();
            return lookup.TryGetValue(deviceControl, out common);
        }
    }
}
