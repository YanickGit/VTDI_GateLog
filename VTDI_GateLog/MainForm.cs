using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTDI_GateLog
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Login was clicked!!");
            FRM_Login LogIn = new FRM_Login(); //Declaring an object for the Login Form
            LogIn.MdiParent = this; // Looking the child forn to the parent
            LogIn.Show(); // Used to display the form

        }

        private void userManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management was clicked!!");
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduling was clicked!!");
        }

        private void alertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alerts was clicked!!");
        }

        private void gateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate List was clicked!!");
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate In and Out was clicked!!");
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guest List was clicked!!");
        }

        private void gateInOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management was clicked!!");
        }
    }
}
