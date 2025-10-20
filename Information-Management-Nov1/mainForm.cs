using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// SQL
using MySql.Data.MySqlClient;

namespace Information_Management_Nov1
{
    public partial class mainForm : Form
    {
        // Minimum of 14 - 17 Engine Number/Chassis Number
        public mainForm()
        {
            InitializeComponent();
            allControl.viewDatabaseTrigger(mainGrid); // auto load without reload
        }

        private void linkedLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (allControl.logoutTrigger() == true)
            {
                this.Hide();
                loginForm login = new loginForm();
                login.ShowDialog();
                // wait for the login to close before closing main form
                this.Close();
            }

        }

        private void linkedMinimize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            allControl.MinimizeTrigger(this); //Minimize
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            allControl.ExitTrigger(); //Exit    
        }

        private void linkedReload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            allControl.viewDatabaseTrigger(mainGrid); // Reload
            statusLabel.Text = "Reloading";
            statusLabel.ForeColor = Color.Red;

            allControl.statusLabelTrigger(statusLabel, "Reloading", System.Drawing.Color.Red);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            /*
          column:		recordNumber, engineNumber, chasisNumber, engineSize, model, yearModel, ownerName, purchaseDate
		    Type:    	varchar			varchar		  varchar		int       text     year      varchar     date
         */
            string engine = enginenumberInput.Text;
            string chassis = chassisInput.Text;
            string enginesize = enginesizeInput.Text;
            string model = modelInput.Text;
            string yearmodel = yearPicker.Value.ToString("yyyy");
            string ownername = ownernameInput.Text;
            string purchaseDate = purchaseDatePicker.Value.ToString("yyyy-MM-dd");


            bool isSuccess = crudInitiator.addInitiator(engine, chassis, enginesize, model, yearmodel, ownername, purchaseDate);

            if (isSuccess)
                {
                    // Optional: Update status label using the previously corrected trigger
                    allControl.statusLabelTrigger(statusLabel, "Data Added!", System.Drawing.Color.Green);

                    // Clear input fields
                    chassisInput.Clear();
                    enginenumberInput.Clear();
                    enginesizeInput.Clear();
                    modelInput.Clear();
                    yearPicker.Value = DateTime.Now;
                    ownernameInput.Clear();
                    purchaseDatePicker.Value = DateTime.Now;

                //refresg
                allControl.viewDatabaseTrigger(mainGrid);

            }

        }

    }
}
