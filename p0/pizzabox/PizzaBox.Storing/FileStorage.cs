using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaBox.Storing
{
    public class FileStorage
    {
        private readonly string storePath = @"stores.xml";
        private readonly string orderPath = @"orders.xml";
        private readonly string pizzaPath = @"pizza.xml";
        public string findPath(int s)
        {
            switch (s)
            {
                case 1:
                    return storePath;

                case 2:
                    return orderPath;

                case 3:
                    return pizzaPath;

            }
            return null;
        }

        //for storing the stores
        public void WriteToXml<T>(List<T> data, int s) where T : class
        {
            string _path = findPath(s);
            using (var writer = new StreamWriter(_path))
            {
                var serializer = new XmlSerializer(typeof(List<T>));

                serializer.Serialize(writer, data);
            }
        }

        public IEnumerable<T> ReadFromXml<T>(int s) where T : class
        {
            string _path = findPath(s);
            using (var reader = new StreamReader(_path))
            {
                var serializer = new XmlSerializer(typeof(List<T>));

                return serializer.Deserialize(reader) as IEnumerable<T>;
            }
        }
    }
}
