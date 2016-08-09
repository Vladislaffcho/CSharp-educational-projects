using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CarsLibrary;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetAssembly(typeof (Car));
            Console.WriteLine("This is the assembly with class Car defined. ");
            Console.WriteLine(assembly.FullName + Environment.NewLine);
            Console.WriteLine("Here are the types defined in the assembly.");

            foreach (var definedType in assembly.DefinedTypes)
            {
                Console.WriteLine("All methods in the class {0} ", definedType.FullName);
                Console.WriteLine(definedType.FullName);
                foreach (var declaredMethods in definedType.DeclaredMethods)
                {
                    string access = declaredMethods.IsPrivate ? "public" : "private";

                    Console.WriteLine(declaredMethods.Name + " " + access);
                    if (declaredMethods.Name == "Move")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Try to invoke Move method.");
                        declaredMethods.Invoke(new Car(), null);
                    }
                    if (declaredMethods.Name == "WhatDoYouWant")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Try to invoke WhatDoYouWant method.");
                        declaredMethods.Invoke(new Car(), null);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
