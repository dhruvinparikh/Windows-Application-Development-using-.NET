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

namespace DBForm
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=empdb;Integrated Security=True");
            con.Open();
            sda = new SqlDataAdapter("insert into employee values("+txtEmpID.Text+",'"+txtName.Text+"','"+dateTimePicker1.Value.Date+"')", con);
          sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Insertion done");
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
