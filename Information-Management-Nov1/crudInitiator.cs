using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Information_Management_Nov1
{
    public class crudInitiator
    {
        private static string initiateConnection = "server=localhost;user id=user;password=123456789;database=basemanage";


        /*
          column:		recordNumber, engineNumber, chasisNumber, engineSize, model, yearModel, ownerName, purchaseDate
		    Type:    	varchar			varchar		  varchar		int       text     year      varchar     date
         */
        public static bool addInitiator(string engine, string chassis, string enginesize,
                string model, string yearmodel, string ownername, string purchaseDate)
        {
            string initiateConnection = "server=localhost;user id=user;password=123456789;database=basemanage";
            string insertQuery = "INSERT INTO basemanage.vehiclelist (engineNumber, chasisNumber, engineSize, model, yearModel, ownerName, purchaseDate) " +
                                 "VALUES (@engine, @chassis, @size, @model, @year, @owner, @purchase)";

            using (MySqlConnection connect = new MySqlConnection(initiateConnection))
            {
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@engine", engine);
                    cmd.Parameters.AddWithValue("@chassis", chassis);
                    cmd.Parameters.AddWithValue("@size", enginesize);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@year", yearmodel);
                    cmd.Parameters.AddWithValue("@owner", ownername);
                    cmd.Parameters.AddWithValue("@purchase", purchaseDate);


                    try
                    {
                        connect.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New Record Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Data not Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    catch (MySqlException sqlEx)
                    {
                        MessageBox.Show("Database error during insert: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                        {
                            connect.Close();
                        }
                    }
                }
            }

        }

        // Method to delete a record from the database
        public bool deleteInitiator(int recordId)
        {
            string deleteQuery = "DELETE FROM vehiclelist WHERE recordNumber = @id;";

            using (MySqlConnection connection = new MySqlConnection(initiateConnection))
            {
                using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                {
                    // Use parameter to prevent SQL Injection (VERY IMPORTANT for beginners!)
                    command.Parameters.AddWithValue("@id", recordId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true; // Success deleted
                        }
                        else
                        {
                            MessageBox.Show("Record not found or not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }


        public static void updateInitiator()
        {
            // Logic Update Button (New Form)
        }

        public static DataTable searchInititiator(
        string engineNumber,
        string chasisNumber,
        string engineSize,
        string model,
        string yearModel,
        string ownerName,
        string purchaseDate)
        {
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(initiateConnection);

            try
            {
                connection.Open();
                string baseQuery = "SELECT * FROM basemanage.vehiclelist";
                string whereClause = "";
                MySqlCommand command = new MySqlCommand(baseQuery, connection);
                if (!string.IsNullOrEmpty(engineNumber.Trim()))
                {
                    whereClause += " engineNumber LIKE @engineNumber AND";
                    // Use LIKE with % for partial matches
                    command.Parameters.AddWithValue("@engineNumber", "%" + engineNumber.Trim() + "%");
                }
                if (!string.IsNullOrEmpty(chasisNumber.Trim()))
                {
                    whereClause += " chasisNumber LIKE @chasisNumber AND";
                    command.Parameters.AddWithValue("@chasisNumber", "%" + chasisNumber.Trim() + "%");
                }
                if (!string.IsNullOrEmpty(engineSize.Trim()))
                {
                    whereClause += " engineSize LIKE @engineSize AND";
                    command.Parameters.AddWithValue("@engineSize", "%" + engineSize.Trim() + "%");
                }
                if (!string.IsNullOrEmpty(model.Trim()))
                {
                    whereClause += " model LIKE @model AND";
                    command.Parameters.AddWithValue("@model", "%" + model.Trim() + "%");
                }
                if (!string.IsNullOrEmpty(ownerName.Trim()))
                {
                    whereClause += " ownerName LIKE @ownerName AND";
                    command.Parameters.AddWithValue("@ownerName", "%" + ownerName.Trim() + "%");
                }

                // 3. Finalize the query
                if (!string.IsNullOrEmpty(whereClause))
                {
                    // Remove the last " AND" and prepend " WHERE "
                    whereClause = " WHERE" + whereClause.Remove(whereClause.Length - 4);
                    command.CommandText = baseQuery + whereClause;
                }
                else
                {
                    // If all fields are empty, just select all records
                    command.CommandText = baseQuery;
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed even if an error occurs
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return dt;
        }

    }






}