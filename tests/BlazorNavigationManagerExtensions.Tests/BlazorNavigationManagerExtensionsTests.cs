using BlazorNavigationManagerExtensions.Fixtures;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace BlazorNavigationManagerExtensions
{
    public class BlazorNavigationManagerExtensionsTests : IClassFixture<TestNavigationManagerFixture>
    {
        private readonly string uri;

        private readonly TestNavigationManager navigationManager;

        public BlazorNavigationManagerExtensionsTests(TestNavigationManagerFixture navigationManagerFixture)
        {
            uri = "newPage";

            navigationManager = navigationManagerFixture.NavigationManager;
        }

        [Fact]
        public void NavigateTo_QueryParams_ShouldAddASingleQueryParameterToTheUri()
        {
            var queryParams = new Dictionary<string, string> { { "param", "value" } };
            navigationManager.NavigateTo(uri, queryParams);

            navigationManager.NavigatedUri.Should().Be($"{uri}?param=value");
        }

        [Fact]
        public void NavigateTo_QueryParams_ShouldAddMultipleQueryParametersToTheUri()
        {
            var queryParams = new Dictionary<string, string>
            {
                { "first", "firstValue" },
                { "second", "secondValue" }
            };

            navigationManager.NavigateTo(uri, queryParams);

            navigationManager.NavigatedUri.Should().Be($"{uri}?first=firstValue&second=secondValue");
        }

        [Fact]
        public void NavigateTo_QueryParams_ShouldNavigateEvenIfEmptyQueryParametersWereProvided()
        {
            var queryParams = new Dictionary<string, string>();

            navigationManager.NavigateTo(uri, queryParams);

            navigationManager.NavigatedUri.Should().Be(uri);
        }
    }
}
