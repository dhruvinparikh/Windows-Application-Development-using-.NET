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
    public partial class ShowOrder : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        String tno;
        DateTime date;
        public ShowOrder(String tno,DateTime date)
        {
            InitializeComponent();
            this.tno = tno;
            this.date = date;
        }

        private void ShowOrder_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.connect();
            sda = new SqlDataAdapter("select distinct tno from cust_transact", form1.con);

            dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbTableNumber.Items.Insert(i, dt.Rows[i].ItemArray[0]);
            }

            sda = new SqlDataAdapter("select distinct date_entry from cust_transact", form1.con);

            dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbDate.Items.Insert(i, dt.Rows[i].ItemArray[0]);
            }

            form1.close();

            for (int i = 0; i < cbTableNumber.Items.Count; i++)
            {
                this.cbTableNumber.SelectedIndex = i;
                if (this.cbTableNumber.Items[i].ToString() == tno)
                {
                    break;
                }
            }

            for (int i = 0; i < cbDate.Items.Count; i++)
            {
                if (this.cbDate.Items[i].ToString() == date.ToString())
                {
                    cbDate.SelectedIndex = i;
                    break;
                }
            }
        }

        private void getOrder()
        {
            Form1 form1 = new Form1();
            form1.connect();
            SqlCommand cmd = new SqlCommand("select items from cust_transact where tno = @no and date_entry = @d", form1.con);
            cmd.Parameters.AddWithValue("@no", tno);
            cmd.Parameters.AddWithValue("@d", date);
            //cmd.ExecuteNonQuery();
            sda = new SqlDataAdapter(cmd);
           
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            form1.close();
        }

        private void item_change(object sender, EventArgs e)
        {
            ComboBox item_picker = (ComboBox)sender;
            String item = item_picker.SelectedItem.ToString();

           if(cbDate.SelectedIndex >= 0 && cbTableNumber.SelectedIndex >= 0)
            {
                if(sender == cbTableNumber)
                {
                    tno = item;
                }
                else if(sender == cbDate)
                {
                    date = DateTime.Parse(item);
                }

                getOrder();
            }

        }
    }
}
