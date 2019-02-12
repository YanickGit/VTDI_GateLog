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
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            var UserName = TB_UserName.Text;
            var Password = TB_Password.Text;

            if (UserName != "username" || Password != "password")
            {
                MessageBox.Show("Invalid User Name or Password");
            }
            else
            {

                //MessageBox.Show("Welcome");
                this.Hide();
                _02.GateLogs.FRM_GateInOut InOut = new _02.GateLogs.FRM_GateInOut(); //this is the change, code for redirect
                InOut.ShowDialog();
            }
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_UserName.Text = "";
            TB_Password.Text = "";
        }
    }
}
