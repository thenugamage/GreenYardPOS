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
    public partial class AddNewStock : UserControl
    {
        public AddNewStock()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //navigate to Stock.cs UserControl
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                mainPanel.Controls.Clear();
                Stock stockControl = new Stock();
                stockControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(stockControl);
            }
        }
    }
}
