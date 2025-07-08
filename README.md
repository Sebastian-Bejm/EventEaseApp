# Event Ease App

Note: there is an issue that sometimes happens when trying to run the app after cloning the repo, it will say a fatal error was encountered, library hostpolicy.dll was not found.
To resolve this, open the EventEase.csproj file and try to remove the following line inside PropertyGroup, try to build and run the app, if it fails to build/run, add the line back and build the app again: 

```
<PropertyGroup>
    <GenerateRuntimeConfigDevFile>true</GenerateRuntimeConfigDevFile>
</PropertyGroup>
```

This is not a definite fix but it should let the app run, but if the error still persists then create a new blazor wasm project called EventEase and move these folders and files to the new project:

Layout

Models

Pages

Services

App.razor

Program.cs
