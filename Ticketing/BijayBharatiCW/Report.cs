using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BijayBharatiCW
{
    //Report calss contains all required properties for a report
    class Report
    {
        public string Customer_Type { get; set; }

        public string Ticket_Category { get; set; }

        public double Ticket_Price { get; set; }

        public int Group_Size { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }
        
        public string Date { get; set; }

        public string Day { get; set; }

        public string Entry {get; set;}

        public string Exit { get; set; }
        
    }
}
