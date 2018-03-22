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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double num1 = 0.0d, num2 = 0.0d, result = 0.0d;

            num1 = Double.Parse(txt_num1.Text);
            num2 = Double.Parse(txt_num2.Text);

            if (rb_add.Checked)
            {
                result = num1 + num2;
            }
            else if (rb_mul.Checked)
            {
                result = num1 * num2;
            }
            else if (rd_sub.Checked)
            {
                result = num1 - num2;
                
            }
            txt_sum.Text = result.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rb_add.Checked = true;
        }
    }
}
