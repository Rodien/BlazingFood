using System;
namespace BlazingFood.Client.Services.FoodRegistration.Exception
{
    public class FoodRegistrationComponentExeption : System.Exception   
    {
        public FoodRegistrationComponentExeption(System.Exception innerException)
            :base("Error occurred, contact support", innerException)
        { 
        
        }
    }
}
