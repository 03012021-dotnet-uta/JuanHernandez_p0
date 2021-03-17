using System.Xml.Serialization;


namespace PizzaBox.Domain.Models
{
    [XmlInclude(typeof(Crust))]
    [XmlInclude(typeof(Topping))]
    [XmlInclude(typeof(Size))]
    public abstract class AComponent
    {

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
