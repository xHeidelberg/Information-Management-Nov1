using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Information_Management_Nov1
{
    public static class loginManage
    {
        public static void ExitTrigger()
        {
            DialogResult result = MessageBox.Show("Youre about to Exit.\nAre you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Environment.Exit(0);
            else
                return;

        }

        public static bool loginTrigger(string username, string password)
        {
            /*
                > Login w/ DB check 
                > If Success > return login Open Main Form close hide the login form
                > show incorrect usern/pw messagebox
             */
            string initiate = "server=localhost;user id=user;password=123456789;database=basemanage";
            string selector = "SELECT * FROM basemanage.credential WHERE username=@username AND password=@password";
            using (MySqlConnection connection = new MySqlConnection(initiate))
            {
                connection.Open();

                try
                {
                    // Logic for login process in Database

                    using (MySqlCommand command = new MySqlCommand(selector, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        using (MySqlDataReader checker = command.ExecuteReader())
                        {
                            if (checker.HasRows)
                            {
                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else
                            {
                                // Invalid credential
                                DialogResult a = MessageBox.Show("Username or Password Incorrect", "Login Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                if (a == DialogResult.Cancel)
                                {
                                    Environment.Exit(0);
                                }
                                return false;
                            }

                        }

                    }


                }
                catch (MySqlException sqlEx) // connection, table
                {
                    MessageBox.Show("Dataabse connection error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex) // alll errors
                {
                    MessageBox.Show("An error occurred during login: " + ex.Message, "Login Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }

        }
    }
}
