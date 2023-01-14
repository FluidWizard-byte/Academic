using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;
//using CsvHelper.Configuration;
//using CsvHelper.Configuration.Attributes;

namespace BijayBharatiCW
{
    //Defining all required variables and paths for files to be used
    public partial class TicketingSystemForm : Form
    {
        string ratesCSVPath = Path.Combine(Environment.CurrentDirectory, @"my_files\rates.csv");
        string reportCSVPath = Path.Combine(Environment.CurrentDirectory, @"my_files\report.csv");
        Dictionary<string, double> adultRateList = new Dictionary<string, double>();
        Dictionary<string, double> childrenRateList = new Dictionary<string, double>();
        List<string> durations = new List<string>();
        List<string> customers = new List<string>();
        List<string> groups = new List<string>();
        List<Report> reportList = new List<Report>();
        ReportService accessValues = new ReportService();
        Boolean loggedin = false;
        string customerType;
        string ticketCategory;
        double ticketPrice;
        string groupType;
        int groupSize;
        int adults;
        int children;
        string entry;
        string exit;
        public TicketingSystemForm()
        {
            
            InitializeComponent();
            
        }

        // When application is started, all the values for comboboxes are loaded
        private void TicketingSystemForm_Load(object sender, EventArgs e)
        {
            LoadData();
            logoutbutton.Enabled = false;
            addCategoriesbutton.Enabled = false;
        }

        // LoadData method adds values to comboboxes
        // We use ReadCSVFile method from RatesService to access the value of durations and rates
        // We also add values of duration and rates to dictionaries that will be used in calculations
        private void LoadData() {

            customers.Add("Individual-Adult"); customers.Add("Individual-Child"); customers.Add("Group");
            groups.Add("Adult"); groups.Add("Children"); groups.Add("Mixed");

            var customerSource = new BindingSource();
            customerSource.DataSource = customers;
            customerTypecomboBox.DataSource = customerSource.DataSource;

            var groupSource = new BindingSource();
            groupSource.DataSource = groups;
            groupTypecomboBox.DataSource = groupSource.DataSource;

            var accessValues = new RatesService();

            var readCategoriesRates = accessValues.ReadCSVFile(ratesCSVPath);


            foreach (Rates item in readCategoriesRates)
            {
                durations.Add(item.Duration);
                adultRateList.Add(item.Duration, item.Adult_Rate);
                childrenRateList.Add(item.Duration, item.Children_Rate);

            }
            var durationSource = new BindingSource();
            durationSource.DataSource = durations;
            durationcomboBox.DataSource = durationSource.DataSource;

        }

        // Here we are disabling components of the UI when they are not required

        private void customerTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirmTicketbutton.Enabled = false;
            string currentSelection = customerTypecomboBox.SelectedItem.ToString();
            if (currentSelection.Equals("Group"))
            {
                grouppanel.Enabled = true;
            }
            else
            {
                
                grouppanel.Enabled = false;
                childrenpanel.Enabled = false;
                //calculate();

            }
        }

        // Here we are disabling components of the UI when they are not required

