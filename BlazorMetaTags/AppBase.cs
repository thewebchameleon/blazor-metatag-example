using BlazorMetaTags.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorMetaTags
{
    public class AppBase : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenComponent<Head>(0);
            builder.CloseComponent();

            builder.OpenElement(1, "body");

            builder.OpenElement(2, "app");
            builder.OpenComponent<App>(3);
            builder.CloseComponent();
            builder.CloseElement();

            builder.OpenComponent<Body>(4);
            builder.CloseComponent();

            builder.CloseElement();
        }

    }

    public class MetaTags
    {
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";
    }
}
