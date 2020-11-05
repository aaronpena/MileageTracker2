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

namespace MileageTracker2
{
    public partial class ChooseReportForm : Form
    {
        string[] fileEntries;
        public string ChosenExpenseReport { get; private set; }
        public ChooseReportForm(string[] fileEntries)
        {
            InitializeComponent();
            this.fileEntries = fileEntries; 
        }

        private void ChooseReportForm_Load(object sender, EventArgs e)
        {
            foreach (var filePath in fileEntries)
            {
                string fileName = Path.GetFileName(filePath); 
                listBox1.Items.Add(fileName); 
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                int indexOfExpReportPath = listBox1.SelectedIndex;
                ChosenExpenseReport = fileEntries[indexOfExpReportPath];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
