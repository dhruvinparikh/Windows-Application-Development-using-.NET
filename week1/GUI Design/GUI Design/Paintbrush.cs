using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Design
{
    public partial class Paintbrush : Form
    {
        //status : information whether to draw or not
        bool status;
        public Paintbrush()
        {
            InitializeComponent();
        }

        private void Paint_Mouse_Up(object sender, MouseEventArgs e)
        {
            status = false;
        }

        private void Paint_Mouse_Move(object sender, MouseEventArgs e)
        {
            if (status)
            {
                using(Graphics gobj = CreateGraphics())
                {
                    gobj.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 10, 10);
                }
            }
        }

        private void Paint_Mouse_Down(object sender, MouseEventArgs e)
        {
            status = true;
            using (Graphics gobj = CreateGraphics())
            {
                gobj.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 10, 10);
            }
        }

        private void Paintbrush_Load(object sender, EventArgs e)
        {

        }
    }
}
