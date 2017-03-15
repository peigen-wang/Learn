using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnValueType
{


    public class Class1
    {
        static void Main()
        {
            int number;
            object thing;
            number = 42;
            thing = number;
            number = (int)thing;
        }

        public Angle Longitude { get; set; }
        public Angle Latitude { get; set; }
    }


}
