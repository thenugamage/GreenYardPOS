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
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //navigate to AddNewStock.cs UserControl
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                mainPanel.Controls.Clear();
                AddNewStock addNewStockControl = new AddNewStock();
                addNewStockControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(addNewStockControl);
            }
        }
    }
}
