﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double salary;
            double raise;
            salary = Convert.ToInt32(txtSalary.Text);

            raise = (0.04 * salary) + salary;
            lblRaise.Text = "The final salary after raise is " + raise.ToString("C");

        }
    }
}
