using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_The_Day_Budgeting_App
{
    public partial class Form1 : Form
    {
        public static int SetValueForText1;
        public static int SetValueForText2;
        public static int SetValueForText3;
        public static int SetValueForText4;
        public static int NecessarySavings; //houses accountbalance - account goal
        public static int CanSpendDaily;
        
        public Form1()
        {
            InitializeComponent();
                      
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           //NECESSARY SAVINGS//
           SetValueForText1 = Convert.ToInt32(txtAccountBalance.Text);//sets global varibles to user data in txtboxes, converts to int for calculations
           SetValueForText2 = Convert.ToInt32(txtAccountGoal.Text);
           NecessarySavings = SetValueForText2 - SetValueForText1; //the calculation value set to testing

           //CAN SPEND//
           SetValueForText3 = Convert.ToInt32(txtPaycheck.Text); //converts user text to int for calculations
           SetValueForText4 = Convert.ToInt32(txtMonthlyPaymentNumber.Text);
           int MonthlyIncome = SetValueForText3 * SetValueForText4; //the calculation for monthly income
           int YearlyIncome = MonthlyIncome * 12; //sets the yearly income
           int CanSpendYearly = YearlyIncome - NecessarySavings; //what you can spend yearly
           int CanSpendMonthly = CanSpendYearly / 12; //what you can spend monthly
           CanSpendDaily = CanSpendMonthly / 30; //what you can spend daily
            
            
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to 'To The Day Budgeter'! We'll ask you a few questions to get started.");
        }
    }
}
