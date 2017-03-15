using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassInherit.Model
{
    public class Address
    {
        public string StreetAddress;
        public string NewLine;
        public string City;
        public string State;
        public string Zip;

        public override string ToString()
        {
            return $"{ StreetAddress+NewLine}" +$"{City},{State},{Zip}";
        }
    }

    public class InternationalAddress : Address
    {
        public string Country;
        public override string ToString()
        {
            return base.ToString()+NewLine+Country;
        }
    }
}
