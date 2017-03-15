using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{

    

    class Employee1
    {
        static Employee1()
        {
            Random rd = new Random();
            NextId = rd.Next(101, 999);
        }

        public Employee1(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Enough";
        public static int NextId = 0;
    }
}
