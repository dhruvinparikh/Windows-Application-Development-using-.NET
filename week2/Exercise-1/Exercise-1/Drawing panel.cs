using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public partial class Drawing_panel : Form
    {
        SolidBrush solidbrush;
        public Drawing_panel()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Drawing_panel_Load(object sender, EventArgs e)
        {
            rb_medium.Checked = true;
        }

        private void DrawEvent_Mouse_Move(object sender, MouseEventArgs e)
        {
            
                if (status)
            {
                using (Graphics gobj = panel1.CreateGraphics())
                {
                    gobj.FillEllipse(solidbrush, e.X, e.Y, x, y);

                }
            }
        }

        private void DrawEvent_Mouse_Click(object sender, MouseEventArgs e)
        {
            
        }
        bool status = false;
        private void DrawEvent_Mouse_Up(object sender, MouseEventArgs e)
        {
            status = false;
        }

        private void DrawEvent_Mouse_Down(object sender, MouseEventArgs e)
        {
            status = true;
            if (status)
            {
                using (Graphics gobj = panel1.CreateGraphics())
                {
                    gobj.FillEllipse(solidbrush, e.X, e.Y, x, y);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Color_Change(object sender, EventArgs e)
        {
            if(sender == rb_black)
            {
                solidbrush = new SolidBrush(Color.Black);
            }
            else if(sender == rb_blue)
            {
                solidbrush = new SolidBrush(Color.Blue);
            }
            else if(sender == rb_green)
            {
                solidbrush = new SolidBrush(Color.Green);
            }
            else if(sender == rb_red)
            {
                solidbrush = new SolidBrush(Color.Red);
            }
        }
        int x, y;
        private void Size_Change(object sender, EventArgs e)
        {
            if(sender == rb_small)
            {
                x = 3;
                y = 3;
            }
            else if(sender == rb_medium)
            {
                x = 6;
                y = 6;
            }
            else if(sender == rb_large)
            {
                x = 10;
                y = 10;
            }
        }
    }
}
