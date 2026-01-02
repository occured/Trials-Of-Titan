# Project Titan Client (Unity)

## Requirements
- Unity **2019.4.3f1** (tested). Later 2019 LTS versions may work but are unverified.
- Server running locally (see repo root README for server + DynamoDB setup).

## Opening the project
1. Launch Unity Hub and add `Client/Project-Titan-Client` as a project.
2. Open with Unity 2019.4.3f1 for best compatibility.

## Entry scene
- Load the main menu/entry scene specified for your branch. If unsure, search `Assets` for `Menu` or `Login` scenes and open the one used by default.

## Pointing to a local server
- If the client expects a configurable endpoint, update the API/base URL in the relevant configuration script or ScriptableObject (commonly under `Assets` for network settings) to your local server address (e.g., `http://localhost:<port>`).

## Quick playtest flow
1. Press **Play** in the Unity editor.
2. Register with any email and password.
3. Press **I verified**.
4. Choose a name.
5. Create a character and start playing.

## Logs
- Client logs are written to the `Logs` directory within this project.
