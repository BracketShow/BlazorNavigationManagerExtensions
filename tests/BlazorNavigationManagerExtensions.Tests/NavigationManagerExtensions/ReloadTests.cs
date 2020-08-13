using BlazorNavigationManagerExtensions.Fixtures;
using FluentAssertions;
using Xunit;

namespace BlazorNavigationManagerExtensions.NavigationManagerExtensions
{
    public class ReloadTests : IClassFixture<TestNavigationManagerFixture>
    {
        private readonly TestNavigationManager navigationManager;

        public ReloadTests(TestNavigationManagerFixture navigationManagerFixture)
        {
            navigationManager = navigationManagerFixture.NavigationManager;
        }

        [Fact]
        public void Reload_ShouldNavigateToTheCurrentUri()
        {
            var currentPage = navigationManager.Uri;

            navigationManager.Reload();

            navigationManager.NavigatedUri.Should().Be(currentPage);
        }

        [Fact]
        public void Reload_ShouldForceLoad()
        {
            navigationManager.Reload();

            navigationManager.ForceLoad.Should().BeTrue();
        }
    }
}