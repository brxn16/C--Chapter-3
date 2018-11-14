using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double Miles;
            double Days;
            double Total;
            Miles = Convert.ToInt32(txtMiles.Text);
            Days = Convert.ToInt32(txtDays.Text);

            Total = (Miles * 0.25) + (Days * 20);
            lblTotal.Text = "Your total is " + Total.ToString("C");
        }
    }
}
