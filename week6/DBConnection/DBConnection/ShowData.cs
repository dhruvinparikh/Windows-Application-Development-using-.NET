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

namespace DBConnection {

    public partial class ShowData : Form {

        SqlConnection con;
        SqlDataAdapter sda, sda1;
        DataTable dt;
        SqlCommandBuilder sqb;

        public ShowData() {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e) {
            sqb = new SqlCommandBuilder(sda1);
            sda1.Update(dt);
        }

        private void ShowData_Load(object sender, EventArgs e) {
            con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = empdb; Integrated Security = True");
            con.Open();

            //sda = new SqlDataAdapter("select * from employee", con);
            sda1 = new SqlDataAdapter("select * from employee", con);
            dt = new DataTable();

            sda1.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
