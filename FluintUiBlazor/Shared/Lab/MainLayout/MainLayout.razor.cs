﻿//using Microsoft.AspNetCore.Components;
//using Microsoft.Fast.Components.FluentUI;
//using Microsoft.Fast.Components.FluentUI.Utilities;

//// Remember to replace the namespace below with your own project's namespace..
//namespace FluintUiBlazor.Shared;

//public partial class MainLayout : FluentComponentBase
//{
//    protected string? ClassValue =>
//        //new CssBuilder(Class)
//            .Build();

//    protected string? StyleValue =>
//        new StyleBuilder()
//            .AddStyle("--header-height", $"{HeaderHeight}px", () => HeaderHeight.HasValue)
//            .Build();

//    /// <summary>
//    /// Gets or sets the header content.
//    /// </summary>
//    [Parameter]
//    public RenderFragment? Header { get; set; }

//    /// <summary>
//    /// Gets or sets the subheader content.
//    /// </summary>
//    [Parameter]
//    public RenderFragment? SubHeader { get; set; }

//    /// <summary>
//    /// Gets or sets the height of the header (in pixels).
//    /// </summary>
//    [Parameter]
//    public int? HeaderHeight { get; set; } = 50;

//    /// <summary>
//    /// Gets or set the tite of the navigation menu
//    /// </summary>
//    [Parameter]
//    public string? NavMenuTitle { get; set; }

//    /// <summary>
//    /// Gets or sets the content of the navigation menu
//    /// </summary>
//    [Parameter]
//    public RenderFragment? NavMenuContent { get; set; }

//    /// <summary>
//    /// Gets or sets the content of the body
//    /// </summary>
//    [Parameter]
//    public RenderFragment? Body { get; set; }
//}
