using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{

    public class Order
    {
        public List<APizza> orderPizzas = new List<APizza>();
        public AStore orderStore { get; set; }
        public Customer orderCustomer { get; set; }

        public Order()
        {

        }
    }

}

