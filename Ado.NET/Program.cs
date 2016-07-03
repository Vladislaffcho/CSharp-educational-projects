using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFromBase();
            Console.ReadKey();
        }

        private static void ReadFromBase()
        {
            var conString = ConfigurationManager.AppSettings["ConnectionString"]; /* прочитали строку подключения */
            /* читаем из файла конфигурации значение ключа - appsettings из App.config файла */

            using (var connection = new SqlConnection(conString))
            {
                string commandText = @"SELECT DISTINCT 
                                        e.Id, e.Name, e.Birthday, e.Email, e.Salary
                                     FROM
                                        Employees e
                                     WHERE
                                        LEN(e.Name) > @len";
                var command = new SqlCommand(commandText, connection);
                var parameter = new SqlParameter("@len", SqlDbType.Int);
                parameter.Value = 20;
                command.Parameters.Add(parameter);

                connection.Open();

                using (var reader = command.ExecuteReader())
                    /* Здксь - Получить данные. Есть и другие методы для других целей */
                {
                    List<Employee> dataFromDb = new List<Employee>(); /* dynamic - единственный динамичекий тип в C# */
                    while (reader.Read())
                    {
                        int Id = int.Parse(reader[0].ToString());
                        string Name = reader[1].ToString();
                        DateTime BirthDay = reader[2].GetType() != typeof (DBNull) /* DBNull = Database NULL */
                            ? Convert.ToDateTime(reader[2])
                            : new DateTime();
                        string Email = reader[3].ToString();
                        string Salary = reader[4].ToString();
                        
                        Employee item = new Employee(Id, Name, BirthDay, Email, Salary);

                        dataFromDb.Add(item);
                    }

                    foreach (var employee in dataFromDb)
                    {
                        Console.Write(employee.ToString());
                    }
                }
            }
        }
    }
}
