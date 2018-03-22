using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace testdb
{
    public partial class Form1 : Form
    {
        Stack names = new Stack();
        BindingSource source;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            source = new BindingSource();
            names.Push(textBox1.Text);
            MessageBox.Show("Data added");
            //source.DataSource = names;
            //dataGridView1.AllowUserToAddRows = true;
            //dataGridView1.DataSource = source;
            // this.dataGridView1.Rows.Add(names);
            // dataGridView1.DataSource = names;
            dataGridView1.Rows.Add(new object[] { 0,names.Peek() });
            
        }
    }
}
