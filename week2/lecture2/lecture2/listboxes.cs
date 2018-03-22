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
    public partial class listboxes : Form
    {
        public listboxes()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lb_left.Items.Add(txt_screen.Text);
            txt_screen.Text = "";
        }

        private void btn_shift_Click(object sender, EventArgs e)
        {
            lb_right.Items.Add(lb_left.SelectedItem);
            lb_left.Items.Remove(lb_left.SelectedItem);
        }

        private void btn_unshift_Click(object sender, EventArgs e)
        {
            lb_left.Items.Add(lb_right.SelectedItem);
            lb_right.Items.Remove(lb_right.SelectedItem);
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            int cnt = lb_left.Items.Count;
            String list = "";
            String text = "";
            foreach(String s in lb_left.Items)
            {
                text = text + "\n" + s;
            }
            MessageBox.Show(text);
            for(int i = 0; i < lb_left.Items.Count; i++)
            {
                list += lb_left.Items[i]+"\n";
            }
            MessageBox.Show(list);
        }

        private void listboxes_Load(object sender, EventArgs e)
        {
           
        }
    }
}
