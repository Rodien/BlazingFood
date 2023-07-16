using BlazingFood.Client.Services.Foods.FoodViews;
using BlazingFood.Client.View.Bases;
using Microsoft.AspNetCore.Components;

namespace BlazingFood.Client.View.Components
{
    public partial class FoodRegistrationComponet
    {
        [Inject]
        public IFoodViewService FoodViewService { get; set; }
    }
}
