using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Management_Nov1
{
    public partial class searchPop : Form
    {
        public searchPop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataIntoDataGridView(string engineNum = "", string chasisNum = "", string engineS = "",
    string mod = "", string yearM = "", string ownerN = "", string purchaseD = "")
        {
            DataTable searchResults = crudInitiator.searchInititiator(engineNum, chasisNum, engineS, mod, yearM, ownerN, purchaseD);
            searchGrid.DataSource = searchResults;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string engineNumber = enginenumberInput.Text;
            string chasisNumber = chassisInput.Text;
            string engineSize = enginesizeInput.Text;
            string model = modelInput.Text;
            string yearModel = yearPicker.Text;
            string ownerName = ownernameInput.Text;

            if (string.IsNullOrEmpty(engineNumber) && string.IsNullOrEmpty(chasisNumber) && string.IsNullOrEmpty(engineSize) &&
                string.IsNullOrEmpty(model) && string.IsNullOrEmpty(yearModel) && string.IsNullOrEmpty(ownerName))
            {
                MessageBox.Show("Please fill in at least one search field.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LoadDataIntoDataGridView(engineNumber, chasisNumber, engineSize, model, yearModel, ownerName);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Would you like to reload the data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes)
            {
                allControl.viewDatabaseTrigger(searchGrid);
            }
            else
            {
                enginenumberInput.Clear();
                chassisInput.Clear();
                enginenumberInput.Clear();
                enginenumberInput.Clear();
                enginenumberInput.Clear();
                enginenumberInput.Clear();
                enginenumberInput.Clear();
                searchGrid.DataSource = null;
                MessageBox.Show("Cleared", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
