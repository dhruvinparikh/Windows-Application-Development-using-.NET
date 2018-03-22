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
    public partial class Form1 : Form
    {
        bool status_wb=false,status_rb = false,status_bb = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void txt_whiteblack_TextChanged(object sender, EventArgs e)
        {
            if (!status_wb && txt_whiteblack.Text != "0")
            {            
                    txt_whiteblack.Text = "0";
                    MessageBox.Show("Not allowed", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    
            }
        }
        private void update_total()
        {
            double d1,d2,d3,subtotal,tax,shipping,total;
            d1 = Double.Parse(txt_whiteblack.Text) * 6.75;
            lbl_totalwhiteblack.Text = "$"+d1.ToString();
            d2 = Double.Parse(txt_redblack.Text) * 5.00;
            lbl_totalredblack.Text = "$" + d2.ToString();
            d3 = Double.Parse(txt_blueblack.Text) * 7.50;
            lbl_totalblueblack.Text = "$" + d3.ToString();
            subtotal = d1 + d2 + d3;
            lbl_subtotal.Text = "$" + subtotal.ToString();
            tax = Math.Round(subtotal * 0.05,2);
            lbl_tax.Text = "$" + tax.ToString();
            shipping = Math.Round(subtotal * 0.09,2);
            lbl_shipping.Text = "$" + shipping.ToString();
            total = subtotal + tax + shipping;
            lbl_total.Text = "$" + total.ToString();
        }
        private void KeyEvent_Press(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 8)
            e.Handled = !char.IsDigit(e.KeyChar);
    
            if (e.KeyChar == 13)
            {
                update_total();
            }
        }

        private void cb_whiteblack_CheckedChanged(object sender, EventArgs e)
        {
            status_wb = !status_wb;
            if (!status_wb)
            {
                txt_whiteblack.Text = "0";
                update_total();
            }
        }

        private void txt_redblack_TextChanged(object sender, EventArgs e)
        {
            if (!status_rb && txt_redblack.Text != "0")
            {
                txt_redblack.Text = "0";
                MessageBox.Show("Not allowed", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txt_blueblack_TextChanged(object sender, EventArgs e)
        {
            if (!status_bb && txt_blueblack.Text != "0")
            {
                txt_blueblack.Text = "0";
                MessageBox.Show("Not allowed", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update_total();
        }

        private void txt_totalwhiteblack_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        private void clear_all()
        {
            txt_ordernumber.Text = "";
            txt_addressline1.Text = "";
            txt_addressline2.Text = "";
            txt_addressline3.Text = "";
            txt_name.Text = "";
            txt_whiteblack.Text = "0";
            txt_redblack.Text = "0";
            txt_whiteblack.Text = "0";
            cb_whiteblack.Checked = false;
            cb_redblack.Checked = false;
            cb_blueblack.Checked = false;
            update_total();
            
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void cb_redblack_CheckedChanged(object sender, EventArgs e)
        {
            status_rb = !status_rb;
            if (!status_rb)
            {
                txt_redblack.Text = "0";
                update_total();
            }
        }

        private void cb_blueblack_CheckedChanged(object sender, EventArgs e)
        {
            status_bb = !status_bb;
            if (!status_bb)
            {
                txt_blueblack.Text = "0";
                update_total();
            }
        }
        
    }
}
