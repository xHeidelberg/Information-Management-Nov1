using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//SQL
using MySql.Data.MySqlClient;

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


        // Database View Trigger (Test)
        public static void viewDatabaseTrigger()
        {
            string initiateConnection = "server=localhost;user id=user;password=123456789;database=basemanage";
            string selector = "SELECT * FROM basemanage.credential";

            using (MySqlConnection connect = new MySqlConnection(initiateConnection))
            {
                connect.Open();
                // Connection Logic Here
               try
               {
                    // Create command
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

    }
}
