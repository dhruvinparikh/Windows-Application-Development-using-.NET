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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorPicker(object sender, EventArgs e)
        {
            clearColor();
            if (sender == redColorMenu)
            {
                label1.ForeColor = Color.Red;
                redColorMenu.Checked = true;
            }
            else if (sender == greenColorMenu)
            {
                label1.ForeColor = Color.Green;
                greenColorMenu.Checked = true;
            }
            else if (sender == blueColorMenu)
            {
                label1.ForeColor = Color.Blue;
                blueColorMenu.Checked = true;
            }
        }

        private void clearColor()
        {
            redColorMenu.Checked = false;
            greenColorMenu.Checked = false;
            blueColorMenu.Checked = false;
        }

        private void stylePicker(object sender, EventArgs e)
        {

            if (sender == arialFont)
            {
                clearStyle();
                label1.Font = new Font("Arial", 14, label1.Font.Style);
                arialFont.Checked = true;
            }
            else if (sender == timesNewRomanFont)
            {
                clearStyle();
                label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
                timesNewRomanFont.Checked = true;
            }
            else if (sender == serifFont)
            {
                clearStyle();
                label1.Font = new Font("Serif", 14, label1.Font.Style);
                serifFont.Checked = true;
            }
            if (sender == boldStyle)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
            }
            else if (sender == italicsStyle)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
            }
        }

        private void clearStyle()
        {
            arialFont.Checked = false;
            timesNewRomanFont.Checked = false;
            serifFont.Checked = false;
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\humber");
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
