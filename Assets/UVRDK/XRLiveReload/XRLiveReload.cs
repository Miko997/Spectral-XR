using UnityEngine;
using System.IO;

namespace UVRDK {
    /// <summary>
    /// Watches the project folder for asset changes and logs them.
    /// </summary>
    public class XRLiveReload : MonoBehaviour {
        public string watchFolder = "Assets";
        private FileSystemWatcher watcher;

        void Start() {
            watcher = new FileSystemWatcher(watchFolder);
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            watcher.Changed += (s, e) => Debug.Log($"File changed: {e.FullPath}");
        }

        void OnDestroy() {
            if (watcher != null)
                watcher.Dispose();
        }
    }
}
