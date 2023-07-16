using BlazingFood.Client.Models.ContainerComponents;
using Microsoft.AspNetCore.Components;

namespace BlazingFood.Client.View.Components
{
    public partial class ContainerStatesComponent
    {

        [Parameter]
        public ComponentState State { get; set; }

        [Parameter]
        public RenderFragment LoadingFragment { get; set; }

        [Parameter]
        public RenderFragment ConentFragment { get; set; }

        [Parameter]
        public RenderFragment ErrorFragment { get; set; }

        private RenderFragment GetComponentStateFragment()
        {
            return State switch
            {
                ComponentState.Loading => LoadingFragment,
                ComponentState.Content => ConentFragment,
                ComponentState.Error => ErrorFragment,
                _ => ErrorFragment

            };
        }
    }
}
