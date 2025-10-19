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
            allControl.MinimizeTrigger(this);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            allControl.ExitTrigger();
        }

    }
}
