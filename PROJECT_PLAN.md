# Ultimate VR Unity DevKit (UVRDK) – Comprehensive Project Plan

**Date:** 12 June 2025
**Author:** Miko Parkkinen

## Executive Summary

UVRDK is an open source, MIT licensed Unity package that eliminates six universal blockers every VR developer faces: fragmented device input, core physics and UI interactions, locomotion and user comfort, performance tuning, slow iteration cycles and network ready replication. By shipping a single drag-and-drop prefab that works across Quest 3, Pico 5, Vive XR Elite, SteamVR and Vision Pro, UVRDK aims for wide adoption and community growth.

## Goals & Success Criteria

- \>=3 000 installs on OpenUPM / Asset Store within 12 months post launch.
- \>=700 GitHub stars and 20 external pull requests merged.
- Maintain <0.25 ms CPU overhead and \>=90 Hz on Quest 3 demo scene.
- One command build pipeline outputs APK (Quest), Windows OpenXR and macOS Vision Pro IPA.
- Sample multiplayer scene with lag-compensated grab passes a 60 ms network jitter test.

## Scope & Feature Breakdown

### Module 1 – Cross Device Input Hub (XRInputHub)
- DeviceDetector (native plugin + C# wrapper)
- InputMapper (ScriptableObject profile per device)
- DebugOverlay (in-editor visualiser)
- Supports Quest 3, OpenXR PC, Pico 5, Vive XR Elite and Vision Pro at launch.

### Module 2 – Physics & UI Interaction Suite (XRInteractionSuite)
- GrabInteractor, GrabTarget
- SocketAnchor, SocketSnapper
- LocomotionHandClimber
- UIRayPointer, UIPokePointer

### Module 3 – Locomotion & Comfort System (XRLocomotion)
- Smooth locomotion, teleport, dash, climbing, flight
- Comfort profiles (vignette, FOV reduction)
- Seated origin shift and guardian boundary awareness

### Module 4 – 90 Hz Performance Manager (XRPerfManager)
- Dynamic Resolution & Fixed Foveated Rendering control
- In-headset performance HUD
- Adaptive quality scaler

### Module 5 – Live Iteration & Build CLI (XRLiveReload)
- In-editor simulator input
- Wi‑Fi hot reload of changed assets and assemblies
- CLI `uvrdk build` that outputs and signs platform binaries

### Module 6 – Network Ready Replication Core (XRNetCore)
- Photon Fusion and Unity NGO adapters
- Lag compensated grab/throw with authoritative hand off
- Voice chat prefab using platform spatial audio APIs

## Development Timeline (20 Week Sprint Map)
1. **Week 1** – Repository bootstrap, README, licence, CI skeleton.
2. **Weeks 2‑4** – Build XRInputHub, device profiles, integration tests; demo scene validation on Quest 3 + PC.
3. **Weeks 5‑7** – Implement XRInteractionSuite; profiling on Quest 3 physics budget.
4. **Weeks 8‑9** – XRLocomotion; automated comfort profile toggles.
5. **Weeks 10‑12** – XRPerfManager; GPU timing validation.
6. **Weeks 13‑15** – XRLiveReload; multi target CLI.
7. **Weeks 16‑17** – XRNetCore; client authority transfer tests.
8. **Week 18** – Sample scene "Robot Repair VR" integrating all modules; cross device test matrix.
9. **Weeks 19‑20** – Documentation, OpenUPM publish, marketing launch.

## Architecture Overview

```
Quest 3 / Vision Pro / PC VR
    Unity Player
        UVRDK Starter Prefab
            XRInputHub
            XRInteractionSuite
            XRLocomotion
            XRPerfManager
            XRLiveReload (Editor only)
            XRNetCore (optional)
```

CI/CD: GitHub Actions → Cloud Build runner → APK/EXE/IPA artifacts.

## Testing & Quality Gates

- 80 % line coverage with Unity TestRunner.
- Sonar "A" grade (≤3 % code smells, 0 critical issues).
- Automated Quest 3 frame rate test; build fails if average FPS <90 or CPU overhead >0.25 ms.

## Documentation Plan

- Quick Start (10 min) – install, drag prefab, build to headset.
- Module guides – one page per module with example code.
- API reference – generated with DocFX.
- Video series – setup, interaction, locomotion, performance, multiplayer.

## Community & Governance

- MIT licence and Contributor Covenant Code of Conduct.
- GitHub Discussions for Q&A; Discord server for live chat.
- Maintainer RFC process; semantic versioned roadmap; "good first issue" label for onboarding.

## Risk Management

- Vendor SDK changes – mitigation: weekly CI against beta SDKs.
- Scope creep – mitigation: MoSCoW per module; lock feature freeze week 14.
- Performance regression – mitigation: automated performance tests in CI.

## Glossary

- FFR: Fixed Foveated Rendering
- NGO: Netcode for GameObjects
- RTT: Round Trip Time
- PRD: Product Requirements Document
