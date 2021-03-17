using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class CheesePizza : APizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
        }
        public CheesePizza(Size size)
        {
            Name = "Cheese Pizza";
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
                    Name = "Cheese"
                }
            };
        }

    }
}
