# Ultimate VR Unity DevKit (UVRDK)

UVRDK is an MIT-licensed Unity package focused on removing the common hurdles of VR development. It provides a unified input system, physics based interactions, smooth locomotion, performance utilities, live iteration tools and optional networking support.

## Modules

- **XRInputHub** – collects input from multiple providers and exposes a common interface. Includes device detection, input mapping and a debug overlay.
- **XRInteractionSuite** – grab components, snap sockets and helpers for building interactive objects.
- **XRLocomotion** – smooth and teleport locomotion components.
- **XRPerfManager** – dynamic resolution control and lightweight FPS display for performance testing.
- **XRLiveReload** – simple file watcher that logs changes during development.
- **XRNetCore** – minimal networking stub ready for expansion.

## Project Plan

The full project plan, including goals and a 20‑week timeline, is documented in [PROJECT_PLAN.md](PROJECT_PLAN.md).

## Getting Started

Scripts are located under `Assets/UVRDK/`. Import the folder into a Unity project and add the desired components to your scene. The current implementation is an early foundation and will evolve over time.

### Command Line Builds

The `Tools/BuildCLI.cs` file exposes a `BuildCLI.Build` method that can be invoked in batch mode to produce a sample standalone build:

```bash
unity -batchmode -executeMethod BuildCLI.Build -quit
```

## Licence

UVRDK is released under the MIT licence. See [LICENSE](LICENSE) for details.
