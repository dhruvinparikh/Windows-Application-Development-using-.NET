using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace calculator
{
    public partial class Form1 : Form
    {
        String op="";
        double num1=0L;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const bool value = false;
            btn_onoff.Text = "ON";
            en_dis(value);
            clear_all();
            MessageBox.Show("Click ON to start calc");
            String name=Interaction.InputBox("Enter your Name", "Profile", "New User", -1, -1);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //all variables should be cleared
            btn_dot.Enabled = true;
            clear_all();
        }

        private void clear_all()
        {
            txt_screen.Text = "";
            //all variables should be cleared
            num1 = 0L;
            op = "";
        }
        private void btn_onoff_Click(object sender, EventArgs e)
        {
            if(txt_screen.Enabled==true)
            {
                const bool value = false;
                btn_onoff.Text = "ON";
                en_dis(value);
                clear_all();
            }
            else
            {
                const bool value = true;
                txt_screen.Enabled = true;
                en_dis(value);
                btn_onoff.Text = "OFF";
                btn_dot.Enabled = true;
                clear_all();

            }
        }
        private void en_dis(bool value)
        {
            txt_screen.Enabled = value;
            btn_1.Enabled = value;
            btn_clear.Enabled = value;
            btn_2.Enabled = value;
            btn_3.Enabled = value;
            btn_4.Enabled = value;
            btn_5.Enabled = value;
            btn_6.Enabled = value;
            btn_7.Enabled = value;
            btn_8.Enabled = value;
            btn_9.Enabled = value;
            btn_0.Enabled = value;
            btn_00.Enabled = value;
            btn_add.Enabled = value;
            btn_sub.Enabled = value;
            btn_mul.Enabled = value;
            btn_div.Enabled = value;
            btn_mod.Enabled = value;
            btn_eq.Enabled = value;
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_screen.Text += 1;
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_screen.Text += 0;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_screen.Text += 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_screen.Text += 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_screen.Text += 4;
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            txt_screen.Text += 00;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_screen.Text += 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_screen.Text += 6;
        }
        private void btn_7_Click(object sender,EventArgs e)
        {
            txt_screen.Text += 7;
        }
        private void btn_8_Click_1(object sender, EventArgs e)
        {
            txt_screen.Text += 8;
        }
        private void btn_9_Click(object sender,EventArgs e)
        {
            txt_screen.Text += 9;
        }
        private void btn_dot_Click(object sender, EventArgs e)
        {
           
            txt_screen.Text = txt_screen.Text+".";
            btn_dot.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            call_operation();
            op= "+";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            call_operation();
            op = "-";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            call_operation();
            op = "/";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            call_operation();
            op = "*";
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            call_operation();
            op = "%";
        }

        private void btn_eq_Click(object sender, EventArgs e)
        {
            call_operation();
            txt_screen.Text = num1.ToString();
            num1 = 0L;
            op = "";
            
        }
        
        

        private void call_operation()
        {
            switch (op)
            {
                case "+":
                    num1 += Convert.ToDouble(txt_screen.Text);
                    break;
                case "-":
                    num1 -= Convert.ToDouble(txt_screen.Text);
                    break;
                case "*":
                    num1 *= Convert.ToDouble(txt_screen.Text);
                    break;
                case "/":
                    num1 /= Convert.ToDouble(txt_screen.Text);
                    break;
                case "%":
                    num1 %= Convert.ToDouble(txt_screen.Text);
                    break;
                default:
                    if (txt_screen.Text != "")
                        num1 = Convert.ToDouble(txt_screen.Text);
                    else
                        num1 = 0d;
                    break;
            }
            txt_screen.Text = "";
            btn_dot.Enabled = true;
        }

    }
}
