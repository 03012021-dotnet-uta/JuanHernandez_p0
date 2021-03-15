using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{

    [XmlInclude(typeof(ChicagoStore))]
    [XmlInclude(typeof(NewYorkStore))]
    [XmlInclude(typeof(TexasStore))]
    public abstract class AStore
    {
        public string storeName { get; set; }
        // public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return storeName;
        }
    }
}
