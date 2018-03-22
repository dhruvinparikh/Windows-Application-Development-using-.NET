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
    public partial class Form1 : Form {

        SqlConnection con;
        SqlDataAdapter sda;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = empdb; Integrated Security = True");
            con.Open();
            DateTime dateTimeVariable = dateTimePicker1.Value.Date;
            SqlCommand cmd = new SqlCommand("INSERT INTO EMPLOYEE VALUES (@id,@name,@date)", con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@date", dateTimeVariable);
            cmd.ExecuteNonQuery();
            //sda = new SqlDataAdapter("insert into employee values(" + textBox1.Text + ", '" + textBox2.Text + "','" +dateTimeVariable + "')", con);
            //sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("insertion done successfully");
            con.Close();

        }
    }
}
