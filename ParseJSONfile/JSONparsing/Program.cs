﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JSONparsing
{
    class Program
    {
        static void Main(string[] args)
        {
            var ser = new DataContractJsonSerializer(typeof (Order), new List<Type>
            {
                typeof (SearchDump),
                typeof (Product)
            });

            Order ord = (Order)ser.ReadObject(new FileStream(@"D:\new.json", FileMode.Open, FileAccess.Read));
            Console.ReadKey();

        }
    }
}
