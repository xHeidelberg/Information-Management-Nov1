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
        public mainForm()
        {
            InitializeComponent();
        }

        private void linkedLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            allControl.ExitTrigger();
        }

        private void linkedMinimize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            allControl.MinimizeTrigger(this);
        }
    }
}
