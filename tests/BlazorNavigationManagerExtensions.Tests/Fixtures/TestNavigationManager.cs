using System;
using Microsoft.AspNetCore.Components;

namespace BlazorNavigationManagerExtensions.Fixtures
{
    public class TestNavigationManager : NavigationManager
    {
        public TestNavigationManager(Uri baseUri, Uri uri)
        {
            Initialize(baseUri.ToString(), uri.ToString());
        }

        public Uri NavigatedUri { get; private set; } = default!;

        protected override void NavigateToCore(string uri, bool forceLoad)
        {
            NavigatedUri = new Uri(uri);
        }
    }
}
