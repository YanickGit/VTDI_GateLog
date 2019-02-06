namespace VTDI_GateLog
{
    partial class FRM_Login
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
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LBL_UserLogin = new System.Windows.Forms.Label();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.BTN_ForgetPass = new System.Windows.Forms.Button();
            this.LBL_UserName = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_UserName
            // 
            this.TB_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UserName.Location = new System.Drawing.Point(3, 3);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(239, 26);
            this.TB_UserName.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TB_UserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TB_Password, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(114, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5625F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 64);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(3, 34);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(239, 26);
            this.TB_Password.TabIndex = 2;
            // 
            // LBL_UserLogin
            // 
            this.LBL_UserLogin.AutoSize = true;
            this.LBL_UserLogin.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserLogin.Location = new System.Drawing.Point(101, 9);
            this.LBL_UserLogin.Name = "LBL_UserLogin";
            this.LBL_UserLogin.Size = new System.Drawing.Size(176, 43);
            this.LBL_UserLogin.TabIndex = 2;
            this.LBL_UserLogin.Text = "USER LOGIN";
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(15, 136);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Submit.TabIndex = 3;
            this.BTN_Submit.Text = "SUBMIT";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(96, 136);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(75, 23);
            this.BTN_Clear.TabIndex = 4;
            this.BTN_Clear.Text = "CLEAR";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            // 
            // BTN_ForgetPass
            // 
            this.BTN_ForgetPass.Location = new System.Drawing.Point(232, 136);
            this.BTN_ForgetPass.Name = "BTN_ForgetPass";
            this.BTN_ForgetPass.Size = new System.Drawing.Size(127, 23);
            this.BTN_ForgetPass.TabIndex = 5;
            this.BTN_ForgetPass.Text = "FORGET PASSWORD";
            this.BTN_ForgetPass.UseVisualStyleBackColor = true;
            // 
            // LBL_UserName
            // 
            this.LBL_UserName.AutoSize = true;
            this.LBL_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserName.Location = new System.Drawing.Point(13, 61);
            this.LBL_UserName.Name = "LBL_UserName";
            this.LBL_UserName.Size = new System.Drawing.Size(98, 20);
            this.LBL_UserName.TabIndex = 6;
            this.LBL_UserName.Text = "User Name";
            this.LBL_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Password.Location = new System.Drawing.Point(22, 89);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(86, 20);
            this.LBL_Password.TabIndex = 7;
            this.LBL_Password.Text = "Password";
            this.LBL_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 169);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.LBL_UserName);
            this.Controls.Add(this.BTN_ForgetPass);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.LBL_UserLogin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FRM_Login";
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LBL_UserLogin;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button BTN_ForgetPass;
        private System.Windows.Forms.Label LBL_UserName;
        private System.Windows.Forms.Label LBL_Password;
    }
}