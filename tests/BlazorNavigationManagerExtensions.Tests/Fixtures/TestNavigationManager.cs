using Microsoft.AspNetCore.Components;

namespace BlazorNavigationManagerExtensions.Fixtures
{
    public class TestNavigationManager : NavigationManager
    {
        public TestNavigationManager(string baseUri, string uri)
        {
            Initialize(baseUri, uri);
        }

        public string NavigatedUri { get; set; } = default!;

        protected override void NavigateToCore(string uri, bool forceLoad)
        {
            NavigatedUri = uri;
        }
    }
}
