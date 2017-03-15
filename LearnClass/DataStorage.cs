using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{
    class DataStorage
    {
        public static void Store(Employee employee)
        {
            FileStream stream = new FileStream(employee.FirstName + employee.LastName + ".dat", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);
            writer.Close();
        }

        public static Employee load(string firstName,string lastName)
        {
            Employee employee = new Employee();
            FileStream stream = new FileStream(firstName + lastName + ".dat", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            employee.FirstName = reader.ReadLine();
            employee.LastName = reader.ReadLine();
            employee.Salary = reader.ReadLine();
            reader.Close();
            return employee;
        }
    }
}
