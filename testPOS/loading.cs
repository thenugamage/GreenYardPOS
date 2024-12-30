using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testPOS
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //after off this timer need to load login form
            timer1.Enabled = false;
            this.Hide();
            Login lg = new Login();
            lg.Show();

        }
    }
}
