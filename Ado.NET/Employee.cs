using System;

namespace Ado.NET
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }


        public Employee(int dbID, string dbName, DateTime dbBirthDay, string dbEmail, string dbSalary)
        {
            ID = dbID;
            Name = dbName;
            BirthDay = dbBirthDay;
            Email = dbEmail;
            Salary = dbSalary;
        }

        public override string ToString()
        {
            string employeeInfo = "Employee: " + ID + "; " + Name;
            if (BirthDay != null)
            {
                employeeInfo += "; " + BirthDay;
            }

            if (Email != "")
            {
                employeeInfo += "; " + Email;
            }

            if (Salary != "")
            {
                employeeInfo += "; " + Salary;
            }

            employeeInfo += Environment.NewLine;

            return employeeInfo;
        }
    }
}