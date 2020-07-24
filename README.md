# BlazorNavigationManagerExtensions
Blazor Navigation Manager Extensions is a simple set of extensions for the Navigation Manager

## Currently Available Extensions

`NavigateTo(this NavigationManager navManager, string uri, IDictionary<string, string> queryString, bool forceLoad = false)`

This extension simply allows to navigate to a page with query string parameters. The KeyValuePair will be made of the name of the query string parameter and its value.
