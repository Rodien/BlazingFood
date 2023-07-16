using BlazingFood.Client.Services.FoodRegistration.FoodViews;
using Microsoft.AspNetCore.Components;

namespace BlazingFood.Client.View.Components
{
    public partial class FoodRegistrationComponet
    {
        [Inject]
        public IFoodViewService FoodViewService { get; set; }
    }
}
