using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace BijayBharatiCW
{
    // here we are jusi mapping class properties of Rates.cs to CSV data
    // this just means the csv file should follow the structure difined here
    class RatesClassMap: ClassMap<Rates>
    {
        public RatesClassMap() {

            Map(r => r.Duration).Name("Duration");
            Map(r => r.Adult_Rate).Name("Adult_Rate");
            Map(r => r.Children_Rate).Name("Children_Rate");
        }
    }
}
