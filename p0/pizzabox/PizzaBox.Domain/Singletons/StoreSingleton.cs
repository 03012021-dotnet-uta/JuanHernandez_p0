using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Domain.Singletons
{

    public class StoreSingleton
    {
        private static StoreSingleton _storeSingleton;
        public List<AStore> Stores { get; set; }
        public List<APizza> storePizza { get; set; }

        public List<Order> storeOrder { get; set; }

        public static StoreSingleton Instance
        {
            get
            {
                if (_storeSingleton == null)
                {
                    _storeSingleton = new StoreSingleton(); // printer
                }

                return _storeSingleton;
            }
        }

        public void Seeding()
        {
            var store = new List<AStore>
            {
              new ChicagoStore(),
              new NewYorkStore(),
              new TexasStore()
            };
            FileStorage fs = new FileStorage();

            fs.WriteToXml<AStore>(store, 1);
            Stores = fs.ReadFromXml<AStore>(1).ToList();
        }

        public void SeedingPizza()
        {
            var pizza = new List<APizza>
            {
                new MeatPizza(),
                new PepPizza(),
                new CheesePizza()
            };

            FileStorage fs = new FileStorage();
            fs.WriteToXml<APizza>(pizza, 3);
            storePizza = fs.ReadFromXml<APizza>(3).ToList();
        }
        public void saveOrder(List<Order> orders)
        {
            FileStorage fs = new FileStorage();
            fs.WriteToXml<Order>(orders, 2);
        }

        public void readOrder(List<Order> orders)
        {
            FileStorage fs = new FileStorage();
            storeOrder = fs.ReadFromXml<Order>(2).ToList();
        }

    }
}
