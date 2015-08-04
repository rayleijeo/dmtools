using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Text;
using System.Windows.Forms;

namespace DmTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdobpersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobpersonal.Checked) {
                gpbcompany.Visible = false;
                gpbpersonal.Visible = true;
            }
        }

        private void rdobcompany_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobcompany.Checked)
            {
                gpbcompany.Visible = true;
                gpbpersonal.Visible = false;
            }
        }
    }
}
