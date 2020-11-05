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


namespace MileageTracker2
{
    public partial class Form1 : Form
    {
        State currentState; 
        ExpenseReport currentReport;
        bool dateChanged = true;        
        private object endLocation;//because clicking elsewhere unselects the item in the combobox!   
        private object startLocation;//because clicking elsewhere unselects the item in the combobox!
        public Form1()
        {
            InitializeComponent();
            currentState = new State("New Mexico");
            currentState.LoadState(currentState.StateFilePath);//this is trying to load New Mexico .dat file if there is one.             
            currentReport = new ExpenseReport(currentState);
            displayReportChoices(); 
            UpdateForm(); 
        }               
        private void fromDropMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            startLocation = start.SelectedItem; 
            if (startLocation != null && endLocation != null)            
                getDistance(startLocation.ToString(), endLocation.ToString());             
        }
        private void enableStartButton_Click(object sender, EventArgs e)
        {
            start.Enabled = true;
        }

        private void resetFormContents()
        {
            start.Enabled = true; 
        }
        private void toDropMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            endLocation = destination.SelectedItem; 
            if (startLocation != null && endLocation != null)
                getDistance(startLocation.ToString(), endLocation.ToString());            
        }
        private void addDistanceButton_Click(object sender, EventArgs e)
        {
            if (mileCounter.Value > 0)
            {
                
                string locations = start.SelectedItem + ", " + destination.SelectedItem;
                currentState.distanceKeeper.EnterMilesBetween(locations, (int)mileCounter.Value);
                mileCounter.Enabled = false;
                addDistanceButton.Enabled = false;
                addTripButton.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }
            else            
                MessageBox.Show("miles value can not be 0");            
        }
        private void addTripButton_Click(object sender, EventArgs e)
        {
            if (dateChanged == true)
            {
                currentReport.AddDateToReport(tripDateTime.Value); 
                dateChanged = false; 
            }
            
            int miles = currentState.distanceKeeper.ReturnDistanceBetweenLocations(startLocation.ToString(), endLocation.ToString());
            if (start.Enabled == true)
            {
                currentReport.AddTripToReport(start.SelectedItem.ToString(), destination.SelectedItem.ToString(), miles);
            }
            else
            {
                currentReport.AddTripToReport(destination.SelectedItem.ToString(), miles);
            }             
            UpdateForm();
            totalMileageTab1.Text = currentReport.TotalMileage.ToString();
            totalMileageTab2.Text = currentReport.TotalMileage.ToString();
            start.SelectedItem = endLocation; 
            start.Enabled = false;
            enableStartButton.Enabled = true;
            mileCounter.Value = 0;
            mileCounter.Enabled = false;
            addTripButton.Enabled = false;
            saveToolStripMenuItem.Enabled = true;
        }
        private void addLocationButton_Click(object sender, EventArgs e)
        {           
            if (currentState.IsLocationNew(locationName.Text) == true)
            {
                currentState.AddLocation(locationName.Text, locationAddress.Text);
                UpdateForm();
                MessageBox.Show("Location has been added");
                saveToolStripMenuItem.Enabled = true;
                locationName.Clear();
                locationAddress.Clear();
                addLocationButton.Enabled = false;                
            }
            else
            {
                MessageBox.Show("This location already exists");
                locationName.Clear();
                locationAddress.Clear();
            }                        
        }        
        private void UpdateForm()
        {
            clearExpenseInfoFromForm();
            clearStateInfoFromForm(); 
            Text = currentState.Name; 
            foreach (string key in currentState.Locations.Keys)
            {
                start.Items.Add(key);
                destination.Items.Add(key);
            }            
            foreach (var trip in currentReport.Trips)
            {
                tripTextBox.Text += trip; 
            }
            foreach (var expense in currentReport.Expenses)
            {
                expensesTextBox.Text += expense;
            }
            dataGridView1.DataSource = (from address in currentState.Locations
                                        orderby address.Key
                                        select new { address.Key, address.Value }).ToList();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            currentReport.CalculateProfit(mileageRate.Value); 
            totalMileageTab1.Text = currentReport.TotalMileage.ToString();
            totalMileageTab2.Text = currentReport.TotalMileage.ToString();
            dollarAmountTB.Text = currentReport.DollarAmount.ToString(); 
            gasMaintTB.Text = currentReport.TotalExpenses.ToString();
            profitTB.Text = currentReport.Profit.ToString();
        }                
        private void newStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStateForm secondForm = new NewStateForm();
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentState = new State(secondForm.StateName);                
                currentState.Locations.Clear();
                currentReport = new ExpenseReport(currentState);                
                UpdateForm();
                resetFormContents(); 
            }
             
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save new data?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                
                currentState.SaveState();               
                currentReport.SaveReport();                
            }
        }        
        private void tripsDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            start.Enabled = true;
            dateChanged = true;
        }
        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            if (expenseAmount.Value > 0)
            {
                bool expenseAlreadyExists = currentReport.AddExpenseToReport(expenseDateTimePicker.Value.ToString("M"), expenseType.Text, expenseAmount.Value);
                if (expenseAlreadyExists == true)
                {
                    MessageBox.Show("That expense already exists. Please change expense parameters.");
                }
                UpdateForm();
            }
            else
            {
                MessageBox.Show("expense amount cannot be 0");     
            }
        }
        private void getDistance(string fromDropMenuString, string toDropMenuString)
        {
            if (fromDropMenuString == toDropMenuString)
            {
                mileCounter.Enabled = false;
                addDistanceButton.Enabled = false; 
                return;
            }
            else
            {
                mileCounter.Value = currentState.distanceKeeper.ReturnDistanceBetweenLocations(fromDropMenuString, toDropMenuString);
                if (mileCounter.Value == 0)
                {
                    mileCounter.Enabled = true;
                    addDistanceButton.Enabled = true;
                }
                else
                {
                    addTripButton.Enabled = true;
                    addDistanceButton.Enabled = false;
                    mileCounter.Enabled = false;
                }
            }
        }       
        private void expenseAmount_ValueChanged(object sender, EventArgs e)
        {
            addExpenseButton.Enabled = true; 
        }
        private void locationName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(locationAddress.Text) && (!string.IsNullOrWhiteSpace(locationName.Text)))
                addLocationButton.Enabled = true;
            else
                addLocationButton.Enabled = false; 
        }
        private void locationAddress_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(locationName.Text) && (!string.IsNullOrWhiteSpace(locationAddress.Text)))
                addLocationButton.Enabled = true;
            else
                addLocationButton.Enabled = false;
        }        
        private void openExpenseReport_Click(object sender, EventArgs e)
        {
            displayReportChoices(); 
        }
        private void clearExpenseInfoFromForm()
        {
            tripTextBox.Clear();
            totalMileageTab1.Clear();
            totalMileageTab2.Clear();
            expensesTextBox.Clear();
            gasMaintTB.Clear();
            dollarAmountTB.Clear();
        }
        private void clearStateInfoFromForm()
        {
            start.Items.Clear();
            start.ResetText();
            destination.Items.Clear();
            destination.ResetText();
        }
        private void displayReportChoices()
        {
            string[] fileEntries = currentReport.ReturnExpenseReports();
            if (fileEntries.Count() > 0)  
            {
                ChooseReportForm reportForm = new ChooseReportForm(fileEntries);
                DialogResult result = reportForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentReport = currentReport.DeserializeReport(reportForm.ChosenExpenseReport);
                    currentState = currentReport.CurrentState; 
                    UpdateForm();
                }
            }
        }

        private void newExpenseReportBtn_Click(object sender, EventArgs e)
        {
            clearExpenseInfoFromForm(); 
        }
    }
}
