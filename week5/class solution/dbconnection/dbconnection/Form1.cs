using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbconnection
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=empdb;Integrated Security=True");
            con.Open();
            sda = new SqlDataAdapter("insert into employe values("+textBox1.Text+",'"+textBox2.Text+"','"+dateTimePicker1.Value.Date+"')",con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Insertion done successfully");
            con.Close();
        }
    }
}
