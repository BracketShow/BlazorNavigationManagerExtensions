using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;

namespace BlazorNavigationManagerExtensions
{
    public static class NavigationManagerExtensions
    {
        public static void NavigateTo(this NavigationManager navManager, string uri, IDictionary<string, string> queryString, bool forceLoad = false)
        {
            navManager.NavigateTo(QueryHelpers.AddQueryString(uri, queryString), forceLoad);
        }
    }
}
