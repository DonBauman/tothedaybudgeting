namespace To_The_Day_Budgeting_App
{
    partial class Form1
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
            this.txtTimeScale = new System.Windows.Forms.TextBox();
            this.lblTimeScale = new System.Windows.Forms.Label();
            this.lblCurrentAccountBalance = new System.Windows.Forms.Label();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.txtAccountGoal = new System.Windows.Forms.TextBox();
            this.lblAccountGoal = new System.Windows.Forms.Label();
            this.lblMonthlyPaymentNumber = new System.Windows.Forms.Label();
            this.lblMonthlyCheck = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMonthlyPaymentNumber = new System.Windows.Forms.TextBox();
            this.txtPaycheck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTimeScale
            // 
            this.txtTimeScale.Location = new System.Drawing.Point(62, 326);
            this.txtTimeScale.Name = "txtTimeScale";
            this.txtTimeScale.Size = new System.Drawing.Size(146, 20);
            this.txtTimeScale.TabIndex = 23;
            // 
            // lblTimeScale
            // 
            this.lblTimeScale.AutoSize = true;
            this.lblTimeScale.Location = new System.Drawing.Point(30, 292);
            this.lblTimeScale.Name = "lblTimeScale";
            this.lblTimeScale.Size = new System.Drawing.Size(215, 13);
            this.lblTimeScale.TabIndex = 22;
            this.lblTimeScale.Text = "How fast do you want to achieve your goal?";
            // 
            // lblCurrentAccountBalance
            // 
            this.lblCurrentAccountBalance.AutoSize = true;
            this.lblCurrentAccountBalance.Location = new System.Drawing.Point(42, 156);
            this.lblCurrentAccountBalance.Name = "lblCurrentAccountBalance";
            this.lblCurrentAccountBalance.Size = new System.Drawing.Size(191, 13);
            this.lblCurrentAccountBalance.TabIndex = 21;
            this.lblCurrentAccountBalance.Text = "What is your current account balance?";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(62, 182);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(146, 20);
            this.txtAccountBalance.TabIndex = 20;
            // 
            // txtAccountGoal
            // 
            this.txtAccountGoal.Location = new System.Drawing.Point(62, 248);
            this.txtAccountGoal.Name = "txtAccountGoal";
            this.txtAccountGoal.Size = new System.Drawing.Size(146, 20);
            this.txtAccountGoal.TabIndex = 19;
            // 
            // lblAccountGoal
            // 
            this.lblAccountGoal.AutoSize = true;
            this.lblAccountGoal.Location = new System.Drawing.Point(67, 227);
            this.lblAccountGoal.Name = "lblAccountGoal";
            this.lblAccountGoal.Size = new System.Drawing.Size(140, 13);
            this.lblAccountGoal.TabIndex = 18;
            this.lblAccountGoal.Text = "What is your account goal? ";
            // 
            // lblMonthlyPaymentNumber
            // 
            this.lblMonthlyPaymentNumber.AutoSize = true;
            this.lblMonthlyPaymentNumber.Location = new System.Drawing.Point(29, 81);
            this.lblMonthlyPaymentNumber.Name = "lblMonthlyPaymentNumber";
            this.lblMonthlyPaymentNumber.Size = new System.Drawing.Size(216, 13);
            this.lblMonthlyPaymentNumber.TabIndex = 16;
            this.lblMonthlyPaymentNumber.Text = "How many times do you get paid per month?";
            // 
            // lblMonthlyCheck
            // 
            this.lblMonthlyCheck.AutoSize = true;
            this.lblMonthlyCheck.Location = new System.Drawing.Point(26, 19);
            this.lblMonthlyCheck.Name = "lblMonthlyCheck";
            this.lblMonthlyCheck.Size = new System.Drawing.Size(223, 13);
            this.lblMonthlyCheck.TabIndex = 17;
            this.lblMonthlyCheck.Text = "How much (on average) are your paychecks?";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(100, 366);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMonthlyPaymentNumber
            // 
            this.txtMonthlyPaymentNumber.Location = new System.Drawing.Point(61, 105);
            this.txtMonthlyPaymentNumber.Name = "txtMonthlyPaymentNumber";
            this.txtMonthlyPaymentNumber.Size = new System.Drawing.Size(148, 20);
            this.txtMonthlyPaymentNumber.TabIndex = 13;
            // 
            // txtPaycheck
            // 
            this.txtPaycheck.Location = new System.Drawing.Point(61, 41);
            this.txtPaycheck.Name = "txtPaycheck";
            this.txtPaycheck.Size = new System.Drawing.Size(148, 20);
            this.txtPaycheck.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 401);
            this.Controls.Add(this.txtTimeScale);
            this.Controls.Add(this.lblTimeScale);
            this.Controls.Add(this.lblCurrentAccountBalance);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.txtAccountGoal);
            this.Controls.Add(this.lblAccountGoal);
            this.Controls.Add(this.lblMonthlyPaymentNumber);
            this.Controls.Add(this.lblMonthlyCheck);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMonthlyPaymentNumber);
            this.Controls.Add(this.txtPaycheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimeScale;
        private System.Windows.Forms.Label lblTimeScale;
        private System.Windows.Forms.Label lblCurrentAccountBalance;
        public System.Windows.Forms.TextBox txtAccountBalance;
        public System.Windows.Forms.TextBox txtAccountGoal;
        private System.Windows.Forms.Label lblAccountGoal;
        private System.Windows.Forms.Label lblMonthlyPaymentNumber;
        private System.Windows.Forms.Label lblMonthlyCheck;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMonthlyPaymentNumber;
        private System.Windows.Forms.TextBox txtPaycheck;
    }
}

