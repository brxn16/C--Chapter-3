using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsIneractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double Test1;
            double Test2;
            double Test3;
            double Test4;
            double Test5;
            double average;

            Test1 = Convert.ToInt32(txtTest1.Text);
            Test2 = Convert.ToInt32(txtTest2.Text);
            Test3 = Convert.ToInt32(txtTest3.Text);
            Test4 = Convert.ToInt32(txtTest4.Text);
            Test5 = Convert.ToInt32(txtTest5.Text);

            average = (Test1 + Test2 + Test3 + Test4 + Test5) / 5;

            lblAverage.Text = "The average of all the tests is " + average;

        }
    }
}
