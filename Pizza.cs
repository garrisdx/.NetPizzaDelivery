using Microsoft.AspNetCore.Components;
using static PizzaDelivery.PizzaTop;

namespace PizzaDelivery
{
    public class Pizza
    {
        [Parameter]
        public PizzaTop Topping { get; set; }

        [Parameter]
        public Crust Crust { get; set; }
        public Pizza()
        {
            Topping = new PizzaTop();
            Crust = new Crust();
        }

        public double GetFinalPrice()
        {
            return Topping.ToppingPrice() + Crust.CrustPrice();
        }
    }
}
