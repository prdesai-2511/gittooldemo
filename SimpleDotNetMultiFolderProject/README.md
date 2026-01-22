# Simple .NET (C#) Project — Multi-folder

A minimal .NET 8 console app with a clean folder layout (`src/` and `tests/`).

## Structure

```text
SimpleDotNetMultiFolderProject/
├─ src/
│  └─ MyApp/
│     ├─ Models/
│     │  └─ AppOptions.cs
│     ├─ Services/
│     │  ├─ ConsoleGreeter.cs
│     │  └─ IGreeter.cs
│     ├─ appsettings.json
│     ├─ MyApp.csproj
│     └─ Program.cs
├─ tests/
│  └─ MyApp.Tests/
│     ├─ MyApp.Tests.csproj
│     └─ SampleTests.cs
└─ MyApp.sln
```

## Build & Run

1. Install the .NET 8 SDK from https://dotnet.microsoft.com/download
2. In a terminal at the solution root:
   ```bash
   dotnet build
   dotnet run --project src/MyApp/MyApp.csproj
   ```

## Test

```bash
dotnet test
```

## Customize
- Edit `src/MyApp/appsettings.json` to change the greeting and name.
- Add new services in `src/MyApp/Services/` and inject where needed.
- Add more unit tests under `tests/MyApp.Tests/`.
