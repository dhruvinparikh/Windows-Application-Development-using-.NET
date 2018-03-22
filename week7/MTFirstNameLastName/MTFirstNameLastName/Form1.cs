using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTFirstNameLastName
{
    public partial class Form1 : Form
    {
        String paymentMethod = "";
        int customerIndex = 0;
        PaymentClass p = null;
        public Form1(String paymentMethod,int customerIndex,PaymentClass p)
        {
            InitializeComponent();
            this.customerIndex = customerIndex;
            this.paymentMethod = paymentMethod;
            this.p = p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> customer = new List<String>();
            customer.Add("Select Customer");
            customer.Add("Sam");
            customer.Add("Mary");
            customer.Add("Jose");
            customer.Add("Joseph");
            customer.Add("John");
            customer.Add("Smith");
            for (int i = 0; i < customer.Count; i++)
            {
                cbCustomerName.Items.Add(customer.ElementAt<String>(i));
            }
            cbCustomerName.SelectedIndex = customerIndex;
            btnSelectPayment.Enabled = false;
            lblPaymentMethod.Text = paymentMethod;
        }

        private void cbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerName.SelectedIndex != 0)
            {
                btnSelectPayment.Enabled = true;
            }
            else
            {
                btnSelectPayment.Enabled = false;
            }
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            if (cbCustomerName.SelectedIndex != 0)
            {
                this.Hide();
                Payment payment = new Payment(cbCustomerName.SelectedIndex);
                payment.Show();
            }
        }

        private void customer_closed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Application is closing", "Quit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customer_closing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Payment p = new Payment(customerIndex);
            PaymentDB.add(p);
            DBUtil.closeSqlConnection();
            MessageBox.Show("Data saved");
        }
    }
}
