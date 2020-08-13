namespace BlazorNavigationManagerExtensions.Fixtures
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class TestNavigationManagerFixture
    {
        public TestNavigationManagerFixture()
        {
            NavigationManager = new TestNavigationManager(BaseUri, Uri);
        }

        public static string BaseUri => "https://localhost/";

        public static string Uri => $"{BaseUri}/page";

        public TestNavigationManager NavigationManager { get; }
    }
}
