// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1054:URI-like parameters should not be strings", Justification = "NavigationManager receives a string for the page where we are navigating to.", Scope = "member", Target = "~M:BlazorNavigationManagerExtensions.NavigationManagerExtensions.NavigateTo(Microsoft.AspNetCore.Components.NavigationManager,System.String,System.Collections.Generic.IDictionary{System.String,System.String},System.Boolean)")]
