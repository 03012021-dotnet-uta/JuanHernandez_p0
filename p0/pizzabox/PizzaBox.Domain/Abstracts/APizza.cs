using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;


namespace PizzaBox.Domain.Abstracts
{
    [XmlInclude(typeof(MeatPizza))]
    [XmlInclude(typeof(PepPizza))]
    [XmlInclude(typeof(CustomPizza))]
    [XmlInclude(typeof(CheesePizza))]

    public abstract class APizza
    {
        public string Name { get; set; }
        public Crust Crust { get; set; }
        public Size Size { get; set; }
        public List<Topping> Toppings { get; set; }

        public double Price { get; set; }

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

        public void PrintPizza()
        {
            System.Console.WriteLine("Pizza Type: " + Name);
            System.Console.WriteLine("Crust Type: " + Crust.Name);
            System.Console.WriteLine("Pizza Size: " + Size.Name);
        }
        protected abstract void AddCrust();
        protected abstract void AddSize();
        protected abstract void AddToppings();



    }
}
