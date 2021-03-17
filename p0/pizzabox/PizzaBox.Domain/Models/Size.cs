namespace PizzaBox.Domain.Models
{
    public class Size : AComponent
    {
        public Size()
        {
            Name = "Large";
        }
        public Size(string name)
        {
            Name = name;
        }

    }
}
