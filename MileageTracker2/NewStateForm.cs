using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageTracker2
{
    public partial class NewStateForm : Form
    {        
        public string StateName { get; private set; }
        public NewStateForm()
        {
            InitializeComponent();
        }        

        

        private void createStateButton_Click(object sender, EventArgs e)
        {
            StateName = stateNameComboBox.SelectedItem.ToString(); 
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }
    }
}
