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

namespace lecture2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String name = Interaction.InputBox("Enter your name", "Information", "name", -1, -1);
            
            MessageBox.Show(name);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
         DialogResult result =   MessageBox.Show("Welcome to my .NET class","Intro",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("OK clicked");
            }
            else
            {
                MessageBox.Show("cancel clicked");
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wan to exit", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
