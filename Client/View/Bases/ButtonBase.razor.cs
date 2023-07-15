using Microsoft.AspNetCore.Components;

namespace BlazingFood.Client.View.Bases
{
    public partial class ButtonBase : ComponentBase
    {
        [Parameter]
        public string Label { get; set; }

        [Parameter]
        public Action OnClick { get; set; }

        public void Click() => OnClick?.Invoke();
        
    }
}
