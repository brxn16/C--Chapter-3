using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            int year1Cont;
            int year2Cont;
            double rev1;
            double rev2;
            int moreCont;

            year1Cont = Convert.ToInt32(txtYear1.Text);
            year2Cont = Convert.ToInt32(txtYear2.Text);

            rev1 = year1Cont * 25;
            rev2 = year2Cont * 25;

            lblRev1.Text = "" + rev1.ToString("C");
            lblRev2.Text = "" + rev2.ToString("C");
            
            if(year1Cont > year2Cont)
            {
                lblMoreCont.Text = "Last year had more contestants";
            }
            if(year2Cont > year1Cont)
            {
                lblMoreCont.Text = "This year had more contestants";
            }
        }
    }
}
