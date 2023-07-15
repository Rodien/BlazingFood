using Microsoft.AspNetCore.Components;

namespace BlazingFood.Client.View.Bases
{
    public partial class TextBoxBase : ComponentBase
    {

        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public string Placeholder { get; set; }

        public void SetValue(string Value) =>
            this.Value = Value;

        public void SetPlaceholder(string placeholder) =>
            this.Placeholder = placeholder;


    }
}
