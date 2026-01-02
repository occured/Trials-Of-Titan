# Project Titan Server

The server solution powers the Trials of Titan backend. Open `Project-Titan.sln` to access the following projects:

- **WebServer/**: HTTP/API entry point for the game client.
- **World/**: Game simulation, entities, and world state.
- **WorldGen/**: World generation utilities.
- **TitanDatabase/**: Data-access layer for DynamoDB.
- **Run.Local.All**: Convenience target to run the local stack from Visual Studio.
- **Shared utilities**: Common code for cryptology, geometry, IO, logging, modules, networking, spatial partitioning, pathfinding, and general helpers.

## Prerequisites
- .NET 6+ SDK
- Local DynamoDB instance running (see repo root README for startup commands)

## Build and run (CLI)
```bash
cd Server/Project-Titan
dotnet restore
dotnet build
dotnet run --project WebServer/WebServer.csproj
```

To run everything from Visual Studio, open `Project-Titan.sln` **as administrator** and run the `Run.Local.All` project.

## Configuration
- Ensure the WebServer is configured to point to your local DynamoDB endpoint (typically `http://localhost:8000` when started with `-sharedDb`).
- If you change ports or database endpoints, align the Unity client configuration accordingly.
