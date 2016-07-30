using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args) /* Entity Framework - надстройка над ADO.NET */
        {
            using (var context = new SimpleDBContext())
            {
                context.Employees.Add(new Employee
                {
                    Position = context.Positions.First(x => x.Code == 1),
                    BirthDate = new DateTime(1976, 08, 14),
                    FirstName = "Oleg",
                    LastName = "Korewat",
                    Salary = 5000.0
                });

                //save changes from context to db
                context.SaveChanges();

                foreach (var employee in context.Employees)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}
