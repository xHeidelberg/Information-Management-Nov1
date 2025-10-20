//SQL
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Information_Management_Nov1
{
    public static class allControl
    {
        // re-use control
        public static void ExitTrigger()
        {
            DialogResult exitQuestion = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exitQuestion == DialogResult.Yes)
                Environment.Exit(0);
            else return;

        }

        public static bool logoutTrigger()
        {
            loginForm login = new loginForm();
            DialogResult logoutQuestion = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logoutQuestion == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }
        public static void MinimizeTrigger(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }


        // Database View Trigger (need refine) 
        public static void viewDatabaseTrigger(DataGridView mainGrid)
        {
            string initiateConnection = "server=localhost;user id=user;password=123456789;database=basemanage";
            string selector = "SELECT * FROM basemanage.vehiclelist";

            MySqlDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            if (dataTable != null)
            {
                dataTable.Clear();
            }

            using (MySqlConnection connect = new MySqlConnection(initiateConnection))
            {
                try
                {
                    connect.Open();
                    dataAdapter = new MySqlDataAdapter(selector, connect); // path and connection
                    dataAdapter.Fill(dataTable); 
                    mainGrid.DataSource = dataTable;
                    mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Database connection error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

            

        }

        // Status Label Trigger
        public static void statusLabelTrigger(Label statusLabel, string initialText, Color initialColor)
        {
            statusLabel.Text = initialText;
            statusLabel.ForeColor = initialColor;

            Timer timer = new Timer();
            // 1000 ms (1 seconds)
            timer.Interval = 3000;

            // s = sender, args = event System.Windows.Forms.Timer.Tick
            timer.Tick += (s, args) =>
            {
                // Code to execute after the 3-second delay:
                statusLabel.Text = "Latest";
                statusLabel.ForeColor = Color.Green;

                timer.Stop();
                timer.Dispose();
            };

            timer.Start();
        }

    }
}
