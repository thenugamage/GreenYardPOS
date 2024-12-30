using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testPOS.controls
{
    public partial class UserControlcostomers : UserControl
    {
        public UserControlcostomers()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlcostomers_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
        }


        public class RoundedButton : Button
        {
            public int BorderRadius { get; set; } = 20;

            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);

                GraphicsPath path = new GraphicsPath();
                path.AddArc(new Rectangle(0, 0, BorderRadius, BorderRadius), 180, 90);
                path.AddArc(new Rectangle(Width - BorderRadius, 0, BorderRadius, BorderRadius), -90, 90);
                path.AddArc(new Rectangle(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius), 0, 90);
                path.AddArc(new Rectangle(0, Height - BorderRadius, BorderRadius, BorderRadius), 90, 90);
                path.CloseAllFigures();

                this.Region = new Region(path);

                using (Pen pen = new Pen(this.ForeColor, 1))
                {
                    pevent.Graphics.DrawPath(pen, path);
                }
            }
        }

    }
}
