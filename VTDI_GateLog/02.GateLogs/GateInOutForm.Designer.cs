namespace VTDI_GateLog._02.GateLogs
{
    partial class FRM_GateInOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.DATE_In = new System.Windows.Forms.DateTimePicker();
            this.DATE_Out = new System.Windows.Forms.DateTimePicker();
            this.TB_Purpose = new System.Windows.Forms.TextBox();
            this.TB_PlateNum = new System.Windows.Forms.TextBox();
            this.TB_VType = new System.Windows.Forms.TextBox();
            this.LBL_DateInOut = new System.Windows.Forms.Label();
            this.LBL_PlateNumber = new System.Windows.Forms.Label();
            this.LBL_LName = new System.Windows.Forms.Label();
            this.TB_FName = new System.Windows.Forms.TextBox();
            this.LBL_Purpose = new System.Windows.Forms.Label();
            this.LBL_TimeInOut = new System.Windows.Forms.Label();
            this.LBL_FName = new System.Windows.Forms.Label();
            this.LBL_VType = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TIME_In = new System.Windows.Forms.DateTimePicker();
            this.TIME_Out = new System.Windows.Forms.DateTimePicker();
            this.LBL_Declare = new System.Windows.Forms.Label();
            this.TB_LName = new System.Windows.Forms.TextBox();
            this.LBL_UserLogin = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.BTN_UpdateInOut = new System.Windows.Forms.Button();
            this.BTN_SubmitInOut = new System.Windows.Forms.Button();
            this.LST_Delcare = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.85075F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.29851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.14925F));
            this.tableLayoutPanel1.Controls.Add(this.LST_Delcare, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.TB_Purpose, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TB_PlateNum, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.TB_VType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DateInOut, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_PlateNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_LName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TB_FName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Purpose, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBL_TimeInOut, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_FName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_VType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Declare, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TB_LName, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.DATE_In);
            this.flowLayoutPanel2.Controls.Add(this.DATE_Out);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(470, 64);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(182, 24);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // DATE_In
            // 
            this.DATE_In.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DATE_In.Location = new System.Drawing.Point(3, 3);
            this.DATE_In.Name = "DATE_In";
            this.DATE_In.Size = new System.Drawing.Size(82, 20);
            this.DATE_In.TabIndex = 7;
            // 
            // DATE_Out
            // 
            this.DATE_Out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DATE_Out.Location = new System.Drawing.Point(91, 3);
            this.DATE_Out.Name = "DATE_Out";
            this.DATE_Out.Size = new System.Drawing.Size(82, 20);
            this.DATE_Out.TabIndex = 8;
            // 
            // TB_Purpose
            // 
            this.TB_Purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Purpose.Location = new System.Drawing.Point(136, 94);
            this.TB_Purpose.MaxLength = 60;
            this.TB_Purpose.Multiline = true;
            this.TB_Purpose.Name = "TB_Purpose";
            this.TB_Purpose.Size = new System.Drawing.Size(182, 62);
            this.TB_Purpose.TabIndex = 9;
            // 
            // TB_PlateNum
            // 
            this.TB_PlateNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PlateNum.Location = new System.Drawing.Point(470, 35);
            this.TB_PlateNum.MaxLength = 30;
            this.TB_PlateNum.Name = "TB_PlateNum";
            this.TB_PlateNum.Size = new System.Drawing.Size(182, 26);
            this.TB_PlateNum.TabIndex = 4;
            // 
            // TB_VType
            // 
            this.TB_VType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_VType.Location = new System.Drawing.Point(136, 35);
            this.TB_VType.MaxLength = 30;
            this.TB_VType.Name = "TB_VType";
            this.TB_VType.Size = new System.Drawing.Size(182, 26);
            this.TB_VType.TabIndex = 3;
            // 
            // LBL_DateInOut
            // 
            this.LBL_DateInOut.AutoSize = true;
            this.LBL_DateInOut.Font = new System.Drawing.Font("Raavi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DateInOut.Location = new System.Drawing.Point(335, 61);
            this.LBL_DateInOut.Name = "LBL_DateInOut";
            this.LBL_DateInOut.Size = new System.Drawing.Size(125, 27);
            this.LBL_DateInOut.TabIndex = 7;
            this.LBL_DateInOut.Text = "Date In and Out: ";
            // 
            // LBL_PlateNumber
            // 
            this.LBL_PlateNumber.AutoSize = true;
            this.LBL_PlateNumber.Font = new System.Drawing.Font("Raavi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PlateNumber.Location = new System.Drawing.Point(335, 32);
            this.LBL_PlateNumber.Name = "LBL_PlateNumber";
            this.LBL_PlateNumber.Size = new System.Drawing.Size(110, 27);
            this.LBL_PlateNumber.TabIndex = 4;
            this.LBL_PlateNumber.Text = "Plate Number: ";
            // 
            // LBL_LName
            // 
            this.LBL_LName.AutoSize = true;
            this.LBL_LName.Font = new System.Drawing.Font("Raavi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_LName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBL_LName.Location = new System.Drawing.Point(335, 0);
            this.LBL_LName.Name = "LBL_LName";
            this.LBL_LName.Size = new System.Drawing.Size(91, 27);
            this.LBL_LName.TabIndex = 3;
            this.LBL_LName.Text = "Last Name: ";
            // 
            // TB_FName
            // 
            this.TB_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FName.Location = new System.Drawing.Point(136, 3);
            this.TB_FName.MaxLength = 30;
            this.TB_FName.Name = "TB_FName";
            this.TB_FName.Size = new System.Drawing.Size(182, 26);
            this.TB_FName.TabIndex = 1;
            // 
            // LBL_Purpose
            // 
            this.LBL_Purpose.AutoSize = true;
            this.LBL_Purpose.Font = new System.Drawing.Font("Raavi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Purpose.Location = new System.Drawing.Point(3, 91);
            this.LBL_Purpose.Name = "LBL_Purpose";
            this.LBL_Purpose.Size = new System.Drawing.Size(75, 27);
            this.LBL_Purpose.TabIndex = 5;
            this.LBL_Purpose.Text = "Purpose: ";
            // 
            // LBL_TimeInOut
            // 
            this.LBL_TimeInOut.AutoSize = true;
            this.LBL_TimeInOut.Font = new System.Drawing.Font("Raavi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeInOut.Location = new System.Drawing.Point(3, 61);
            this.LBL_TimeInOut.Name = "LBL_TimeInOut";
            this.LBL_TimeInOut.Size = new System.Drawing.Size(127, 27);
            this.LBL_TimeInOut.TabIndex = 4;
            this.LBL_TimeInOut.Text = "Time In and Out: ";
            // 
            // LBL_FName
            // 
            this.LBL_FName.AutoSize = true;
            this.LBL_FName.Font = new System.Drawing.Font("Raavi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_FName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBL_FName.Location = new System.Drawing.Point(3, 0);
            this.LBL_FName.Name = "LBL_FName";
            this.LBL_FName.Size = new System.Drawing.Size(92, 27);
            this.LBL_FName.TabIndex = 2;
            this.LBL_FName.Text = "First Name: ";
            // 
            // LBL_VType
            // 
            this.LBL_VType.AutoSize = true;
            this.LBL_VType.Font = new System.Drawing.Font("Raavi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_VType.Location = new System.Drawing.Point(3, 32);
            this.LBL_VType.Name = "LBL_VType";
            this.LBL_VType.Size = new System.Drawing.Size(104, 27);
            this.LBL_VType.TabIndex = 3;
            this.LBL_VType.Text = "Vehicle Type: ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TIME_In);
            this.flowLayoutPanel1.Controls.Add(this.TIME_Out);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(136, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 24);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // TIME_In
            // 
            this.TIME_In.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TIME_In.Location = new System.Drawing.Point(3, 3);
            this.TIME_In.Name = "TIME_In";
            this.TIME_In.Size = new System.Drawing.Size(82, 20);
            this.TIME_In.TabIndex = 5;
            // 
            // TIME_Out
            // 
            this.TIME_Out.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TIME_Out.Location = new System.Drawing.Point(91, 3);
            this.TIME_Out.Name = "TIME_Out";
            this.TIME_Out.Size = new System.Drawing.Size(82, 20);
            this.TIME_Out.TabIndex = 6;
            // 
            // LBL_Declare
            // 
            this.LBL_Declare.AutoSize = true;
            this.LBL_Declare.Font = new System.Drawing.Font("Raavi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Declare.Location = new System.Drawing.Point(335, 91);
            this.LBL_Declare.Name = "LBL_Declare";
            this.LBL_Declare.Size = new System.Drawing.Size(127, 27);
            this.LBL_Declare.TabIndex = 4;
            this.LBL_Declare.Text = "Items To Declare: ";
            // 
            // TB_LName
            // 
            this.TB_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LName.Location = new System.Drawing.Point(470, 3);
            this.TB_LName.MaxLength = 30;
            this.TB_LName.Name = "TB_LName";
            this.TB_LName.Size = new System.Drawing.Size(182, 26);
            this.TB_LName.TabIndex = 2;
            // 
            // LBL_UserLogin
            // 
            this.LBL_UserLogin.AutoSize = true;
            this.LBL_UserLogin.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserLogin.Location = new System.Drawing.Point(234, 9);
            this.LBL_UserLogin.Name = "LBL_UserLogin";
            this.LBL_UserLogin.Size = new System.Drawing.Size(168, 43);
            this.LBL_UserLogin.TabIndex = 3;
            this.LBL_UserLogin.Text = "Gate In/Out";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(397, 238);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(75, 23);
            this.BTN_Clear.TabIndex = 13;
            this.BTN_Clear.Text = "CLEAR";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // BTN_UpdateInOut
            // 
            this.BTN_UpdateInOut.Location = new System.Drawing.Point(316, 238);
            this.BTN_UpdateInOut.Name = "BTN_UpdateInOut";
            this.BTN_UpdateInOut.Size = new System.Drawing.Size(75, 23);
            this.BTN_UpdateInOut.TabIndex = 12;
            this.BTN_UpdateInOut.Text = "UPDATE";
            this.BTN_UpdateInOut.UseVisualStyleBackColor = true;
            // 
            // BTN_SubmitInOut
            // 
            this.BTN_SubmitInOut.Location = new System.Drawing.Point(235, 238);
            this.BTN_SubmitInOut.Name = "BTN_SubmitInOut";
            this.BTN_SubmitInOut.Size = new System.Drawing.Size(75, 23);
            this.BTN_SubmitInOut.TabIndex = 11;
            this.BTN_SubmitInOut.Text = "SUBMIT";
            this.BTN_SubmitInOut.UseVisualStyleBackColor = true;
            this.BTN_SubmitInOut.Click += new System.EventHandler(this.BTN_SubmitInOut_Click);
            // 
            // LST_Delcare
            // 
            this.LST_Delcare.FormattingEnabled = true;
            this.LST_Delcare.Items.AddRange(new object[] {
            "Laptop",
            "Projector",
            "Gun",
            "Television"});
            this.LST_Delcare.Location = new System.Drawing.Point(470, 94);
            this.LST_Delcare.Name = "LST_Delcare";
            this.LST_Delcare.Size = new System.Drawing.Size(173, 64);
            this.LST_Delcare.TabIndex = 14;
            // 
            // FRM_GateInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 271);
            this.Controls.Add(this.BTN_SubmitInOut);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.BTN_UpdateInOut);
            this.Controls.Add(this.LBL_UserLogin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FRM_GateInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gate In\\Out";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TB_FName;
        private System.Windows.Forms.Label LBL_FName;
        private System.Windows.Forms.Label LBL_Purpose;
        private System.Windows.Forms.Label LBL_TimeInOut;
        private System.Windows.Forms.Label LBL_VType;
        private System.Windows.Forms.Label LBL_Declare;
        private System.Windows.Forms.TextBox TB_LName;
        private System.Windows.Forms.Label LBL_PlateNumber;
        private System.Windows.Forms.Label LBL_LName;
        private System.Windows.Forms.Label LBL_UserLogin;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button BTN_UpdateInOut;
        private System.Windows.Forms.Label LBL_DateInOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TB_Purpose;
        private System.Windows.Forms.TextBox TB_PlateNum;
        private System.Windows.Forms.TextBox TB_VType;
        private System.Windows.Forms.DateTimePicker TIME_In;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DateTimePicker DATE_In;
        private System.Windows.Forms.DateTimePicker DATE_Out;
        private System.Windows.Forms.DateTimePicker TIME_Out;
        private System.Windows.Forms.Button BTN_SubmitInOut;
        private System.Windows.Forms.CheckedListBox LST_Delcare;
    }
}