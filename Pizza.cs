using System.Reflection.Metadata;

namespace PizzaDelivery
{
    public class Pizza
    {
        public PizzaTop PizzaToppings { get; set; }
        public Crust Crust { get; set; }
        public double Tip { get; set; }

        public double DeliveryFee{ get; }

        public Pizza()
        {
            PizzaToppings = new PizzaTop();
            Crust = new Crust();
            Tip = 0;
            DeliveryFee = 2.00;
        }

        public double GetTipAmount()
        {
            double cost = PizzaToppings.ToppingPrice() + Crust.CrustPrice();
            double tip = cost * Tip;
            return tip;
        }

        public double GetFinalPrice()
        {
            return PizzaToppings.ToppingPrice() + Crust.CrustPrice() + Tip + DeliveryFee;


        }
    }
    public class PizzaTop()
    {

        public bool Pepperoni { get; set; }

        public bool ExtraCheese { get; set; }

        public bool Ham { get; set; }

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


    public class Crust()
    {

        public bool Thin { get; set; }

        public bool Pan { get; set; }


        public bool HandTossed { get; set; }

        public double CrustPrice()
        {
            double total = 0;
            if (Thin)
            {
                total += 5.99;
            }
            if (Pan)
            {
                total += 7.99;
            }
            if (HandTossed)
            {
                total += 6.99;
            }
            return total;
        }

    }
}

