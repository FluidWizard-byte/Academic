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
    //This class contains mehods to read and modify csv file containing data about rates.
    class RatesService
    {
        
        //ReadCSVFile method will return a List containing objects of class Rates.
        //We can see RatesClassMap being used here to make sure proper structure is followed when reading the file

        public List<Rates> ReadCSVFile(string csvPath)
        {
            try
            {
                using (var streamReader = new StreamReader(csvPath))
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<RatesClassMap>();
                    var records = csvReader.GetRecords<Rates>().ToList();
                    return records;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // WriteCSVFile will write to csv file list containing objects of Rates class is written to the file
        // We use configurations to make sure data is appended at the end of file.
        public void WriteCSVFile(string csvPath, List<Rates> rates) {
            bool append = true;
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HasHeaderRecord = !append;
            using (var streamWriter = new StreamWriter(csvPath,append)) {
                using (var csvWriter = new CsvWriter(streamWriter, config)) {
                    csvWriter.Context.RegisterClassMap<RatesClassMap>();
                    csvWriter.WriteRecords(rates);
                }
            }
        }
        //UpdateCSVFile method is used when deleting records or modifying existing records
        //Here we are not appening record to the end of the file but replacing the whole record
        //We replace the whole record because it is how csvHelper library works
        //Existing records are replaced by a new list containing new values
        public void UpdateCSVFile(string csvPath, List<Rates> rates)
        {
            
            using (var streamWriter = new StreamWriter(csvPath))
            {
                using (var csvUpdater = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    csvUpdater.Context.RegisterClassMap<RatesClassMap>();
                    csvUpdater.WriteRecords(rates);
                }
            }
        }



    }
}
