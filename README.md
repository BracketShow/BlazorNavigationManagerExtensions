# BlazorNavigationManagerExtensions
Blazor Navigation Manager Extensions is a simple set of extensions for the Navigation Manager

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
`NavigateTo(this NavigationManager navManager, string uri, IDictionary<string, string> queryString, bool forceLoad = false)`
```

This extension simply allows to navigate to a page with query string parameters. The KeyValuePair will be made of the name of the query string parameter and its value.
