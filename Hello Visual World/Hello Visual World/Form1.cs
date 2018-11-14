using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Visual_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            lblHello.Visible = true;
            lblHello.Text = "Hello, Visual World!";
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Goodbye";
        }

        private void btnClickLast_Click(object sender, EventArgs e)
        {
            lblHello.Visible = false;
        }
    }
}
