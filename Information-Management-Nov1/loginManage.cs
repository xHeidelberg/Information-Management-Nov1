using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//SQL
using MySql.Data.MySqlClient;

namespace Information_Management_Nov1
{
    public static class loginManage
    {
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
                    using (MySqlCommand command = new MySqlCommand(selector, connection))
                    {
                        //parameter
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        // execute
                        using (MySqlDataReader checker = command.ExecuteReader()) // execute username=@username AND password=@password
                        {
                            // checking true or false
                            if (checker.HasRows) // 1 row found, 0 rows not found
                            {
                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else
                            {
                                // Invalid credential
                                MessageBox.Show("Username or Password Incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
