using Microsoft.AspNetCore.Components;
using System.Security.Cryptography.X509Certificates;

namespace PizzaDelivery
{
   

        public class PizzaTop
        {
            [Parameter]
            public bool Pepperoni { get; set; }
            [Parameter]
            public bool ExtraCheese { get; set; }
            [Parameter]
            public bool Ham { get; set; }
            [Parameter]
            public bool Chicken { get; set; }

            public double ToppingPrice()
            {
                double runningTotal = 0;
                if (Pepperoni)
                {
                    runningTotal += 1.50;
                }
                if (ExtraCheese)
                {
                    runningTotal += 2.00;
                }
                if (Ham)
                {
                    runningTotal += 1.79;
                }
                if (Chicken)
                {
                    runningTotal += 3.00;
                }
                return runningTotal;
            }


        }
    
    }
}
