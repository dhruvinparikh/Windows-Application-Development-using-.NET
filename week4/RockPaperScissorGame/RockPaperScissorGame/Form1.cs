using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshScreen()
        {
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[1];
            pictureBox3.Image = imageList1.Images[2];
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshScreen();
        }
         public static int userScore, pcScore, ties;
        //0->rock
        //1->paper
        //2->scissor
        //0,2->0
        //1,0->1
        //2,1->2
        public int getUserScore()
        {
            return userScore;
        }

        public int getPCScore()
        {
            return pcScore;
        }

        public int getTies()
        {
            return ties;
        }

        private void playPC(int i)
        {
            Random random = new Random();
            int rdm = random.Next(0, 2);

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;

            pictureBox4.Image = imageList1.Images[i];
            pictureBox5.Image = imageList1.Images[rdm];

            if (rdm == i)
            {
                label4.Text = "Tie";
                ties++;
            }
            else if (rdm == 0 && i == 2)
            {
                label4.Text = "PC Won";
                pcScore++;
            }
            else if (i == 0 && rdm == 2)
            {
                label4.Text = "You Won";
                userScore++;
            }
            else if (rdm == 1 && i == 0)
            {
                label4.Text = "PC Won";
                pcScore++;
            }
            else if (i == 1 && rdm == 0)
            {
                label4.Text = "You Won";
                userScore++;
            }
            else if (rdm == 2 && i == 1)
            {
                label4.Text = "PC Won";
                pcScore++;
            }
            else if (i == 2 && rdm == 1)
            {
                label4.Text = "You Won";
                userScore++;
            }
            
                DialogResult result = MessageBox.Show("Do you want to play again?","Play Again", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                startGame = false;
                button1.Enabled = true;
                refreshScreen();
            }
            else
            {
                GameResult obj = new GameResult();
                obj.Show();
                this.Hide();
            }

        }

        private void chooseImage(object sender, EventArgs e)
        {
            int i = 0;
            if (startGame)
            {
                if (sender == pictureBox1)
                {
                    i = 0;
                }
                else if (sender == pictureBox2)
                {
                    i = 1;
                }
                else if (sender == pictureBox3)
                {
                    i = 2;
                }
                playPC(i);
            }
        }
        bool startGame;
        private void button1_Click(object sender, EventArgs e)
        {
            startGame = true;
            button1.Enabled = false;
        }
    }
}
