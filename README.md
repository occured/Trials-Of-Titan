# Trials of Titan

> Source is provided as-is and is not currently maintained.

## What’s inside
- **Server**: `.NET` solution at `Server/Project-Titan/Project-Titan.sln` with `WebServer`, `World`, and `WorldGen` projects plus shared utilities.
- **Client**: Unity project in `Client/Project-Titan-Client`.
- **Database**: Local DynamoDB bundle under `Database/DynamoDb`.

## Prerequisites
- **Java**: JRE 19+ (e.g., the [JDK 19 installer](https://download.oracle.com/java/19/latest/jdk-19_windows-x64_bin.exe)).
- **.NET SDK**: .NET 6+ for building the server components.
- **Unity**: Tested on Unity **2019.4.3f1**; newer versions may work.
- **Windows**: Opening `Project-Titan.sln` and running local DynamoDB is expected primarily on Windows. Linux/macOS users should run server components via `dotnet` CLI and start DynamoDB with `java`.

## Database (DynamoDB Local)
1. Navigate to `Database/DynamoDb`.
2. Start DynamoDB Local (Java required). Examples:
   - Windows: run `run.bat`.
   - Cross-platform: `java -Djava.library.path=./DynamoDBLocal_lib -jar DynamoDBLocal.jar -sharedDb -inMemory`
3. Leave this process running while the server is active.

## Server
1. Open `Server/Project-Titan/Project-Titan.sln` **as administrator** in Visual Studio, or use CLI:
   - `cd Server/Project-Titan`
   - `dotnet restore`
   - `dotnet build`
   - `dotnet run --project WebServer/WebServer.csproj` (or run the `Run.Local.All` project in the solution)
2. Ensure the server points at the locally running DynamoDB instance (default local endpoint with `-sharedDb` is recommended).

## Client
1. Open `Client/Project-Titan-Client` in Unity (2019.4.3f1 recommended).
2. Load the entry scene documented in `Client/Project-Titan-Client/README.md`.
3. Configure the client to point at your local server endpoint if necessary.
4. Play:
   1. Register with any email and password.
   2. Press **I verified**.
   3. Choose a name.
   4. Create a character and play.
