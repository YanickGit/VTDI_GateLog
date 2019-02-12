using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTDI_GateLog._02.GateLogs
{
    public partial class FRM_GateInOut : Form
    {
        public FRM_GateInOut()
        {
            InitializeComponent();
        }

        private void BTN_SubmitInOut_Click(object sender, EventArgs e)
        {
            var FName = TB_FName.Text;
            var LName = TB_LName.Text;
            var VType = TB_VType.Text;
            var PlateNum = TB_PlateNum.Text;
            var Purpose = TB_Purpose.Text;
            var Time_In = TIME_In.Text;
            var Time_Out = TIME_Out.Text;
            var Date_In = DATE_In.Text;
            var Date_Out = DATE_Out.Text;
            var Declare = LST_Delcare.Text;

            MessageBox.Show(
          "Summary of Details: \n\n"+
          $"Your name is {FName} {LName}\n"+
          $"Your vehicle type and plate number is {VType}, {PlateNum}\n"+
          $"The purpose for your visit is {Purpose}\n"+
          $"Item declared: {Declare}\n" +
          $"Time in and out: {Time_In}, {Time_Out}\n" +
          $"Date in and out: {Date_In}, {Date_Out}");
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_FName.Text = "";
            TB_LName.Text = "";
            TB_VType.Text = "";
            TB_PlateNum.Text = "";
            TB_Purpose.Text = "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
