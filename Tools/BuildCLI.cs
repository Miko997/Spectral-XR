#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Build.Reporting;

public static class BuildCLI {
    public static void Build() {
        var report = BuildPipeline.BuildPlayer(
            new[] { "Assets/UVRDK/README.md" },
            "Build/UVRDKSample.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None);
        if (report.summary.result != BuildResult.Succeeded)
            throw new System.Exception("Build failed: " + report.summary.result);
    }
}
#endif