        private void groupTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirmTicketbutton.Enabled = false;
            string currentSelection = groupTypecomboBox.SelectedItem.ToString();
            if (currentSelection.Equals("Mixed"))
            {
                childrenpanel.Enabled = true;
            }
            else
            {
                childrenpanel.Enabled = false;
            }
        }

        // This is one of the most used methods
        // This method calculates ticket price according to custoner type, ticket typr, group etc
        // The price is then shown in price text box so that users can see cost of the ticket.

        private void calculate()
        {
            customerType = customerTypecomboBox.SelectedItem.ToString();
            string duration = durationcomboBox.SelectedItem.ToString();
            string groupType = groupTypecomboBox.SelectedItem.ToString();
            double ticketprice = 0;
            int groupsize = 0;
            double discount = 0;
 
            if (customerType == "Individual-Adult") {
                ticketprice = adultRateList[duration];
            }
            if (customerType == "Individual-Child") {
                ticketprice = childrenRateList[duration];
            }
            if (customerType == "Group") {
                if (groupSizetextBox.Text != "")
                {
                    groupsize = Convert.ToInt32(groupSizetextBox.Text);
                    if (groupsize > 1)
                    {
                        if (groupsize < 6)
                        {
                            discount = 0.05;
                        }
                        else if (groupsize > 5 && groupsize < 11)
                        {
                            discount = 0.09;
                        }
                        else {
                            discount = 0.13;
                        }
                        switch (groupType)
                        {
                            case "Children":
                                ticketprice = childrenRateList[duration] * groupsize;
                                ticketprice = ticketprice - ticketprice * discount;
                                break;
                            case "Mixed":
                                if (noOfChildrentextBox.Text != "" && Convert.ToInt32(noOfChildrentextBox.Text) < groupsize && Convert.ToInt32(noOfChildrentextBox.Text) > 0)
                                {
                                    int children = Convert.ToInt32(noOfChildrentextBox.Text);
                                    int adults = groupsize - children;

                                    ticketprice = childrenRateList[duration] * children + adultRateList[duration] * adults;
                                    ticketprice = ticketprice - ticketprice * discount;
                                    break;

                                }
                                else
                                {
                                    MessageBox.Show("Enter valid input for number of children");
                                    break;
                                }


                            default:
                                ticketprice = adultRateList[duration] * groupsize;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Minimum 2 people required for group");
                    }
                }
                else {
                    MessageBox.Show("Enter group size");
                }
                        
            }

            ticketPricetextBox.Text=""+ticketprice;
        }

        // here we are making sure that only digits 0-9 can be pressed and no more than 3 digits can be entered
        private void groupSizetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            groupSizetextBox.MaxLength = 3;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void groupSizetextBox_TextChanged(object sender, EventArgs e)
        {
            confirmTicketbutton.Enabled = false;
          
        }

        // here we are making sure that only digits 0-9 can be pressed and no more than 3 digits can be entered
        private void noOfChildrentextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            noOfChildrentextBox.MaxLength = 3;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        // Confirm ticket button is only enabled after price is generated 
        // If any changes are made to ticket options, the button must be disabed
        // Button will br re-enabled when ticket price button is pressed and ticket price is obtained
        private void noOfChildrentextBox_TextChanged(object sender, EventArgs e)
        {
            confirmTicketbutton.Enabled = false;
            
        }

        // Confirm ticket button is only enabled after price is generated 
        // If any changes are made to ticket options, the button must be disabed
        // Button will br re-enabled when ticket price button is pressed and ticket price is obtained
        private void durationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirmTicketbutton.Enabled = false;
        }

        // Here we make sure when add categories button is pressed, window for adding categories will appear
        // we then disable the button to only allow one instance of the window
        private void addCategoriesbutton_Click(object sender, EventArgs e)
        {
            ratesandCategoriesForm f2 = new ratesandCategoriesForm();
            f2.Show();
            f2.FormClosed += ratesandCategoriesForm_FormClosed;
            addCategoriesbutton.Enabled = false;
            
        }

        // When the wnidow to add categories is closed, the button to add categories is enabled but only if admin is logged in
        private void ratesandCategoriesForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (loggedin) {
                addCategoriesbutton.Enabled = true;
            }
            
           
        }

        // Just clearing some fields
        private void clearGroup() {
            groupSizetextBox.Clear();
            noOfChildrentextBox.Clear();
            groupTypecomboBox.SelectedIndex = 0;
        }

        // Just clearing some fields
        private void ClearAdmin() {
            userNametextBox.Text = "";
            passwordtextBox.Text = "";
            

        }
        // Just clearing some fields
        private void clearIndividual() {
            customerTypecomboBox.SelectedIndex=0;
            durationcomboBox.SelectedIndex = 0;
        }
        // Just clearing some fields
        private void clearALlFields() {
            clearGroup();
            clearIndividual();
            ticketPricetextBox.Text = "";
            confirmTicketbutton.Enabled = false;
            ClearAdmin();
        }
        // Just clearing some fields
        private void resetFieldsbutton_Click(object sender, EventArgs e)
        {
            clearALlFields();
        }

        // Pressing this button will restart the application
        private void restartbutton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Ticket price is calculated and confirm button is enabled
        private void ticketPricebutton_Click(object sender, EventArgs e)
        {
            calculate();
            confirmTicketbutton.Enabled = true;
        }

        // When confirm ticket button is pressed, if every think checks out, a record is created and added to report
        // tickets can only be purchased between 10 AM and 6 PM
        // duration of the ticket is alculated according to first letter of the category/ duration
        // if first letter is digit, it is added to current duration
        // standard duration is assumed to be 3hrs
        // if duration exceeds closing time 6PM, exit duration is set to 6PM

        private void confirmTicketbutton_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            TimeSpan openingTime = new TimeSpan(10, 0, 0);
            TimeSpan closingTime = new TimeSpan(18, 0, 0);
            TimeSpan exitTime = new TimeSpan();
            if (currentTime < openingTime || currentTime > closingTime)
            {
                MessageBox.Show("The opening time of the recreational centre is 10:00 AM to 06:00 PM");
            }
            else
            {
                Report report = new Report();
                customerType = customerTypecomboBox.SelectedItem.ToString();
                ticketCategory = durationcomboBox.SelectedItem.ToString();
                ticketPrice = Convert.ToDouble(ticketPricetextBox.Text);

                if (customerType == "Individual-Adult")
                {
                    groupSize = 1;
                    adults = 1;
                    children = 0;
                }
                else if (customerType == "Individual-Child")
                {
                    groupSize = 1;
                    adults = 0;
                    children = 1;
                }
                else
                {
                    groupType = groupTypecomboBox.SelectedItem.ToString();
                    groupSize = Convert.ToInt32(groupSizetextBox.Text);
                    switch (groupType)
                    {
                        case "Children":
                            adults = 0;
                            children = Convert.ToInt32(groupSizetextBox.Text);
                            break;

                        case "Mixed":
                            adults = groupSize - Convert.ToInt32(noOfChildrentextBox.Text);
                            children= Convert.ToInt32(noOfChildrentextBox.Text);
                            break;

                        default:
                            adults = Convert.ToInt32(groupSizetextBox.Text);
                            children = 0;
                            break;
                    }
                }
                entry = DateTime.Now.ToShortTimeString();
                if (char.IsDigit(durationcomboBox.SelectedItem.ToString()[0]))
                {
                    int hourToAdd = Convert.ToInt32(durationcomboBox.SelectedItem.ToString()[0]);
                    double hoursToAdd = Convert.ToDouble(hourToAdd);
                    if (hoursToAdd > 0)
                    {
                        exitTime = currentTime + TimeSpan.FromHours(hoursToAdd);
                    }
                    else
                    {
                        exitTime = TimeSpan.FromHours(3);
                    }
                }
                else if (durationcomboBox.SelectedItem.ToString() == "Whole Day")
                {
                    exitTime = closingTime;
                }
                else
                {
                    exitTime = TimeSpan.FromHours(3);
                }
                var t1 = new DateTime() + exitTime;
                var t2 = new DateTime() + closingTime;
                int result = TimeSpan.Compare(t1.TimeOfDay, t2.TimeOfDay);
                if (result == 1) {
                    exitTime = closingTime;
                }
              
                var exitDT = new DateTime()+exitTime;
                exit= exitDT.ToShortTimeString();
                report.Customer_Type = customerType;
                report.Ticket_Category = ticketCategory;
                report.Ticket_Price = ticketPrice;
                report.Group_Size = groupSize;
                report.Adults = adults;
                report.Children = children;
                report.Date= DateTime.Now.ToString("dd/MMM/yyyy");
                report.Day = DateTime.Now.DayOfWeek.ToString();
                report.Entry = entry;
                report.Exit = exit;

                reportList.Add(report);
                accessValues.WriteCSVFile(reportCSVPath, reportList);
                MessageBox.Show("Ticket confirmed. Enjoy your time here.");
                reportList.Clear();
                clearALlFields();

            }
        }
        // Here we make sure when add categories button is pressed, window for report appears
        // we then disable the button to only allow one instance of the window
        private void reportbutton_Click(object sender, EventArgs e)
        {
            ReportForm f3 = new ReportForm();
            f3.Show();
            f3.FormClosed += ReportForm_FormClosed;
            reportbutton.Enabled = false;
        }

        // Re enabling report button when report window is clsed
        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportbutton.Enabled = true;

        }

        //login button enables add categories button if login details are correct.

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";
            if (userNametextBox.Text != "" && passwordtextBox.Text != "")
            {
                if (userNametextBox.Text == username && passwordtextBox.Text == password)
                {
                    addCategoriesbutton.Enabled = true;
                    loginbutton.Enabled = false;
                    logoutbutton.Enabled = true;
                    loginpanel.Enabled = false;
                    loggedin = true;
                    ClearAdmin();
                }
                else {
                    MessageBox.Show("Username and Password do not match");
                }
            }
            else {
                Console.WriteLine("Enter username and password");
            }
        }


        // logout button disables add cateegories button
        private void logoutbutton_Click(object sender, EventArgs e)
        {
            addCategoriesbutton.Enabled = false;
            loginbutton.Enabled = true;
            logoutbutton.Enabled = false;
            loginpanel.Enabled = true;
            loggedin = false;
        }
    }
}
