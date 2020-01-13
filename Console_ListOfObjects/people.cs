using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ListOfObjects
{
    public enum Demographic
    {
        Caucasian = 1,
        Hispanic,
        AfricanAmerican,
        AmericanIndian,
        Asian

    }

    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool isActive { get; set; }
        public Demographic demo { get; set; }

        public People  () {
            
        }

            
    }
}
