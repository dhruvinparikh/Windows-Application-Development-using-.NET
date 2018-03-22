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

namespace ClassRestaurant
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void item_changed(object sender, EventArgs e)
        {
            ComboBox item_picker = (ComboBox)sender;
            String item = item_picker.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select price from menu where item = '" + item + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();

            //single row, single column 
            //while (reader.Read())
            //{
            //    MessageBox.Show(reader[0].ToString());
            //}
            int tno= Convert.ToInt32(textBox1.Text); ;
            string customer = textBox2.Text;
            String price = "";
            while (reader.Read())
            {
                price = reader.GetInt32(0).ToString();
                //To get float value//String floatPrice = reader.GetSqlSingle(0).ToString();
                MessageBox.Show(price);
                
            }
            reader.Close();
            //Double p = Convert.ToDouble(price);
            DateTime d = DateTime.UtcNow.Date;
            cmd = new SqlCommand("insert into cust_transact values(" + tno + ",'" + customer + "','" + item + "'," + Convert.ToInt32(price) + ", SYSDATETIME())", con);
            cmd.ExecuteNonQuery();

            //while (reader.Read())
            //{
            //    ReadSingleRow((IDataRecord)reader);
            //}


            con.Close();

            //sda = new SqlDataAdapter("select price from menu where item '" + item + "'", con);
        }

        private static void ReadSingleRow(IDataRecord record)
        {
            MessageBox.Show(record[0].ToString() + "" + record[1].ToString()+""+record[2].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=restaurant;Integrated Security=True");
            con.Open();
            sda = new SqlDataAdapter("select item from menu where category='beverage'", con);
            
            dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Insert(i, dt.Rows[i].ItemArray[0]);
            }
            con.Close();
        }
    }
}
