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
    public partial class Payment : Form
    {
        List<String> creditCardType = new List<string>();
        List<String> month = new List<String>();
        List<String> year = new List<String>();
        int keyStroke=0;
        int customerIndex = 0;
        PaymentClass p = new PaymentClass();
        public Payment(int customerIndex)
        {
            InitializeComponent();
            creditCardType.Add("Visa");
            creditCardType.Add("Mastercard");
            creditCardType.Add("American Express");
            month.Add("Jan");
            month.Add("Feb");
            month.Add("Mar");
            month.Add("Apr");
            month.Add("May");
            month.Add("Jun");
            month.Add("Jul");
            month.Add("Aug");
            month.Add("Sep");
            month.Add("Oct");
            month.Add("Nov");
            month.Add("Dec");
            year.Add(DateTime.Now.Year+"");
            year.Add((DateTime.Now.Year+1) + "");
            year.Add((DateTime.Now.Year + 2) + "");
            year.Add((DateTime.Now.Year + 3) + "");
            year.Add((DateTime.Now.Year + 4) + "");
            year.Add((DateTime.Now.Year + 5) + "");
            this.customerIndex = customerIndex;
        }

        private void checkBilling()
        {
            if (rbBillCustomer.Checked)
            {
                lbCreditCardType.Enabled = false;
                tbCardNumber.Enabled = false;
                cbMonth.Enabled = false;
                cbYear.Enabled = false;  
            }
            else
            {
                lbCreditCardType.Enabled = true;
                tbCardNumber.Enabled = true;
                cbMonth.Enabled = true;
                cbYear.Enabled = true;
                lbCreditCardType.DataSource = creditCardType;
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            checkBilling();
            cbMonth.DataSource = month;
            cbYear.DataSource = year;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            checkBilling();
        }

        private void rbBillCustomer_CheckedChanged(object sender, EventArgs e)
        {
            checkBilling();
        }

        private void payment_closed(object sender, FormClosedEventArgs e)
        {
        }

        private void tbCardNumber_TextChanged(object sender, EventArgs e)
        {
            keyStroke = tbCardNumber.Text.Length;
        }

        private void creditCardNumber_key_pressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (keyStroke < 16)
                {
                    e.Handled = !char.IsDigit(e.KeyChar);
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String s = "";
            
            this.Hide();
            if (rbCreditCard.Checked)
            {
                p.Billing = "Credit Card";
                p.CreditCardType = creditCardType.ElementAt<String>(lbCreditCardType.SelectedIndex);
                p.CreditCardNumber = tbCardNumber.Text+"";
                p.ExpirationMonth = month.ElementAt<String>(cbMonth.SelectedIndex);
                p.ExpirationYear = Convert.ToInt16(year.ElementAt<String>(cbYear.SelectedIndex));
                
                s += "Charge to credit charge\n";
                s += "Credit Type : " + lbCreditCardType.SelectedValue.ToString()+"\n";
                s += "Card Number : " + tbCardNumber.Text+"\n";
                s += "Expiration date : " + cbMonth.SelectedValue.ToString() + "/" + cbYear.SelectedValue.ToString() + "\n";
                if (chkbDefaultBilling.Checked)
                {
                    p.DefaultBillingPeriod = 'Y';
                    s += "Default billing : True";
                }
                else
                {
                    p.DefaultBillingPeriod = 'N';
                    s += "Default billing : False";
                }
            }
            else if (rbBillCustomer.Checked)
            {
                s = "Bill Customer";
            }
            Form1 form1 = new Form1(s,customerIndex,p);
            form1.Show();
        }
    }
}
