using BlazorMetaTags.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorMetaTags
{
    public class AppBase : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "html");
            builder.AddAttribute(1, "lang", "en");

            builder.OpenElement(2, "head");
            builder.OpenComponent<Head>(3);
            builder.CloseComponent();
            builder.CloseElement();

            builder.OpenElement(3, "body");

            builder.OpenElement(4, "app");
            builder.OpenComponent<App>(5);
            builder.CloseComponent();
            builder.CloseElement();

            builder.OpenComponent<Body>(6);
            builder.CloseComponent();

            builder.AddMarkupContent(7, " <script src='_framework/blazor.server.js'></script>");
            builder.CloseElement();
            builder.CloseElement();

            base.BuildRenderTree(builder);
        }

    }

    public class MetaTags
    {
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";
    }
}
