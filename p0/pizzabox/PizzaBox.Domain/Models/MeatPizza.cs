using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class MeatPizza : APizza
    {
        public MeatPizza()
        {
            Name = "Meat Pizza";
            Price = 10.99;
        }
        public MeatPizza(Size size)
        {
            Name = "Meat Pizza";
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
                    Name = "Meat"
                },

                new Topping()
                {
                    Name = "Cheese"
                }
            };
        }

    }
}
