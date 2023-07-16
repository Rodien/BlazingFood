using BlazingFood.Client.Models.ContainerComponents;
using Microsoft.AspNetCore.Components;

namespace BlazingFood.Client.View.Components
{
    public partial class ContainerComponent : ComponentBase
    {

        [Parameter]
        public ComponentState State { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public string Error { get; set; }

    }
}
