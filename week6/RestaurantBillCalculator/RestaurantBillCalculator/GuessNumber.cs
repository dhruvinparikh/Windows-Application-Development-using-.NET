using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
    public partial class GuessNumber : Form
    {
        public GuessNumber()
        {
            InitializeComponent();
        }

        private void GuessNumber_Load(object sender, EventArgs e)
        {
            lblPCNum.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        int trials = 0;

        private void btnGuess_Click(object sender, EventArgs e)
        {
            trials++;

            Random r = new Random();
            int a = r.Next(1, 100);

            lblPCNum.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lblPCNum.Visible = true;

            int user = int.Parse(txtNumber.Text);
            if(user == 0)
            {
                Application.Exit();
            }
            else if(user < a)
            {
                GuessNumber.ActiveForm.BackColor = Color.Red;
                label2.Visible = true;
                label2.Text = "Low,Try again";
                
            }
            else if(user > a){
                GuessNumber.ActiveForm.BackColor = Color.Yellow;
                label2.Visible = true;
                label2.Text = "High,Try again";
            }
            else if(user == a)
            {
                GuessNumber.ActiveForm.BackColor = Color.Green;
                label2.Visible = true;
                label2.Text = "You guessed it";
                label3.Visible = true;
                label3.Text = "It took you " + trials.ToString() + " tries";
                trials = 0;
            }
            lblPCNum.Text = "Computer Guess : " + a.ToString();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
