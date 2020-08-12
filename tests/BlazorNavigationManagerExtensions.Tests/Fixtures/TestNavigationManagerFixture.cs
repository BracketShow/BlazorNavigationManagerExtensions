using System;

namespace BlazorNavigationManagerExtensions.Fixtures
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class TestNavigationManagerFixture
    {
        public TestNavigationManagerFixture()
        {
            NavigationManager = new TestNavigationManager(BaseUri, Uri);
        }

        public static Uri BaseUri => new Uri("https://localhost/");

        public static Uri Uri => new Uri($"{BaseUri}/page");

        public TestNavigationManager NavigationManager { get; }
    }
}
