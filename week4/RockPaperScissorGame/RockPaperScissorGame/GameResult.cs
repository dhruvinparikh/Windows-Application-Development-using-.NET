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
    public partial class GameResult : Form
    {
        public GameResult()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void GameResult_Load(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            int pcScore = Form1.pcScore;
            int userScore = Form1.userScore;
            int ties = Form1.ties;

            if(pcScore > userScore)
            {
                label4.Text = "PC is the winner";
            }
            else if (userScore > pcScore)
            {
                label4.Text = "User is the winner";
            }
            else
            {
                label4.Text = "Tie";
            }

            label5.Text = pcScore.ToString();
            label6.Text = userScore.ToString();
            label10.Text = ties.ToString();

        }

        private void exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
