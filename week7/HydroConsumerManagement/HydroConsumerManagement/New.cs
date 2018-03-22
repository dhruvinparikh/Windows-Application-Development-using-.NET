using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydroConsumerManagement
{
    public partial class New : Form
    {
        public New()
        {
            InitializeComponent();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnAdd_Click(null, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length > 7 && txtPassword.Text.Length < 10 && txtUsername.Text.Length > 7 && txtUsername.Text.Length < 11)
            {
                CLogin c = new CLogin();
                c.Username = txtUsername.Text;
                c.Password = txtPassword.Text;
                CLoginDB.add(c);
                DBUtil.closeSqlConnection();
                MessageBox.Show("Account added");
            }
        }
    }
}
