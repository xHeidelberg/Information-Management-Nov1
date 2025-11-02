using MySql.Data.MySqlClient;
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
    public partial class updatePop : Form
    {
        private string ConnectionString = "server=localhost;database=basemanage;uid=user;pwd=123456789;";
        private string _currentRecordId;
        public updatePop(string recordId)
        {
            _currentRecordId = recordId;
            InitializeComponent();
            LoadSingleRecordDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSingleRecordDetails()
        {
            string sqlQuery = "SELECT engineNumber, chasisNumber, engineSize, model, yearModel, ownerName, purchaseDate FROM basemanage.vehiclelist WHERE recordNumber = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", _currentRecordId);
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            engineNumber.Text = reader["engineNumber"].ToString();
                            chassisNumber.Text = reader["chasisNumber"].ToString();
                            engineSize.Text = reader["engineSize"].ToString();
                            model.Text = reader["model"].ToString();
                            yearModel.Text = reader["yearModel"].ToString();
                            ownerName.Text = reader["ownerName"].ToString();
                            purchaseDate.Value = Convert.ToDateTime(reader["purchaseDate"]); 
                        }
                        else
                        {
                            MessageBox.Show("Record not found! Closing edit window.", "Error");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading record: {ex.Message}", "Database Error");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string sqlUpdateQuery = "UPDATE basemanage.vehiclelist SET " +
                                "engineNumber = @engineNum, chasisNumber = @chasisNum, engineSize = @engineSize, " +
                                "model = @model, yearModel = @yearModel, ownerName = @ownerName, purchaseDate = @purchaseDate " +
                                "WHERE recordNumber = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                using (MySqlCommand command = new MySqlCommand(sqlUpdateQuery, connection))
                {
                    command.Parameters.AddWithValue("@engineNum", engineNumber.Text);
                    command.Parameters.AddWithValue("@chasisNum", chassisNumber.Text);
                    command.Parameters.AddWithValue("@engineSize", engineSize.Text);
                    command.Parameters.AddWithValue("@model", model.Text);
                    command.Parameters.AddWithValue("@yearModel", yearModel.Text);
                    command.Parameters.AddWithValue("@ownerName", ownerName.Text);
                    command.Parameters.AddWithValue("@purchaseDate", purchaseDate.Value);
                    command.Parameters.AddWithValue("@id", _currentRecordId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!", "Success");
                        this.DialogResult = DialogResult.OK; // pass success back to mainfirm
                    }
                    else
                    {
                        MessageBox.Show("Update failed or no changes were made.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Database Error");
            }
           
            this.Close();
        }
    }
    
}
