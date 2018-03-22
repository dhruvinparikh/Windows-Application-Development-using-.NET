using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuApplication
{
    public partial class SadHappySmileyGame : Form
    {
        public SadHappySmileyGame()
        {
            InitializeComponent();
        }
        int count = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                pictureBox1.Image = Image.FromFile(@"sad.jpg");   
                count = 1;
            }
            else if(count == 1)
            {
                pictureBox1.Image = Image.FromFile(@"happy.jpg");
                count = 0;
            }
        }

        private void SadHappySmileyGame_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"happy.jpg");
        }
    }
}
