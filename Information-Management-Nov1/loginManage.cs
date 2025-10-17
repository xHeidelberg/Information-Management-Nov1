using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Management_Nov1
{
    public static class loginManage
    {
        //Exit Trgigger
        public static void ExitTrigger()
        {
            DialogResult result = MessageBox.Show("Youre about to Exit.\nAre you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Environment.Exit(0);
            else
                return;
        }

        //Login Trigger
        public static void loginTrigger()
        {
            /*
                > Logic Login w/ DB
                > If Success -> Open Main Form
                > show label (err1 = Username or Password Incorrect, err2 = * , err3 = *)
             */

        }

        public static void forgotPasswordTrigger()
        {
            /*
                > Logic Forgot Password w/ DB
                > 
             */
        }


    }
}
