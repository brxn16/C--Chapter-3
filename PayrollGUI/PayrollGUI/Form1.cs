using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double hourly;
            double hours;
            double gross;
            double fedTax;
            double stateTax;
            double net;
            double taxes;
            hourly = Convert.ToDouble(txtHourly.Text);
            hours = Convert.ToDouble(txtHoursWorked.Text);

            gross = hourly * hours;
            fedTax = gross * .15;
            stateTax = gross * .05;
            taxes = fedTax + stateTax;
            net = gross - taxes;

            lblGross.Text = "" + gross.ToString("C");
            lblFedTax.Text = "" + fedTax.ToString("C");
            lblStateTax.Text = "" + stateTax.ToString("C");
            lblNet.Text = "" + net.ToString("C");

        }
    }
}
