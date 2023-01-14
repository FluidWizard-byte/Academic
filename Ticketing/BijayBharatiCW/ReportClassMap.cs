using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace BijayBharatiCW
{
    // here we are jusi mapping class properties of Report.cs to CSV data
    // this just means the csv file should follow the structure difined here
    class ReportClassMap : ClassMap<Report>
    {
        public ReportClassMap() {

            Map(r => r.Customer_Type).Name("Customer_Type");
            Map(r => r.Ticket_Category).Name("Ticket_Category");
            Map(r => r.Ticket_Price).Name("Ticket_Price");
            Map(r => r.Group_Size).Name("Group_Size");
            Map(r => r.Adults).Name("Adults");
            Map(r => r.Children).Name("Children");
            Map(r => r.Date).Name("Date");
            Map(r => r.Day).Name("Day");
            Map(r => r.Entry).Name("Entry");
            Map(r => r.Exit).Name("Exit");
        }
    }
}

