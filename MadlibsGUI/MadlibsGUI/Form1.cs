using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadlibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSentence_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;

            c = Convert.ToInt32(txtInt3.Text);
            lblSentence.Text = "The " + txtColor.Text + " Dragon is the " + txtEst.Text + " Dragon of all. It has " + txtInt1.Text + "" + txtBody.Text + ", and a " + txtAnimal.Text + " shaped like a " + txtNoun.Text + ". It loves to eat " + txtPluralNoun.Text + ", although it will feast on nearly anything.";
        }
    }
}
