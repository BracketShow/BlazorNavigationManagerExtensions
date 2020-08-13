# BlazorNavigationManagerExtensions
Blazor Navigation Manager Extensions is a simple set of extensions for the Navigation Manager

![Build & Test Main](https://github.com/BracketShow/BlazorNavigationManagerExtensions/workflows/Build%20&%20Test%20Master/badge.svg)

![Nuget](https://img.shields.io/nuget/v/bracketshow.blazornavigationmanagerextensions.svg)

## Installation

You can install the package with the Nuget Package Manager by searching for *BracketShow.BlazorNavigationManagerExtensions*.

You can also install it with Powershell by running the following command:

```powershell
Install-Package BracketShow.BlazorNavigationManagerExtensions
```

Or by using the dotnet CLI with the following command:

```bash
dotnet add package BracketShow.BlazorNavigationManagerExtensions
```

## Usage

To use any of the extensions, add the following using statement where the extension is required:

```csharp
using BlazorNavigationManagerExtensions;
```

## Currently Available Extensions

### NavigateTo With Query String parameters
```csharp
NavigateTo(this NavigationManager navManager, string uri, IDictionary<string, string> queryString, bool forceLoad = false)
```

This extension simply allows to navigate to a page with query string parameters. The KeyValuePair will be made of the name of the query string parameter and its value.

### Reload
```csharp
Reload(this NavigationManager navManager)
```

This extension reloads the application to the current URI by using the `forceLoad` flag to force the page to reload from the server.