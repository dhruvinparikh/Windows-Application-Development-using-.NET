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

namespace testdb
{
    public partial class db : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;
        public db()
        {
            InitializeComponent();
        }

        private void db_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=empdb;Integrated Security=True");
            con.Open();
            sda = new SqlDataAdapter("Insert into employee values("+textBox1.Text+",'"+textBox2.Text+"','"+dateTimePicker1.Value.Date+"')", con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Insertion done successfully");
            con.Close();
        }
    }
}
