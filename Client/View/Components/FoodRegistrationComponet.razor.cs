using BlazingFood.Client.View.Bases;

namespace BlazingFood.Client.View.Components
{
    public partial class FoodRegistrationComponet
    {
        public TextBoxBase TextBox { get; set; }
        public void ButtonClicked()
        {
            string textBoxValue = this.TextBox.Value;

            Console.WriteLine(textBoxValue);
        }
    }
}
