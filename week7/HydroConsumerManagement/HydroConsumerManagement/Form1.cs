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
    public partial class Login : Form
    {
        public bool admin = false;
        bool isUser = false, isPass = false;
        bool changePassForm = false;
        bool hydroForm = false;
        int index = 0; bool match = false;
        static List<CLogin> logins = null;
        public static string username = "";
        public static string password = "";
        public Login()
        {
            InitializeComponent();
            initLogin();
        }

        public static void initLogin()
        {
            logins = CLoginDB.getAll();
            logins.Sort();
            DBUtil.closeSqlConnection();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isUser && isPass)
            {
                if (txtUsername.Text.Equals("admin"))
                {
                    admin = true;
                }
                else
                {
                    admin = false;
                }
                hydroForm = true;
                this.Hide();
                new Hydro(admin, this).Show();
            }
            else
            {
                MessageBox.Show("Incorrect username/password combination");
            }
        }

        private void key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSubmit_Click(null, null);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void llChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isUser)
            {
                changePassForm = true;
                username = txtUsername.Text;
                ChangePassword c = new ChangePassword();
                c.Show();
            }
            else
            {
                changePassForm = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Activated(object sender, EventArgs e)
        {
            if (changePassForm)
            {
                changePassForm = false;
                CLogin c = new CLogin();
                c.Username = txtUsername.Text;
                index = logins.BinarySearch(c);
                if (index >= 0)
                {
                    pictureBox1.Image = imageList1.Images[0];
                    password = logins.ElementAt<CLogin>(index).Password;
                    isUser = true;
                }
                else
                {
                    pictureBox1.Image = imageList1.Images[1];
                    isUser = false;
                }
                for (int i = 0; i < logins.Count; i++)
                {
                    String s = logins.ElementAt<CLogin>(i).Password;
                    if (s.Equals(txtPassword.Text) && i == index)
                    {
                        match = true;
                        break;
                    }
                    else
                    {
                        match = false;
                    }
                }
                if (isUser && match)
                {
                    pictureBox2.Image = imageList1.Images[0];
                    isPass = true;
                }
                else
                {
                    pictureBox2.Image = imageList1.Images[1];
                    isPass = false;
                }
                if (txtPassword.Text == "")
                {
                    pictureBox2.Image = null;
                }
                if (txtUsername.Text == "")
                {
                    pictureBox1.Image = null;
                }
                for (int i = 0; i < logins.Count; i++)
                {
                    String s = logins.ElementAt<CLogin>(i).Password;
                    if (s.Equals(txtPassword.Text) && i == index)
                    {
                        match = true;
                        break;
                    }
                    else
                    {
                        match = false;
                    }
                }
                if (isUser && match)
                {
                    pictureBox2.Image = imageList1.Images[0];
                    isPass = true;
                }
                else
                {
                    pictureBox2.Image = imageList1.Images[1];
                    isPass = false;
                }
                if (txtPassword.Text == "")
                {
                    pictureBox2.Image = null;
                }
                if (txtUsername.Text == "")
                {
                    pictureBox1.Image = null;
                }
            }
            if (hydroForm)
            {
                txtPassword.Text="";
                txtUsername.Text = "";
            }
        }

        public void text_changed(object sender, EventArgs e)
        {
            if (sender == txtUsername)
            {
                CLogin c = new CLogin();
                c.Username = txtUsername.Text;
                index = logins.BinarySearch(c);
                if (index >= 0)
                {
                    pictureBox1.Image = imageList1.Images[0];
                    password = logins.ElementAt<CLogin>(index).Password;
                    isUser = true;
                }
                else
                {
                    pictureBox1.Image = imageList1.Images[1];
                    isUser = false;
                }
                for (int i = 0; i < logins.Count; i++)
                {
                    String s = logins.ElementAt<CLogin>(i).Password;
                    if (s.Equals(txtPassword.Text) && i == index)
                    {
                        match = true;
                        break;
                    }
                    else
                    {
                        match = false;
                    }
                }
                if (isUser && match)
                {
                    pictureBox2.Image = imageList1.Images[0];
                    isPass = true;
                }
                else
                {
                    pictureBox2.Image = imageList1.Images[1];
                    isPass = false;
                }
                if (txtPassword.Text == "")
                {
                    pictureBox2.Image = null;
                }
                if (txtUsername.Text == "")
                {
                    pictureBox1.Image = null;
                }
            }
            else if (sender == txtPassword)
            {
                for (int i = 0; i < logins.Count; i++)
                {
                    String s = logins.ElementAt<CLogin>(i).Password;
                    if (s.Equals(txtPassword.Text) && i == index)
                    {
                        match = true;
                        break;
                    }
                    else
                    {
                        match = false;
                    }
                }
                if (isUser && match)
                {
                    pictureBox2.Image = imageList1.Images[0];
                    isPass = true;
                }
                else
                {
                    pictureBox2.Image = imageList1.Images[1];
                    isPass = false;
                }
                if (txtPassword.Text == "")
                {
                    pictureBox2.Image = null;
                }
                if (txtUsername.Text == "")
                {
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
