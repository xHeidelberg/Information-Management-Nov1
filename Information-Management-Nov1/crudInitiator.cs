//SQL
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Information_Management_Nov1
{
    public static class crudInitiator
    {

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
                }
            }

        }

        public static void deleteInitiator()
        {
            // Logic Delete Button (Datagridview Select)
        }

        public static void updateInitiator()
        {
            // Logic Update Button (New Form)
        }

        public static void searchInitiator()
        {
            // Logic Search Button (New Form)
        }

    }
}
