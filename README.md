# FSharp Manual Template

# Setup

- .net core 3.1
- nuget 4.94
   - Later versions of nuget don't seem to work on with the .net that is available to linux right now.
- ionide plugin in vscode

## Linux:
- Install `dotnet`: https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-ubuntu-1804
- Install `nuget`: https://www.nuget.org/downloads
- Install Ionide VSCode plugin: https://github.com/ionide/ionide-vscode-fsharp

# Commands
- `dotnet build` for building
- `dotnet run` for running
- `nuget.exe install FSharp.Data` to install a package (i.e. FSharp.Data)


# Notes
- dotnet command is the main one: https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-ubuntu-1804
- .net v 3.1 is available so far
- nuget is the package manager: https://www.nuget.org/downloads
- nuget is available in repos but its old. Most things are run with `dotnet foo` but this is "self
contained" and can be run directly like anything else: https://github.com/dotnet/cli/issues/6472
- Not sure if I would ever use mono now
- Make a project with `dotnet new console -lang f#`
- Install dep with `nuget.exe install FSharp.Data`
- Build with `dotnet build`
- Run with `dotnet run`
- Need to manually update the .fsproj file to add dependencies from nuget with this. This is an MSBuild file. Docs at https://docs.microsoft.com/en-us/aspnet/web-forms/overview/deployment/web-deployment-in-the-enterprise/understanding-the-project-file
```xml
  <ItemGroup>
    <Reference Include="./FSharp.Data.3.3.2/lib/net45/FSharp.Data.dll" />
  </ItemGroup>
```
- Forge exists to manage these files but it isn't a well run project. The domain name has been
expired for a month and no one seems to care. https://github.com/ionide/Forge/issues/130
- Forge was apparently Projekt? Projekt is deprecated and all SEO for the .fsproj file points to
it rather than details about what can go into a .fsproj file.

