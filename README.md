# Ultimate VR Unity DevKit (UVRDK)

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

## Licence

UVRDK is released under the MIT licence. See [LICENSE](LICENSE) for details.
