using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Management_Nov1
{
    public static class allControl
    {
        // re-use control
        public static void ExitTrigger()
        {
            DialogResult result = MessageBox.Show("Youre about to Exit.\nAre you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Environment.Exit(0);
            else return;

        }

        public static void MinimizeTrigger(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
