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
    public partial class phone_number : Form
    {
        public phone_number()
        {
            InitializeComponent();
        }

        private void txt_screen_TextChanged(object sender, EventArgs e)
        {

        }
        private void keyevent_down(object sender, KeyEventArgs e)
        {

        }

        private void phone_number_Load(object sender, EventArgs e)
        {
            txt_screen.Text = "";        }

        private void keyevent_press(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 8)
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
