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
    public partial class Keyevents : Form
    {
        public Keyevents()
        {
            InitializeComponent();
        }

        private void Keyevents_Load(object sender, EventArgs e)
        {
           
        }

        private void key_info_down(object sender, KeyEventArgs e)
        {
            key_info.Text = "";
            key_info.Text = "Key Code " + e.KeyCode.ToString() + "\n";
            key_info.Text += "Key Char " + e.KeyValue.ToString() + "\n";
            key_info.Text += "Key DATA " + e.KeyData.ToString() + "\n";
            key_info.Text += "shift option " + (e.Shift ? "yes" : "No") + "\n";
            key_info.Text += "control option " + (e.Control ? "yes" : "No") + "\n";
            key_info.Text += "alt option " + (e.Alt?"yes":"no") + "\n";
        }

        private void txt_screen_TextChanged(object sender, EventArgs e)
        {

        }

        private void key_info_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
