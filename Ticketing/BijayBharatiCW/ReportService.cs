using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
namespace BijayBharatiCW
{
    //This class contains mehods to read and modify csv file containing data about report.
    class ReportService
    {
        //ReadCSVFile method will return a List containing objects of class Report.
        //We can see ReportClassMap being used here to make sure proper structure is followed when reading the file
        public List<Report> ReadCSVFile(string csvPath)
        {
            try
            {
                using (var streamReader = new StreamReader(csvPath))
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<ReportClassMap>();
                    var records = csvReader.GetRecords<Report>().ToList();
                    return records;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // WriteCSVFile will write to csv file list containing objects of Report class is written to the file
        // We use configurations to make sure data is appended at the end of file.
        public void WriteCSVFile(string csvPath, List<Report> report)
        {
            bool append = true;
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HasHeaderRecord = !append;
            using (var streamWriter = new StreamWriter(csvPath, append))
            {
                using (var csvWriter = new CsvWriter(streamWriter, config))
                {
                    csvWriter.Context.RegisterClassMap<ReportClassMap>();
                    csvWriter.WriteRecords(report);
                }
            }
        }
        // This method is used when exporting reports.
        public void UpdateCSVFile(string csvPath, List<Report> report)
        {

            using (var streamWriter = new StreamWriter(csvPath))
            {
                using (var csvUpdater = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    csvUpdater.Context.RegisterClassMap<ReportClassMap>();
                    csvUpdater.WriteRecords(report);
                }
            }
        }


    }
}
