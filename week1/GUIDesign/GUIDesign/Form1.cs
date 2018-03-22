using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");

            //calculate click event
            double num1 = 0.0d, num2 = 0.0d, sum = 0.0d;
            //num1 = Convert.ToDouble(txt_num1.text);
            //num2 = Convert.ToDouble(txt_num2.text);
            //sum = num1 + num2;
            //txt_sum.text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
