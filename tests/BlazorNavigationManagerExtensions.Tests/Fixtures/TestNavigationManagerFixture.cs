namespace BlazorNavigationManagerExtensions.Fixtures
{
    public class TestNavigationManagerFixture
    {
        public TestNavigationManagerFixture()
        {
            NavigationManager = new TestNavigationManager(BaseUri, Uri);
        }

        public TestNavigationManager NavigationManager { get; }

        public string BaseUri => "https://localhost/";
        public string Uri => $"{BaseUri}/page";
    }
}
