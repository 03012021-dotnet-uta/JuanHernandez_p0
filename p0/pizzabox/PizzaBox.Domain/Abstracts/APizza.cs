using System.Collections.Generic;
using PizzaBox.Domain.Models;


namespace PizzaBox.Domain.Abstracts
{

    public abstract class APizza
    {
        public string Name { get; set; }
        public Crust Crust { get; set; }
        public Size Size { get; set; }
        public List<Topping> Toppings { get; set; }

        public APizza()
        {
            FactoryMethod();
        }


        private void FactoryMethod()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }

        public void ShowToppings(APizza pizza)
        {
            foreach (var topping in pizza.Toppings)
            {
                System.Console.WriteLine("Toppings: " + topping.Name);
            }
        }

        protected abstract void AddCrust();
        protected abstract void AddSize();
        protected abstract void AddToppings();

    }
}
