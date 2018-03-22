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
    public partial class ChangePassword : Form
    {
        string password = Login.password;
        bool isNew = false;
        bool isConfirm = false;
        public ChangePassword()
        {
            InitializeComponent();
            tbNewPassword.Enabled = false;
            tbConfirmPassword.Enabled = false;
            btnChange.Enabled = false;
        }

        private void tbOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbOldPassword.Text == password)
            {
                pictureBox1.Image = imageList1.Images[0];
                tbNewPassword.Enabled = true;
                tbConfirmPassword.Enabled = true;
            }
            else if (tbOldPassword.Text == "")
            {
                pictureBox1.Image = null;
                tbNewPassword.Enabled = false;
                tbConfirmPassword.Enabled = false;
            }
            else if (tbOldPassword.Text != password)
            {
                pictureBox1.Image = imageList1.Images[1];
                tbNewPassword.Enabled = false;
                tbConfirmPassword.Enabled = false;
            }
        }

        private void tbNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbNewPassword.Text.Length > 7 && tbNewPassword.Text.Length < 10)
            {
                pictureBox2.Image = imageList1.Images[0];
                isNew = true;
                if (tbConfirmPassword.Text == tbNewPassword.Text && isNew)
                {
                    pictureBox3.Image = imageList1.Images[0];
                    isConfirm = true;
                }
                else
                {
                    pictureBox3.Image = imageList1.Images[1];
                    isConfirm = false;
                }
                if (tbConfirmPassword.Text == "")
                {
                    pictureBox3.Image = null;
                    isConfirm = false;
                }
            }
            else
            {
                pictureBox2.Image = imageList1.Images[1];
                isNew = false;
                if(tbConfirmPassword.Text != "")
                {
                    pictureBox3.Image = imageList1.Images[1];
                    isConfirm = false;
                }
                else
                {
                    pictureBox3.Image = null;
                    isConfirm = false;
                }
            }
            if(tbNewPassword.Text == "")
            {
                pictureBox2.Image = null;
                isNew = false;
            }
            if(isConfirm  && isNew)
            {
                btnChange.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
            }
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(isNew && isConfirm)
            {
                CLogin c = new CLogin();
                c.Password = tbConfirmPassword.Text;
                c.Username = Login.username;
                CLoginDB.updatePassword(c);
                DBUtil.closeSqlConnection();
                Login.initLogin();
                DialogResult result = MessageBox.Show("Password changed","Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void tbConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void tbConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbC_keypress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 && isConfirm && isNew)
            {
                btnChange_Click(null, null);
            }
        }
    }
}
