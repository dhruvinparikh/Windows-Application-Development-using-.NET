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
    public partial class Form4 : Form
    {
        double num = 0.0d;
        String op = "";
        String mode = "general";
        int mathFunction = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_screen.Enabled)
            {
                power(false);
                btn_on.Text = "ON";
            }
            else
            {
                power(true);
                btn_on.Text = "OFF";
            }
        }
        private void power(Boolean status)
        {
            btn_1.Enabled = status;
            btn_2.Enabled = status;
            btn_3.Enabled = status;
            btn_4.Enabled = status;
            btn_5.Enabled = status;
            btn_6.Enabled = status;
            btn_7.Enabled = status;
            btn_8.Enabled = status;
            btn_9.Enabled = status;
            btn_0.Enabled = status;
            btn_00.Enabled = status;
            btn_add.Enabled = status;
            btn_sub.Enabled = status;
            btn_mul.Enabled = status;
            btn_modulo.Enabled = status;
            btn_decimal.Enabled = status;
            btn_divide.Enabled = status;
            btn_equal.Enabled = status;
            btn_clear.Enabled = status;
            txt_screen.Enabled = status;
            btn_factorial.Enabled = status;
            btn_hex.Enabled = status;
            btn_oct.Enabled = status;
            btn_binary.Enabled = status;
            btn_log.Enabled = status;
            clear_all();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void clear_all()
        {
            txt_screen.Text = "0";
            num = 0.0d;
            op = "";
            btn_decimal.Enabled = true;
        }
        private void clear_screen()
        {
            txt_screen.Text = "";
        }
        private void btn_2_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_3_Click(object sender, EventArgs e)
        {

        }

        private void btn_4_Click(object sender, EventArgs e)
        {

        }

        private void btn_00_Click(object sender, EventArgs e)
        {

        }

        private void btn_5_Click(object sender, EventArgs e)
        {

        }

        private void btn_6_Click(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {

        }

        private void btn_8_Click(object sender, EventArgs e)
        {

        }

        private void btn_9_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            power(false);
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            txt_screen.Text += ".";
            btn_decimal.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
                select_op();
           
            op = "+";
            mode = "general";
        }
        private void select_op()
        {
            switch (op)
            {
                case "+":
                    num += Double.Parse(txt_screen.Text);
                    break;
                case "-":
                    num -= Double.Parse(txt_screen.Text);
                    break;
                case "/":
                    num /= Double.Parse(txt_screen.Text);
                    break;
                case "%":
                    num %= Double.Parse(txt_screen.Text);
                    break;
                case "*":
                    num *= Double.Parse(txt_screen.Text);
                    break;
                default:
                    if (txt_screen.Text != "")
                        num = Convert.ToDouble(txt_screen.Text);
                    else
                        num = 0d;
                    break;
            }
            txt_screen.Text = "";
            btn_decimal.Enabled = true;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            
                select_op();
            
            op = "-";
            mode = "general";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
           
                
                select_op();
            
            op = "/";
            mode = "general";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
           
           select_op();
            
            op = "*";
            mode = "general";

        }

        private void btn_modulo_Click(object sender, EventArgs e)
        {
            select_op();
            op = "%";
            mode = "general";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            select_op();
            txt_screen.Text = num.ToString();
            op = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_hex_Click(object sender, EventArgs e)
        {

        }

        private void btn_oct_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void displayNum(String strNum)
        {
            if (op == "" && txt_screen.Text == "0")
            {
                clear_screen();
            }
            if (mode == "programmer")
            {
                mode = "general";
                txt_screen.Text = strNum;
            }
            else
                txt_screen.Text += strNum;
        }
        private void Button_Num_Click(object sender, EventArgs e)
        {
            mathFunction = 0;
            if(sender == btn_0)
            {
                displayNum("0");
            }
            else if(sender == btn_00)
            {
                displayNum("00");
            }
            else if(sender == btn_1)
            {
                displayNum("1");
            }
            else if(sender == btn_2)
            {
                displayNum("2");
            }
            else if(sender == btn_3)
            {
                displayNum("3");
            }
            else if(sender == btn_4)
            {
                displayNum("4");
            }
            else if(sender == btn_5)
            {
                displayNum("5");
            }
            else if(sender == btn_6)
            {
                displayNum("6");
            }
            else if(sender == btn_7)
            {
                displayNum("7");
            }
            else if(sender == btn_8)
            {
                displayNum("8");
            }
            else if(sender == btn_9)
            {
                displayNum("9");
            }
        }
        private void setOperator(String strOp)
        {
            select_op();

            op = strOp;
            mode = "general";
        }
        private void Button_Operator_Click(object sender, EventArgs e)
        {
            if(sender == btn_add)
            {
                setOperator("+");
            }
            else if(sender == btn_divide)
            {
                setOperator("/");
            }
            else if(sender == btn_sub)
            {
                setOperator("-");
            }
            else if(sender == btn_mul)
            {
                setOperator("*");
            }
            else if(sender == btn_modulo)
            {
                setOperator("%");
            }
            else if(sender == btn_equal)
            {
                select_op();
                txt_screen.Text = num.ToString();
                op = "";
            }
        }
        private void calFactorial()
        {
            long result = 1;
            long numFact;
            numFact = (long)Math.Round(Double.Parse(txt_screen.Text));
            do
            {
                result *= numFact;
                numFact--;
            }
            while (numFact > 0);
            num = (Double)result;
            txt_screen.Text = result.ToString();
            mode = "programmer";
            btn_decimal.Enabled = true;
        }
        private void decimalToHex()
        {
            long quotient;
            long temp;
            String hexadecimalNumber = "";

            quotient = (long)Math.Round(Double.Parse(txt_screen.Text));

            while (quotient != 0)
            {
                temp = quotient % 16;

                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;

                hexadecimalNumber += (char)temp;
                quotient = quotient / 16;
            }
            txt_screen.Text = new String(hexadecimalNumber.ToCharArray().Reverse().ToArray());

            mode = "programmer";
            btn_decimal.Enabled = true;

        }

        private void decimalToOctal()
        {
            long octalNumber = 0, i = 1;
            long decimalNumber;
            decimalNumber = (long)Math.Round(Double.Parse(txt_screen.Text));
            while (decimalNumber != 0)
            {
                octalNumber += (decimalNumber % 8) * i;
                decimalNumber /= 8;
                i *= 10;
            }
            txt_screen.Text = octalNumber.ToString();
            mode = "programmer";
            btn_decimal.Enabled = true;

        }

        private void decimalToBinary()
        {
            long n;
            long binaryNumber = 0;
            long remainder, i = 1;

            n = (long)Math.Round(Double.Parse(txt_screen.Text));
            while (n != 0)
            {
                remainder = n % 2;
                n /= 2;
                binaryNumber += remainder * i;
                i *= 10;
            }
            txt_screen.Text = binaryNumber.ToString();
            mode = "programmer";
            btn_decimal.Enabled = true;
        }

        private void calLog()
        {
            txt_screen.Text = Math.Round(Math.Log(Double.Parse(txt_screen.Text)),2).ToString();
            mode = "programmer";
            btn_decimal.Enabled = true;
        }

        private void Button_Function_Click(object sender, EventArgs e)
        {
            if(sender == btn_factorial)
            {
                if (mathFunction != 0)
                {
                    txt_screen.Text = "0";
                }
                else
                {
                    calFactorial();
                }
            }
            else if(sender == btn_hex)
            {
                switch (mathFunction)
                {
                    case 0:
                        decimalToHex();
                    break;
                    case 1:
                        break;
                    case 2:
                    case 3:
                        txt_screen.Text = "0";
                        num = 0;
                    break;
                }
                mathFunction = 1;
            }
            else if(sender == btn_oct)
            {
                switch (mathFunction)
                {
                    case 0:
                        decimalToOctal();
                        break;
                    
                    case 2:
                        break;
                    case 1:
                    case 3:
                        txt_screen.Text = "0";
                        num = 0;
                        break;
                }
                
                mathFunction = 2;
            }
            else if(sender == btn_binary)
            {
                switch (mathFunction)
                {
                    case 0:
                        decimalToBinary();
                        break;
                    case 1:
                    case 2:
                        txt_screen.Text = "0";
                        break;
                    case 3:
                        
                        break;
                }
                
                mathFunction = 3;
            }
            else if(sender == btn_log)
            {
                if (mathFunction != 0)
                {
                    txt_screen.Text = "0";
                    num = 0;
                    mathFunction = 0;
                }
                else
                {
                    if(Convert.ToDouble(txt_screen.Text) > 0)
                    calLog();
                }
            }
        }
    }
}
