using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_MaulanaM.A
{
    public partial class Main : Form
    {
        Second Second_Form = new Second();
        public TextBox txttname;
        public TextBox txttfav;
        public Main()
        {
            InitializeComponent();
            txttname = txtname;
            txttfav = txtartist;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            Second_Form.mainn = this;
            Second_Form.Show();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtartist.Text == "")
            {
                MessageBox.Show("Please enter the correct input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Second_Form.a("Hi, my name is " + txttname.Text + " and my favorite artist is " + txttfav.Text);
            }
            
        }

        private void chcktrue_CheckedChanged(object sender, EventArgs e)
        {
            if (chcktrue.Checked)
            {
                btnsubmit.Enabled = true;
            }
            else
            {
                btnsubmit.Enabled = false;
            }
        }
    }
}
