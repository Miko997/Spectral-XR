# Ultimate VR Unity DevKit (UVRDK)

 qk9gpq-codex/create-uvrdk-project-plan

 6g5t8x-codex/create-uvrdk-project-plan
 main
UVRDK is an MIT-licensed Unity package focused on removing the common hurdles of VR development. It provides a unified input system, physics based interactions, smooth locomotion, performance utilities, live iteration tools and optional networking support.

## Modules

 qk9gpq-codex/create-uvrdk-project-plan
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

- **XRInputHub** – collects input from multiple providers and exposes a common interface. Includes device detection, input mapping and a debug overlay.
- **XRInteractionSuite** – grab components, snap sockets and helpers for building interactive objects.
- **XRLocomotion** – smooth and teleport locomotion components.
- **XRPerfManager** – dynamic resolution control and lightweight FPS display for performance testing.
- **XRLiveReload** – simple file watcher that logs changes during development.
- **XRNetCore** – minimal networking stub ready for expansion.
 main

## Project Plan

The full project plan, including goals and a 20‑week timeline, is documented in [PROJECT_PLAN.md](PROJECT_PLAN.md).

## Getting Started

Scripts are located under `Assets/UVRDK/`. Import the folder into a Unity project and add the desired components to your scene. The current implementation is an early foundation and will evolve over time.

 qk9gpq-codex/create-uvrdk-project-plan
### Quick Start

1. Create an empty GameObject and add `XRInputHub`, `XRLocomotion` and `XRPerfManager`.
2. Add `GrabInteractor` components to your hand controllers and place `GrabTarget` on any grabbable objects.
3. Optionally add `UIRayPointer` to a controller to interact with UI.

### Networking Example

Attach `TransformBroadcaster` to a moving object and `TransformReceiver` on
another instance to replicate position over UDP. Adjust the port and host fields
in the inspector as needed.


 main
### Command Line Builds

The `Tools/BuildCLI.cs` file exposes a `BuildCLI.Build` method that can be invoked in batch mode to produce a sample standalone build:

```bash
unity -batchmode -executeMethod BuildCLI.Build -quit
```

### Version Control Notes

The repository includes a `.gitattributes` file to enforce consistent line endings across operating systems. This helps avoid merge conflicts when collaborating.

 qk9gpq-codex/create-uvrdk-project-plan

UVRDK is an MIT-licensed Unity package that aims to eliminate the six universal blockers faced by VR developers:

1. Fragmented device input
2. Core physics & UI interactions
3. Locomotion and user comfort
4. Quest-grade performance tuning
5. Slow iteration and build cycles
6. Network-ready replication

This repository hosts the development of UVRDK. The project provides a single drag-and-drop prefab that works across Quest 3, Pico 5, Vive XR Elite, SteamVR and Vision Pro.

## Modules

* **XRInputHub** – Normalises controllers, hand tracking, eye gaze and haptics across devices.
* **XRInteractionSuite** – Prefabs for grabbing, UI pointers and other physics-based interactions.
* **XRLocomotion** – Smooth locomotion, teleport, seated origin shift and comfort profiles.
* **XRPerfManager** – Dynamic resolution, foveated rendering and performance HUD.
* **XRLiveReload** – Hot reload of assets and a command line build pipeline.
* **XRNetCore** – Photon Fusion and Unity NGO adapters for multiplayer replication.

## Roadmap

The 20‑week development timeline starts with repository bootstrap, automated CI and a demo scene. Full details are outlined in the project plan.

## Getting Started

This repo currently provides initial placeholders for all modules. Scripts can be found under `Assets/UVRDK/`. A full Unity project will be added in future commits.
 main

 main
## Licence

UVRDK is released under the MIT licence. See [LICENSE](LICENSE) for details.
