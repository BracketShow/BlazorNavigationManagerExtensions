using System.Collections.Generic;
using BlazorNavigationManagerExtensions.Fixtures;
using FluentAssertions;
using Xunit;

namespace BlazorNavigationManagerExtensions.NavigationManagerExtensions
{
    public class NavigateToQueryParamsTests : IClassFixture<TestNavigationManagerFixture>
    {
        private readonly string uri;

        private readonly TestNavigationManager navigationManager;

        public NavigateToQueryParamsTests(TestNavigationManagerFixture navigationManagerFixture)
        {
            uri = "newPage";

            navigationManager = navigationManagerFixture.NavigationManager;
        }

        [Fact]
        public void NavigateToString_QueryParams_ShouldAddASingleQueryParameterToTheUri()
        {
            var queryParams = new Dictionary<string, string> { { "param", "value" } };
            navigationManager.NavigateTo(uri, queryParams);

            navigationManager.NavigatedUri.Should().Be($"{uri}?param=value");
        }

        [Fact]
        public void NavigateToString_QueryParams_ShouldHandleSpecialCharacters()
        {
            var queryParams = new Dictionary<string, string> { { "param", "v@l?&" } };
            navigationManager.NavigateTo(uri, queryParams);

            navigationManager.NavigatedUri.Should().Be($"{uri}?param=v@l%3F%26");
        }

        [Fact]
        public void NavigateToString_QueryParams_ShouldAddMultipleQueryParametersToTheUri()
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
        public void NavigateToString_QueryParams_ShouldNavigateEvenIfEmptyQueryParametersWereProvided()
        {
            var queryParams = new Dictionary<string, string>();

            navigationManager.NavigateTo(uri, queryParams);

            navigationManager.NavigatedUri.Should().Be(uri);
        }
    }
}