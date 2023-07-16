using BlazingFood.Client.Services.FoodRegistration.Models;

namespace BlazingFood.Client.Services.FoodRegistration.FoodViews
{
    public interface IFoodViewService
    {
        ValueTask<FoodView> AddFoodViewAsync(FoodView foodView);
    }
}
