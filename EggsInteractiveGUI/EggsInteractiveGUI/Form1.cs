using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEggs_Click(object sender, EventArgs e)
        {
            int Chicken1;
            int Chicken2;
            int Chicken3;
            int Chicken4;
            int Chicken5;
            int eggs;
            int eggsRemaining;
            int dozen;

            Chicken1 = Convert.ToInt32(txtChicken1.Text);
            Chicken2 = Convert.ToInt32(txtChicken2.Text);
            Chicken3 = Convert.ToInt32(txtChicken3.Text);
            Chicken4 = Convert.ToInt32(txtChicken4.Text);
            Chicken5 = Convert.ToInt32(txtChicken5.Text);

            eggs = Chicken1 + Chicken2 + Chicken3 + Chicken4 + Chicken5;
            eggsRemaining = eggs % 12;
            dozen = eggs / 12;

            lblDozen.Text = "There is a total of " + eggs + " eggs which converts to " + dozen + " dozen and " + eggsRemaining;

        }
    }
}
