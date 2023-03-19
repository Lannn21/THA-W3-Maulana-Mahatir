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
    public partial class Second : Form
    {
        public Main mainn
        { get; set; }
        
        public Second()
        {
            InitializeComponent();
        }
        public void a(string x)
        {
            lblhi.Text = x;
        }
        private void btnmagic_Click(object sender, EventArgs e)
        {
            if (rbred.Checked == false && rbblue.Checked == false && rbgreen.Checked == false && rbpurple.Checked == false && rbyellow.Checked == false || rbtxtred.Checked == false && rbtxtblue.Checked == false && rbtxtgreen.Checked == false)
            {
                MessageBox.Show("Please choose the radio button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rbred.Checked == true)
                {
                    mainn.BackColor = Color.Red;
                }
                else if (rbblue.Checked == true)
                {
                    mainn.BackColor = Color.Blue;
                }
                else if (rbgreen.Checked == true)
                {
                    mainn.BackColor = Color.Green;
                }
                else if (rbpurple.Checked == true)
                {
                    mainn.BackColor = Color.Purple;
                }
                else if (rbyellow.Checked == true)
                {
                    mainn.BackColor = Color.Yellow;
                }
                if (rbtxtred.Checked == true)
                {
                    mainn.ForeColor = Color.Red;
                }
                else if (rbtxtblue.Checked == true)
                {
                    mainn.ForeColor = Color.Blue;
                }
                else if (rbtxtgreen.Checked == true)
                {
                    mainn.ForeColor = Color.Green;
                }
            }
        }

        private void chckterms_CheckedChanged(object sender, EventArgs e)
        {
            if (chckterms.Checked && chckpick.Checked)
            {
                btnmagic.Enabled = true;
            }
            else
            {
                btnmagic.Enabled = false;
            }
        }

        private void chckpick_CheckedChanged(object sender, EventArgs e)
        {
            if (chckterms.Checked && chckpick.Checked)
            {
                btnmagic.Enabled = true;
            }
            else
            {
                btnmagic.Enabled = false;
            }
        }
    }
}
