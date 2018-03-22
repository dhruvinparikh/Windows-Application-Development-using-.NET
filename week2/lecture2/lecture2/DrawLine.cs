using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture2
{
    public partial class DrawLine : Form
    {
        bool status;
        public DrawLine()
        {
            InitializeComponent();
        }

        private void drawLine_Mouse_Down(object sender, MouseEventArgs e)
        {
            status = true;
        }

        private void drawLine_Mouse_Up(object sender, MouseEventArgs e)
        {
            status = false;
        }

        private void drawLine_Mouse_Click(object sender, MouseEventArgs e)
        {
            if (status)
            {
                Random rand = new Random();
                int red = rand.Next(0, 255);
                int green = rand.Next(0, 255);
                int blue = rand.Next(0, 255);
                Color c = Color.FromArgb(red, green, blue);
                //Color c = Color.FromArgb(new Random().Next(0, 255), new Random().Next(0, 255), new Random().Next(0, 255));
                using (Graphics gobj = CreateGraphics())
                {
                    gobj.DrawEllipse(new Pen(c), e.X, e.Y, 0,0);
                    gobj.DrawEllipse(new Pen(c), e.X, e.Y, 10, 10);
                    gobj.DrawLine(new Pen(c), 0, 0, e.X, e.Y);
                }
            }
        }

        private void DrawLine_Load(object sender, EventArgs e)
        {

        }
    }
}
