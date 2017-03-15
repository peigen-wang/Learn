using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{

    /// <summary>
    /// partial 分部类  能够调用分类中的嵌套方法
    /// </summary>
    public partial class Program
    {
        static void MainEmployee1()
        {
            CommandLine commandLine = new CommandLine(new string[] { });


            Employee1 employee = new Employee1("王","根培");
            employee.Salary = "Too Little";
            Console.WriteLine("{0} {1} ：{2}", employee.FirstName, employee.LastName, employee.Salary);
        }

        static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee2.SetName("Inigo", "Montoya");
            employee2.Save();

            employee1.FirstName = "Inigo";
            employee1.LastName = "Montoya";
            employee1.Salary = "Too Little";
            InCreaseSalary(employee1);
            Console.WriteLine($"{employee1.FirstName} {employee1.LastName}:{employee1.Salary}");
            InCreaseSalary(employee2);
            employee1 = DataStorage.load("Inigo", "Montoya");
            Console.WriteLine($"{employee1.GetName()}:{employee1.Salary}");
            Console.Read();
        }

        static void InCreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }
}
