using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        StreamReader reader;
        StreamWriter writer;
        DialogResult result;
        String filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                result = open.ShowDialog();
                filename = open.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (filename == String.Empty)
                {
                    MessageBox.Show("select filename first");
                }
                else
                {
                    using(reader = new StreamReader(filename))
                    {
                        richTextBox1.Text = "";
                        richTextBox1.AppendText(reader.ReadToEnd());
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                result = save.ShowDialog();
                filename = save.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (filename == String.Empty)
                {
                    MessageBox.Show("select filename first");
                }
                else
                {
                    FileStream file = new FileStream(filename+".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    using(writer = new StreamWriter(file))
                    {
                        writer.WriteLine(richTextBox1.Text);
                    }
                }
            }
        }
    }
}
