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
    /*
     * Exit Dialog *
     * Show/Hide Password Characters *
     * Background Image *
     * requuest login credentials
     * forgot password hyperlink
     */
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
            // checkbox to show/hide password characters
            passInput.PasswordChar = checkBox1.Checked ? '\0' : '●';
        }
    }
}
