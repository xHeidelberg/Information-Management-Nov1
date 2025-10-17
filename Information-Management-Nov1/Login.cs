using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Information_Management_Nov1
{
    public partial class loginForm : Form
    {
        
        public loginForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // confirmation
            loginManage.ExitTrigger();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // checkbox to show/hide password characters terniary check
            passInput.PasswordChar = checkBox1.Checked ? '\0' : '●';
            

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userInput.Text;
            string password = passInput.Text;
            bool whatwhatwhaaat = loginManage.loginTrigger(username, password);

            if (whatwhatwhaaat)
            {
                mainForm landing = new mainForm();
                landing.Show();
                this.Hide();
            }

        }
    }
}
