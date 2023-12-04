using Microsoft.AspNetCore.Components;
using System.Reflection.Metadata;


namespace PizzaDelivery
{
    public class Crust
    {
        [Parameter]
        public bool Thin { get; set; }
        [Parameter]
        public bool Pan { get; set; }

        [Parameter]
        public bool HandTossed { get; set;}

        public double CrustPrice()
        {
            double total = 0;
            if(Thin)
            {
                total += 5.99;
            }
            if(Pan)
            {
                total += 7.99;
            }
            if(HandTossed)
            {
                total += 6.99;
            }
            return total;
        }
        
    }
}
