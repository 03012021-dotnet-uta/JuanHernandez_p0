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
        public List<AStore> Stores { get; set; } // print job

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
            var stores = new List<AStore>
            {
              new ChicagoStore(),
              new NewYorkStore(),
              new TexasStore()
            };

            var fs = new FileStorage();

            fs.WriteToXml<AStore>(stores);
            Stores = fs.ReadFromXml<AStore>().ToList();
        }
    }
}
