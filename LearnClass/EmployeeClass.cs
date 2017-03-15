using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{
    class EmployeeClass
    {
        private string _FirstName;
        private string _LastName;

        public void Initialize(string newFirstName,string newLastName)
        {
            FirstName = newFirstName;
            LastName = newFirstName;
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName =value ; }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                else
                {
                    value = value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentException("LastName can't be blank.", "value");
                    }
                    else value = _LastName;
                }
            }
        }

        public string Title { get; set; }
        public string Salary { get; set; } = "Not Enough";
    }
}
