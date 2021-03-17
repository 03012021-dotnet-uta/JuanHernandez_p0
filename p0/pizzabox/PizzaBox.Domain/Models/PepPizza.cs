using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class PepPizza : APizza
    {
        public PepPizza()
        {
            Name = "Pepperoni Pizza";
        }
        public PepPizza(Size size)
        {
            Name = "Pepperoni Pizza";
            Size = size;
        }
        protected override void AddCrust()
        {
            Crust = new Crust();
        }

        protected override void AddSize()
        {
            Size = new Size();
        }

        protected override void AddToppings()
        {
            Toppings = new List<Topping>
            {
                new Topping()
                {
                    Name = "Marinara"
                },

                new Topping()
                {
                    Name = "Pepperoni"
                },

                new Topping()
                {
                    Name = "Cheese"
                }
            };
        }

    }
}
