using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BijayBharatiCW
{
    //Defining all required variables and paths for files to be used
    public partial class ratesandCategoriesForm : Form
    {
        string ratesCSVPath = Path.Combine(Environment.CurrentDirectory, @"my_files\rates.csv");
        List<Rates> rateList = new List<Rates>();
        List<Rates> modified = new List<Rates>();
        Rates modifications = new Rates();
        RatesService accessValues = new RatesService();
        string newDuration;
        double newAdultRate;
        double newChildrenRate;
        string valueToDelete;
        Boolean recordExists;
        public ratesandCategoriesForm()
        {
            InitializeComponent();
        }
        
        // When form is opened, data about rates is loaded
        private void ratesandCategoriesForm_Load(object sender, EventArgs e)
        {

            loadGrid();
            
        }

        // Data from rates.csv file is loaded in the grid view
        private void loadGrid() {
            var readCategoriesRates = accessValues.ReadCSVFile(ratesCSVPath);

            foreach (Rates item in readCategoriesRates)
            {
                rateList.Add(item);
            }
            ratedataGridView.DataSource = rateList;
        }

        // Method to add data to rates.csv file
        // If every condition succeedes, an object of Rates class is created and appended to the csv file
        // Invalid and duplicates are checked
        private void addbutton_Click(object sender, EventArgs e)
        {
            if (modifyDurationtextBox.Text != "" && modifyAdultRatetextBox.Text != "" && modifyChildrenRatetextBox.Text != "")
            {
                newDuration = modifyDurationtextBox.Text;
                newAdultRate = Convert.ToDouble(modifyAdultRatetextBox.Text);
                newChildrenRate = Convert.ToDouble(modifyChildrenRatetextBox.Text);


                
                foreach (Rates item in rateList)
                {
                    if (item.Duration.ToLower() == newDuration.ToLower())
                    {
                        recordExists = true;
                        break;
                        
                    }
                    else
                    {
                        recordExists = false;
                        
                    }

                }
                if (recordExists == true)
                {
                    MessageBox.Show("Record Exists");
                }
                else
                {
                    modifications.Duration = newDuration;
                    modifications.Adult_Rate = newAdultRate;
                    modifications.Children_Rate = newChildrenRate;

                    modified.Add(modifications);

                    accessValues.WriteCSVFile(ratesCSVPath, modified);
                    modified.Clear();
                    clearFields();
                    rateList.Clear();
                    
                    //ratedataGridView.DataSource = null;
                    loadGrid();
                    
                    recordExists = true;
                    DialogResult dialogResult = MessageBox.Show("App needs to restart to load changes \n Click Yes to restart now, No to restart later", "Restart", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Console.WriteLine("Restart required");
                    }
                }
            }
            else {
                MessageBox.Show("Please fill all the fields with proper values");
            }

        }
        // An existing item is deleted from the loaded  list and the list is re written to the file replacing previous records
        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (deleteValuetextBox.Text != "")
            {
                valueToDelete = deleteValuetextBox.Text;
                foreach (Rates item in rateList)
                {
                    if (item.Duration.ToLower() == valueToDelete.ToLower())
                    {
                        recordExists = true;
                        break;

                    }
                    else
                    {
                        recordExists = false;

                    }

                }
                if (recordExists == true)
                {
                    var itemToRemove = rateList.Single(r => r.Duration == valueToDelete);
                    rateList.Remove(itemToRemove);

                    accessValues.UpdateCSVFile(ratesCSVPath, rateList);
                    clearFields();
                    DialogResult dialogResult = MessageBox.Show("App needs to restart to load changes \n Click Yes to restart now, No to restart later", "Restart", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Console.WriteLine("Restart required");
                    }
                }
                else
                {
                    MessageBox.Show("Data already deleted or does not exist");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields with proper values");
            }

        }

        // Clearing fields
        public void clearFields() {
            modifyDurationtextBox.Clear();
            modifyAdultRatetextBox.Clear();
            modifyChildrenRatetextBox.Clear();
            deleteValuetextBox.Clear();
        }
        // Making sure only numbers are allowed in the field
        private void modifyAdultRatetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        // Making sure only numbers are allowed in the field
        private void modifyChildrenRatetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        // an existing record is checked and the rates are replaced with nrw rates
        // new list containing modified values is re written to the file
        private void modifybutton_Click(object sender, EventArgs e)
        {
            if (modifyDurationtextBox.Text != "" && modifyAdultRatetextBox.Text != "" && modifyChildrenRatetextBox.Text != "")
            {
                newDuration = modifyDurationtextBox.Text;
                newAdultRate = Convert.ToDouble(modifyAdultRatetextBox.Text);
                newChildrenRate = Convert.ToDouble(modifyChildrenRatetextBox.Text);



                foreach (Rates item in rateList)
                {
                    if (item.Duration.ToLower() == newDuration.ToLower())
                    {
                        item.Adult_Rate = newAdultRate;
                        item.Children_Rate = newChildrenRate;
                        recordExists = true;
                        break;

                    }
                    else
                    {
                        recordExists = false;

                    }

                }
                if (recordExists == true){

                    accessValues.UpdateCSVFile(ratesCSVPath, rateList);
                    

                    DialogResult dialogResult = MessageBox.Show("App needs to restart to load changes \n Click Yes to restart now, No to restart later", "Restart", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Console.WriteLine("Restart required");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Record that you are trying to modify does not exist");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields with proper values");
            }
        }
    }
}
