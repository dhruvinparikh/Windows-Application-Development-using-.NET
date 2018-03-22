using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBForm
{
    public partial class ShowData : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder sqb;
        public ShowData()
        {
            InitializeComponent();
        }

        private void ShowData_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=empdb;Integrated Security=True");
            con.Open();
            sda = new SqlDataAdapter("select empid from employee", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
