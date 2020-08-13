// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Tolerated in test names to have better readability", Scope = "module")]
[assembly: SuppressMessage("Design", "CA1056:URI-like properties should not be strings", Justification = "Tolerated since we are comparing the string with the route of the page that is not used as a Uri", Scope = "type", Target = "BlazorNavigationManagerExtensions.Fixtures.TestNavigationManager")]
[assembly: SuppressMessage("Design", "CA1056:URI-like properties should not be strings", Justification = "Tolerated since we are comparing the string with the route of the page that is not used as a Uri", Scope = "type", Target = "BlazorNavigationManagerExtensions.Fixtures.TestNavigationManagerFixture")]
[assembly: SuppressMessage("Design", "CA1054:URI-like parameters should not be strings", Justification = "Tolerated since we are comparing the string with the route of the page that is not used as a Uri", Scope = "type", Target = "BlazorNavigationManagerExtensions.Fixtures.TestNavigationManager")]
