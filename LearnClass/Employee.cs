using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary;
        private string Password;
        private bool IsAuthenticated;

        public bool logon(string password)
        {
            if (password == Password)
            {
                IsAuthenticated = true;
            }
            return IsAuthenticated;
        }

        public bool GetIsAuthenticated()
        {
            return IsAuthenticated;
        }

        public void SetName(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string GetName()
        {
            return $"{ this.FirstName}  {this.LastName}";
        }

        public void Save()
        {
            DataStorage.Store(this);
        }
    }    
}
