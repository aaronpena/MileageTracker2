using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 

namespace MileageTracker2
{
    [Serializable]
    public class ExpenseReport
    {
        
        public int TotalMileage { get; private set; } 
        public List<string> Expenses = new List<string>();
        public List<string> Trips = new List<string>(); 
        public decimal TotalExpenses { get; private set; }                
        public string ReportName { get; private set; }
        public string StateName { get; private set; }
        public string ExpenseReportFolderPath { get; private set; }
        public string ExpenseReportFilePath { get; private set; }
        public decimal Profit { get; private set; }
        public decimal DollarAmount { get; private set; }
        public State CurrentState { get; private set; }
        public ExpenseReport(State state)
        {
            CurrentState = state;
            CreateNewReportName(); 
            createExpenseReportFilePaths();             
        }        
        public void SaveReport()
        {
            if (Directory.Exists(ExpenseReportFolderPath) == false)
            {
                Directory.CreateDirectory(ExpenseReportFolderPath); 
            }
            using (Stream output = File.Create(ExpenseReportFilePath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, this);
            }
        }
        public ExpenseReport DeserializeReport(string fileToOpen)
        {
            using (Stream input = File.OpenRead(fileToOpen))
            {
                ExpenseReport tempReport;
                BinaryFormatter formatter = new BinaryFormatter();
                tempReport = (ExpenseReport)formatter.Deserialize(input);
                return tempReport;
            }
        }
        public bool AddExpenseToReport(string date, string type, decimal value)
        {
             
            string expense = date + " " + type + " $" + value + Environment.NewLine;
            foreach (var exp in Expenses)
            {
                if (expense == exp)
                {
                    return true; 
                }
            }
            TotalExpenses += value;
            Expenses.Add(expense);
            return false; 
        }
        public void AddTripToReport(string start, string end, int miles)
        {
            string trip = start + Environment.NewLine + end + " - " + miles + " miles" + Environment.NewLine;
            Trips.Add(trip);
            TotalMileage += miles; 
        }
        public void AddTripToReport(string end, int miles)
        {
            string trip = end + " - " + miles + " miles" + Environment.NewLine;
            Trips.Add(trip);
            TotalMileage += miles; 
        }
        public void AddDateToReport(DateTime date)
        {
            string dateToAdd = date.ToString("M") + Environment.NewLine;
            Trips.Add(dateToAdd); 
        }
        public void CreateNewReportName()
        {
            ReportName = DateTime.Now.ToString("MMMM dd");
            //ReportName = "November 03"; 
        }
        private void createExpenseReportFilePaths()
        {
            ExpenseReportFolderPath = CurrentState.mileageTrackerFolderPath + @"\Expense Reports";
            ExpenseReportFilePath = ExpenseReportFolderPath + @"\" + CurrentState.Name + " " + ReportName + ".dat";
        }
        public string[] ReturnExpenseReports()
        {
            string[] fileEntries = new string[0]; 
            if (Directory.Exists(ExpenseReportFolderPath))
            {
                fileEntries = Directory.GetFiles(ExpenseReportFolderPath); 
                return fileEntries;
            }
            else return fileEntries; 
        }
        public void CalculateProfit(decimal mileageRate)
        {
            DollarAmount = TotalMileage * mileageRate;
            Profit = DollarAmount - TotalExpenses; 
        }
    }
}
