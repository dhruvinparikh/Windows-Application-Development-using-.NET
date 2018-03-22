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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double num1 = 0.0d, num2 = 0.0d, sum = 0.0d;

            num1 = Convert.ToDouble(txt_num1.Text);
            num2 = Convert.ToDouble(txt_num2.Text);
            sum = num1 + num2;
            txt_sum.Text = sum.ToString();
        }

        private void txt_sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
