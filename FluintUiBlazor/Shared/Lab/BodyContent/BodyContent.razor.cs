﻿using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using Microsoft.Fast.Components.FluentUI.Utilities;

// Remember to replace the namespace below with your own project's namespace..
namespace FluintUiBlazor.Shared;

public partial class BodyContent : FluentComponentBase
{
    protected string? ClassValue => new CssBuilder(Class)
        .AddClass("body-content")
        .Build();

    protected string? StyleValue => new StyleBuilder()
        .AddStyle(Style)
        .Build();

    /// <summary>
    /// Gets or sets the content to be rendered inside the component.
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
