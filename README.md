# Event Ease App

Note: there is an issue that sometimes when trying to run the it will say a fatal error has occured.
To resolve this, go into the EventEase.csproj file and add the following line inside PropertyGroup:

```
<PropertyGroup>
    <GenerateRuntimeConfigDevFile>true</GenerateRuntimeConfigDevFile>
</PropertyGroup>
```

This should let the app run, but if the error still persists then create a new blazor wasm project called EventEase and move these folders and files to the new project:

Layout

Models

Pages

Services

Program.cs