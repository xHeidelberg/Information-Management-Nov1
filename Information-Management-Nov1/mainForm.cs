// SQL
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Management_Nov1
{
    public partial class mainForm : Form
    {
        private DataTable vehicleTable;
        // Minimum of 14 - 17 Engine Number/Chassis Number
        public mainForm()
        {
            InitializeComponent();
            mainGrid.CellDoubleClick += mainGrid_DoubleClick; // Double Click update
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = mainGrid.SelectedRows[0];

                    // validate
                    if (int.TryParse(selectedRow.Cells["recordNumber"].Value.ToString(), out int recordIdToDelete))
                    {
                        // Confirmation dialog
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected record?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            crudInitiator dbManager = new crudInitiator();

                            // separate
                            if (dbManager.deleteInitiator(recordIdToDelete))
                            {
                                mainGrid.Rows.RemoveAt(selectedRow.Index);
                                MessageBox.Show("Record deleted successfully!");
                                allControl.viewDatabaseTrigger(mainGrid); // Refresh the grid
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not get the ID from the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to delete the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchPop searchPop = new searchPop();
            searchPop.ShowDialog();
        }




        // Double Click to update
        private void LoadVehicleData()
        {
            string sqlQuery = "SELECT recordNumber, engineNumber, chasisNumber, engineSize, model, yearModel, ownerName, purchaseDate FROM basemanage.vehiclelist";
            string connectionString = "server=localhost; user id=user; password=123456789; database=basemanage";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable vehicleTable = new DataTable();
                        adapter.Fill(vehicleTable);
                        mainGrid.DataSource = vehicleTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicle data from MySQL: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mainGrid_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (mainGrid.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    // Store the unique record ID as a string
                    string selectedRecordId = mainGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    using (updatePop vehicleUpdateForm = new updatePop(selectedRecordId))
                    {
                        DialogResult result = vehicleUpdateForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            LoadVehicleData();
                        }
                    }
                }
            }
        }

    }
}
