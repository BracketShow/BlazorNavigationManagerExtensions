using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;

namespace BlazorNavigationManagerExtensions
{
    public static class NavigationManagerExtensions
    {
        /// <summary>
        /// Navigates to the specified URI with the given query string parameters.
        /// </summary>
        /// <param name="navManager">The NavigationManager instance.</param>
        /// <param name="uri">The destination URI. This can be absolute, or relative to the base URI (as returned by Microsoft.AspNetCore.Components.NavigationManager.BaseUri).</param>
        /// <param name="queryString">The query string parameters, with the key representing the parameter name and the value for the value itself.</param>
        /// <param name="forceLoad">If true, bypasses client-side routing and forces the browser to load the new page from the server,
        /// whether or not the URI would normally be handled by the client-side router.</param>
        public static void NavigateTo(this NavigationManager navManager, string uri, IDictionary<string, string> queryString, bool forceLoad = false)
        {
            navManager.NavigateTo(QueryHelpers.AddQueryString(uri, queryString), forceLoad);
        }

        /// <summary>
        /// Navigates to the specified URI with the given query string parameters.
        /// </summary>
        /// <param name="navManager">The NavigationManager instance.</param>
        /// <param name="uri">The destination URI. This can be absolute, or relative to the base URI (as returned by Microsoft.AspNetCore.Components.NavigationManager.BaseUri).</param>
        /// <param name="queryString">The query string parameters, with the key representing the parameter name and the value for the value itself.</param>
        /// <param name="forceLoad">If true, bypasses client-side routing and forces the browser to load the new page from the server,
        /// whether or not the URI would normally be handled by the client-side router.</param>
        public static void NavigateTo(this NavigationManager navManager, Uri uri, IDictionary<string, string> queryString, bool forceLoad = false)
        {
            navManager.NavigateTo(QueryHelpers.AddQueryString(uri.ToString(), queryString), forceLoad);
        }
    }
}
