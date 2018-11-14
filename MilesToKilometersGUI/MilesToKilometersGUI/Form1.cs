using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double miles;
            double kilo;
            miles = Convert.ToInt32(txtMile.Text);

            kilo = 1.6 * miles;

            lblKilo.Text = "" + kilo;
        }
    }
}
