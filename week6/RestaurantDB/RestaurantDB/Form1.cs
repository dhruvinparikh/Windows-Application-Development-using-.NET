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

namespace RestaurantDB
{
    public partial class Form1 : Form
    {
        public SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;
        double beverage, appetizer, mainCourse, desert,total,subtotal,tax;
        String itemBeverage, itemAppetizer, itemMainCourse, itemDesert;
        public void connect()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=restaurant;Integrated Security=True");
            con.Open();
        }

        public void close()
        {
            con.Close();
        }

        private void add(String item)
        {
            connect();
            SqlDataReader reader = getItemPrice(item);
            double price=0;
            while (reader.Read())
            {
                price = reader.GetDouble(0);
            }
            reader.Close();
            DateTime d = dateTimePicker1.Value.Date;
            SqlCommand cmd = new SqlCommand("insert into cust_transact values(@no,@custName,@item,@price,@dateEntry)", con);
            cmd.Parameters.AddWithValue("@no", txtTabelNumber.Text);
            cmd.Parameters.AddWithValue("@custName", txtName.Text);
            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@dateEntry", d);
            cmd.ExecuteNonQuery();
            close();
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(txtTabelNumber.Text != "")
            {
   
                if (cbBeverage.SelectedIndex != 0)
                {
                    add(itemBeverage);
                }
                if (cbAppetizer.SelectedIndex != 0)
                {
                    add(itemAppetizer);
                }
                if (cbMainCourse.SelectedIndex != 0)
                {
                    add(itemMainCourse);
                }
                if(cbDesert.SelectedIndex != 0)
                {
                    add(itemDesert);
                }
                DateTime d = dateTimePicker1.Value.Date;
                ShowOrder showOrder = new ShowOrder(txtTabelNumber.Text,d);
                showOrder.Show();
            }
            else
            {
                MessageBox.Show("Table number empty!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
            sda = new SqlDataAdapter("select item from menu where category='beverage'", con);

            dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbBeverage.Items.Insert(i+1, dt.Rows[i].ItemArray[0]);
            }

            sda = new SqlDataAdapter("select item from menu where category='appetizer'", con);

            dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbAppetizer.Items.Insert(i+1, dt.Rows[i].ItemArray[0]);
            }

            sda = new SqlDataAdapter("select item from menu where category='Main Course'", con);

            dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMainCourse.Items.Insert(i+1, dt.Rows[i].ItemArray[0]);
            }

            sda = new SqlDataAdapter("select item from menu where category='Desert'", con);

            dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbDesert.Items.Insert(i+1, dt.Rows[i].ItemArray[0]);
            }

            close();
            clearBill();
        }

        private void clearBill()
        {
            cbBeverage.SelectedIndex = 0;
            cbAppetizer.SelectedIndex = 0;
            cbMainCourse.SelectedIndex = 0;
            cbDesert.SelectedIndex = 0;
            total = 0;
            subtotal = 0;
            tax = 0;
            beverage = 0;
            appetizer = 0;
            mainCourse = 0;
            desert = 0;
            txtName.Text = "";
            txtTabelNumber.Text = "";
            lblTotal.Text = "$0";
            lblTax.Text = "$0";
            lblSubTotal.Text = "$0";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearBill();
        }

        private void updateBill()
        {
            subtotal = beverage + appetizer + mainCourse + desert;
            lblSubTotal.Text = "$" + Math.Round(subtotal, 2).ToString();
            tax = subtotal * 0.13;
            lblTax.Text = "$" + Math.Round(tax, 2).ToString();
            total = subtotal + tax;
            lblTotal.Text = "$" + Math.Round(total, 2).ToString();
        }

        private SqlDataReader getItemPrice(String item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select price from menu where item = '" + item + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            return cmd.ExecuteReader();
        }

        private void item_changed(object sender, EventArgs e)
        {
            ComboBox item_picker = (ComboBox)sender;
            if (item_picker.SelectedIndex != 0)
            {
                String item = item_picker.SelectedItem.ToString();
                connect();

                SqlDataReader reader = getItemPrice(item);
              
                if (sender == cbBeverage)
                {
                    itemBeverage = item;
                    while (reader.Read())
                    {
                        
                        beverage = reader.GetDouble(0);
                    }
                }
                else if (sender == cbAppetizer)
                {
                    itemAppetizer = item;
                    while (reader.Read())
                    {
                        
                        appetizer = reader.GetDouble(0);
                    }
                }
                else if (sender == cbMainCourse)
                {
                    itemMainCourse = item;
                    while (reader.Read())
                    {
                        mainCourse = reader.GetDouble(0);
                    }
                }
                else if (sender == cbDesert)
                {
                    itemDesert = item;
                    while (reader.Read())
                    {
                        desert = reader.GetDouble(0);
                    }
                }
                close();
            }
            else
            {
                if (sender == cbBeverage)
                {
                    beverage = 0;
                }
                else if (sender == cbAppetizer)
                {
                    appetizer = 0;
                }
                else if (sender == cbMainCourse)
                {
                    mainCourse = 0;
                }
                else if (sender == cbDesert)
                {
                    desert = 0;
                }
            }
            updateBill();
        }
    }
}
