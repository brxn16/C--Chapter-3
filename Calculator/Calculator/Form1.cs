using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txtFirstNumber.Text);
            num2 = Convert.ToInt32(txtSecondNumber.Text);

            total = num1 + num2;
            lblResult.Text = "The sum is " + total;
            lblSign.Text = "+";
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txtFirstNumber.Text);
            num2 = Convert.ToInt32(txtSecondNumber.Text);

            total = num1 - num2;
            lblResult.Text = "The difference is " + total;
            lblSign.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txtFirstNumber.Text);
            num2 = Convert.ToInt32(txtSecondNumber.Text);

            total = num1 * num2;
            lblResult.Text = "The product is " + total;
            lblSign.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txtFirstNumber.Text);
            num2 = Convert.ToInt32(txtSecondNumber.Text);

            total = num1 / num2;
            lblResult.Text = "The quotient is " + total;
            lblSign.Text = "/";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txtFirstNumber.Text);
            num2 = Convert.ToInt32(txtSecondNumber.Text);

            total = num1 % num2;
            lblResult.Text = "The modulus is " + total;
            lblSign.Text = "%";
        }
    }
}
