using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BijayBharatiCW
{
    //Reports
    public partial class ReportForm : Form
    {
        string reportCSVPath = Path.Combine(Environment.CurrentDirectory, @"my_files\report.csv");
        List<Report> reportList = new List<Report>();
        List<Report> reportListHTL = new List<Report>();
        List<Report> reportListLTH = new List<Report>();
        ReportService accessValues = new ReportService();
        public ReportForm()
        {
            InitializeComponent();
        }

        // When the window is opened, the report and charts must be loadeed and stats about currently loaded file must be displayed.
        private void ReportForm_Load(object sender, EventArgs e)
        {

            LoadReport();
            updateStats();
            loadGrid(reportList);
            LoadChart();
            LoadChart2();
            LoadChart3();
        }

        // first reportList is cleared this makes it so that when grid view is reloaded, it is completely refreshed
        // just taking items from csv file and adding to reportList which contains objects of class Report
        private void LoadReport() {
            reportList.Clear();
            var readCategoriesReport = accessValues.ReadCSVFile(reportCSVPath);

            foreach (Report item in readCategoriesReport)
            {
                reportList.Add(item);
            }
        }

        // grid is set to null then a list to load is passed to make sure data from new report is loaded in the grid

        private void loadGrid(List<Report> listToLoad)
        {
            reportdataGridView.DataSource = null;
            reportdataGridView.DataSource = listToLoad;
        }

        // button to sort data in gridview, a sorted list is reloaded in the grid
        private void sortHighToLowbutton_Click(object sender, EventArgs e)
        {
            reportListLTH = BubbleSortAesc(reportList);

            loadGrid(reportListHTL);
        }
        // button to sort data in gridview, a sorted list is reloaded in the grid
        private void sortLowToHighbutton_Click(object sender, EventArgs e)
        {
            reportListHTL = BubbleSortDesc(reportList);

            loadGrid(reportListHTL);
        }
        // changes the gridview to default i.e like it was before sorting
        private void defaultbutton_Click(object sender, EventArgs e)
        {

            LoadReport();
            loadGrid(reportList);
        }

        // bubble sort is applied on list containing Report objects using their ticket_price
        private static List<Report> BubbleSortAesc(List<Report> repList)
        {
            int n = repList.Count;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (repList[j].Ticket_Price < repList[j + 1].Ticket_Price)
                    {
                        Report temp = repList[j];
                        repList[j] = repList[j + 1];
                        repList[j + 1] = temp;
                    }
                }
            }

            return repList;

        }
        // bubble sort is applied on list containing Report objects using their ticket_price
        private static List<Report> BubbleSortDesc(List<Report> repList)
        {
            int n = repList.Count;
            for (int i = 0; i <= n - 1; i++) {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (repList[j].Ticket_Price > repList[j + 1].Ticket_Price)
                    {
                        Report temp = repList[j];
                        repList[j] = repList[j + 1];
                        repList[j + 1] = temp;
                    }
                }
            }

            return repList;

        }

        // button to refresh charts
        private void loadChartbutton_Click(object sender, EventArgs e)
        {

            ClearChart1();
            LoadChart();
            ClearChart2();
            LoadChart2();
            ClearChart3();
            LoadChart3();

        }
        // charts need to be cleared so that data is added to fresh chart and not appended to same chart again and again
        private void ClearChart1() {
            foreach (var series in byDaychart.Series)
            {
                series.Points.Clear();
            }
        }
        // charts need to be cleared so that data is added to fresh chart and not appended to same chart again and again
        private void ClearChart2()
        {
            foreach (var series in adultChildrenchart.Series)
            {
                series.Points.Clear();
            }
        }
        // charts need to be cleared so that data is added to fresh chart and not appended to same chart again and again
        private void ClearChart3()
        {
            foreach (var series in weeklychart.Series)
            {
                series.Points.Clear();
            }
        }

        // ticket price data from each day is added to a variable and displayed in the chart
        public void LoadChart() {
            LoadReport();
            loadGrid(reportList);
            double sunday = 0;
            double monday = 0;
            double tuesday = 0;
            double wednesday = 0;
            double thursday = 0;
            double friday = 0;
            double saturday = 0;

            foreach (Report item in reportList) {
                switch (item.Day) {
                    case "Sunday":
                        sunday += item.Ticket_Price;
                        break;
                    case "Monday":
                        monday += item.Ticket_Price;
                        break;
                    case "Tuesday":
                        tuesday += item.Ticket_Price;
                        break;
                    case "Wednesday":
                        wednesday += item.Ticket_Price;
                        break;
                    case "Thursday":
                        thursday += item.Ticket_Price;
                        break;
                    case "Friday":
                        friday += item.Ticket_Price;
                        break;
                    default:
                        saturday += item.Ticket_Price;
                        break;
                }
            }
            byDaychart.Series["Earning"].IsValueShownAsLabel = true;
            byDaychart.Series["Earning"].Points.AddXY("Sunday", sunday);
            byDaychart.Series["Earning"].Points.AddXY("Monday", monday);
            byDaychart.Series["Earning"].Points.AddXY("Tuesday", tuesday);
            byDaychart.Series["Earning"].Points.AddXY("Wednesday", wednesday);
            byDaychart.Series["Earning"].Points.AddXY("Thursday", thursday);
            byDaychart.Series["Earning"].Points.AddXY("Friday", friday);
            byDaychart.Series["Earning"].Points.AddXY("Saturday", saturday);
        }

        // Number of adults and chidren is calculated and displayed in pie chart
        public void LoadChart2() {
            LoadReport();
            loadGrid(reportList);
            int adults = 0;
            int children = 0;

            foreach (Report item in reportList) {
                adults += item.Adults;
                children += item.Children;
            }
            adultChildrenchart.Series["Visitors"].IsValueShownAsLabel = true;
            adultChildrenchart.Series["Visitors"].Points.AddXY("Adults", adults);
            adultChildrenchart.Series["Visitors"].Points.AddXY("Children", children);
        }

        // Each day to of any give date belongs to a week of the year from 1-53
        // each date of Report object is identified to a week nomber
        // the Report object and the week are added to dictionary as key value pair
        // we then make a lis of unique week numbers
        // we check for each key(Report) if it has the corresponding week number value
        // If above conditions are fulfilled, ticket price of a date belongs to that particular week
        // a number like 53, 9, 1 wont be helpful in a report so week span is displayed in chart
        // which is the last date of the list of dates belonging to aweek number
        public void LoadChart3()
        {
            LoadReport();
            loadGrid(reportList);
            
            DateTime date = new DateTime();
            Dictionary<Report , int> dict= new Dictionary<Report,int>();
            Dictionary<string, double> chartdict = new Dictionary<string, double>();
           
            foreach (Report item in reportList)
            {
                date = DateTime.Parse(item.Date);
                var check = new GregorianCalendar(GregorianCalendarTypes.Localized).GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                Console.WriteLine(date.ToString());
                Console.WriteLine(check);
                dict.Add(item, check);
            }
            var distinctWeek = dict.Values.Distinct().ToList();
            
            foreach (var val in distinctWeek) {
                double earning = 0;
                string endDate= null;
                foreach (Report r in dict.Keys) {
                    if (dict[r]==val) {
                        endDate = r.Date;
                        earning+=r.Ticket_Price;
                    }
                    
                }
                chartdict.Add(endDate, earning);
            }
            foreach(KeyValuePair<string, double> kvp in chartdict)
            {
                weeklychart.Series["weeklyEarnings"].Points.AddXY("Week span: "+kvp.Key, kvp.Value);
                weeklychart.Series["weeklyEarnings"].IsValueShownAsLabel = true;
            }
        }
        // current date time is used to generate a unique csv file
        // records are then written to the file and exported to desktop
        private void exportReportbutton_Click(object sender, EventArgs e)
        {
            LoadReport();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string exportPath = desktopPath + @"\Report_Export" + DateTime.Now.ToString("yyyyMMddTHHmmssffff") + ".csv";

            using (FileStream fs = File.Create(exportPath))


                Console.WriteLine(exportPath);
            accessValues.UpdateCSVFile(exportPath, reportList);

            MessageBox.Show("Report successfully exported to following location:\n" + exportPath);
        }

        // this method shows current details like total number of records and total earnings in the report currently loaded
        private void updateStats() {
            LoadReport();
            double earning = 0;
            foreach (Report item in reportList) {
                earning += item.Ticket_Price;
            }
            countValuelabel.Text = Convert.ToString(reportList.Count);
            earningValuelabel.Text = Convert.ToString(earning);
        }

        // this method will load the original record file of the system
        private void refreshReportbutton_Click(object sender, EventArgs e)
        {
            reportCSVPath = null;
            reportCSVPath = Path.Combine(Environment.CurrentDirectory, @"my_files\report.csv");
            importFiletextBox.Text = "";
            LoadReport();
            updateStats();
            loadGrid(reportList);
            ClearChart1();
            LoadChart();
            ClearChart2();
            LoadChart2();

        }
     
        // here we import an existing file by getting itd full path from user as input
        // the grids and charts are then updated with data from the imported file
        private void importFilebutton_Click(object sender, EventArgs e)
        {
            if (importFiletextBox.Text != "")
            {
                reportCSVPath = null;
                reportCSVPath= importFiletextBox.Text;
                Console.WriteLine(reportCSVPath);
                if (File.Exists(reportCSVPath))
                {
                    try
                    {
                        LoadReport();
                        updateStats();
                        loadGrid(reportList);
                        ClearChart1();
                        LoadChart();
                        ClearChart2();
                        LoadChart2();
                        MessageBox.Show("Your File is loaded. Keep in mind this is an old file and data is not added.\nChanges are only made in file you viewed during application start");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else {
                    MessageBox.Show("Invalid file. Please enter full file path amd make sure  file formatting is correct");
                }

            }
            else {
                MessageBox.Show("Enter full path of the file");
            }
        }

      
    }
}
