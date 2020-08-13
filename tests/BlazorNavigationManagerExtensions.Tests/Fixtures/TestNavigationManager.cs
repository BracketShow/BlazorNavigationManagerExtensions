using Microsoft.AspNetCore.Components;

namespace BlazorNavigationManagerExtensions.Fixtures
{
    public class TestNavigationManager : NavigationManager
    {
        public TestNavigationManager(string baseUri, string uri)
        {
            Initialize(baseUri, uri);
        }

        public string NavigatedUri { get; private set; } = default!;

        public bool ForceLoad { get; private set; }

        protected override void NavigateToCore(string uri, bool forceLoad)
        {
            NavigatedUri = uri;
            ForceLoad = forceLoad;
        }
    }
}
