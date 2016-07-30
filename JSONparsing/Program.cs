using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;

namespace JSONparsing
{
    class Program
    {
        static void Main(string[] args)
        {
            var ser = new DataContractJsonSerializer(typeof (Order), new List<Type>
            {
                typeof (SearchDump),
                typeof (CreateDump),
                typeof (Product),
                typeof (User)
            });

            Order order = (Order)ser.ReadObject(new FileStream(@"D:\new.json", FileMode.Open, FileAccess.Read));

            var xmlSerilizer = new XmlSerializer(typeof(Order), new Type[]
            {
                typeof (SearchDump),
                typeof (CreateDump),
                typeof (Product),
                typeof (User)
            });

            using (var fileStream = new FileStream(@"D:\MyXML.xml", FileMode.OpenOrCreate))
            {
                xmlSerilizer.Serialize(fileStream, order);
            }

            /*var xmlReader = new XmlReaderSettings();
            xmlReader.NameTable;*/

            Order obj = (Order)xmlSerilizer.Deserialize(new FileStream(@"D:\MyXML.xml", FileMode.Open));
            
            Console.ReadKey();
        }
    }
}
