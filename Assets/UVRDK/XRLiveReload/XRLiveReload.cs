using UnityEngine;
 qk9gpq-codex/create-uvrdk-project-plan

 6g5t8x-codex/create-uvrdk-project-plan
 main
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
 qk9gpq-codex/create-uvrdk-project-plan



namespace UVRDK {
    /// <summary>
    /// Placeholder for the XRLiveReload component.
    /// </summary>
    public class XRLiveReload : MonoBehaviour {
        void Awake() {
            Debug.Log("XRLiveReload initialized.");
 main
 main
        }
    }
}
