using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BijayBharatiCW
{
    //Rates include Duration which is same as ticket category. Adult_Rate and Children_Rate are for ticket price
    class Rates
    {
        public string Duration { get; set; }
        
        public double Adult_Rate { get; set; }

        public double Children_Rate { get; set; }
    }

}
