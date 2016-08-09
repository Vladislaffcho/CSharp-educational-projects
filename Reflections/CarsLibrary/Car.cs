using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    public class Car
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Move()
        {
            Console.WriteLine("");
        }

        private string WhatDoYouWant(string What)
        {
            return What + " - here it is!!!";
        }
    }
}
