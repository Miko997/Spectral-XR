# Ultimate VR Unity DevKit (UVRDK)

UVRDK is an MIT-licensed Unity package focused on removing the common hurdles of VR development. It provides a unified input system, physics based interactions, smooth locomotion, performance utilities, live iteration tools and optional networking support.

## Modules

- **XRInputHub** – collects input from multiple providers and exposes a common interface.
  Events from providers are normalised through an `InputMapper` and re-emitted so
  gameplay scripts only listen once.
- **XRInteractionSuite** – grab components, snap sockets and helpers for building interactive objects. Includes
  a simple UI laser pointer and climbing helper.
- **XRLocomotion** – smooth, teleport and dash locomotion components.
- **XRPerfManager** – dynamic resolution control, eye texture scaling and lightweight FPS display for performance testing.
- **XRLiveReload** – simple file watcher that logs changes during development.
- **XRNetCore** – UDP-based TransformBroadcaster and TransformReceiver for simple
  position replication.

## Project Plan

The full project plan, including goals and a 20‑week timeline, is documented in [PROJECT_PLAN.md](PROJECT_PLAN.md).

## Getting Started

Scripts are located under `Assets/UVRDK/`. Import the folder into a Unity project and add the desired components to your scene. The current implementation is an early foundation and will evolve over time.

### Quick Start

1. Create an empty GameObject and add `XRInputHub`, `XRLocomotion` and `XRPerfManager`.
2. Add `GrabInteractor` components to your hand controllers and place `GrabTarget` on any grabbable objects.
3. Optionally add `UIRayPointer` to a controller to interact with UI.

### Networking Example

Attach `TransformBroadcaster` to a moving object and `TransformReceiver` on
another instance to replicate position over UDP. Adjust the port and host fields
in the inspector as needed.

### Command Line Builds

The `Tools/BuildCLI.cs` file exposes a `BuildCLI.Build` method that can be invoked in batch mode to produce a sample standalone build:

```bash
unity -batchmode -executeMethod BuildCLI.Build -quit
```

### Version Control Notes

The repository includes a `.gitattributes` file to enforce consistent line endings across operating systems. This helps avoid merge conflicts when collaborating.

## Licence

UVRDK is released under the MIT licence. See [LICENSE](LICENSE) for details.
