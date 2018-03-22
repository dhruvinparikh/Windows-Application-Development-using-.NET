using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
    public partial class Form1 : Form
    {
        double subtotal,total, beverage, appetizer, maincourse, desert,tax;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void calculateTotal()
        {
            subtotal = beverage + appetizer + maincourse + desert;
            lblSubTotal.Text = "$"+Math.Round(subtotal,2).ToString();
            tax = subtotal * 0.13;
            lblTax.Text = "$"+Math.Round(tax, 2).ToString();
            total = subtotal + tax;
            lblTotal.Text = "$" + Math.Round(total, 2).ToString();
        }

        private void billBeverage(int item)
        {
            switch (item)
            {
                case 0:
                    beverage = 0;
                    break;
                case 1:
                    beverage = 1.5;
                    break;
                case 2:
                    beverage = 1.25;
                    break;
                case 3:
                    beverage = 2.95;
                    break;
                case 4:
                    beverage = 2.5;
                    break;
                case 5:
                    beverage = 1.5;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearBill();
        }

        private void billAppetizer(int item)
        {
            switch (item)
            {
                case 0:
                    appetizer = 0;
                    break;
                case 1:
                    appetizer = 5.95;
                    break;
                case 2:
                    appetizer = 6.95;
                    break;
                case 3:
                case 4:
                    appetizer = 8.95;
                    break;
                case 5:
                    appetizer = 10.95;
                    break;
                case 6:
                    appetizer = 12.95;
                    break;
                case 7:
                    appetizer = 6.95;
                    break;
            }
            
        }

        private void billMainCourse(int item)
        {
            switch (item)
            {
                case 0:
                    maincourse = 0;
                    break;
                case 1:
                case 2:
                    maincourse = 13.95;
                    break;
                case 3:
                    maincourse = 11.95;
                    break;
                case 4:
                    maincourse = 19.95;
                    break;
                case 5:
                    maincourse = 20.95;
                    break;
                case 6:
                    maincourse = 18.95;
                    break;
                case 7:
                    maincourse = 13.95;
                    break;
                case 8:
                    maincourse = 14.95;
                    break;
                case 9:
                    maincourse = 15.95;
                    break;
            }
            
        }

        private void billDesert(int item)
        {
            switch (item)
            {
                case 0:
                    desert = 0;
                    break;
                case 1:
                case 3:
                case 5:
                    desert = 5.95;
                    break;
                case 2:
                    desert = 3.95;
                    break;
                case 4:
                    desert = 4.95;
                    break;
            }
            
        }

        private void cbRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(sender == cbBeverage)
            {
                billBeverage(cbBeverage.SelectedIndex);
                
            }
            else if(sender == cbAppetizer)
            {
                billAppetizer(cbAppetizer.SelectedIndex);
            }
            else  if(sender == cbMainCourse)
            {
                billMainCourse(cbMainCourse.SelectedIndex);
            }
            else if(sender == cbDesert)
            {
                billDesert(cbDesert.SelectedIndex);
            }
            calculateTotal();
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
            maincourse = 0;
            desert = 0;
            txtName.Text = "";
            txtTabelNumber.Text = "";
            lblTotal.Text = "$0";
            lblTax.Text = "$0";
            lblSubTotal.Text = "$0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clearBill();
        }
    }
}
