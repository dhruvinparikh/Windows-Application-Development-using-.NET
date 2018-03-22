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

namespace HydroConsumerManagement
{
    public partial class Hydro : Form
    {
        static int keyStroke = 0;
        bool decimalUsed = false;
        DataTable dataTable;
        SqlDataAdapter sda;
        bool admin;
        Login login;
        public Hydro(bool admin,Login login)
        {
            InitializeComponent();
            this.admin = admin;
            this.login = login;
            if (!admin)
            {
                dateTimePicker1.MinDate = DateTime.Today;
                newAccountToolStripMenuItem.Visible = false;

            }
            panelConsumerForm.Visible = true;
            panelConsumerID.Visible = false;
            panelNameCity.Visible = false;
            panelDueDate.Visible = false;
        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbConsumerID_TextChanged(object sender, EventArgs e)
        {
            if (sender == tbConsumerID)
            {
                keyStroke = tbConsumerID.Text.Length;
            }
            else if (sender == tbID)
            {
                keyStroke = tbID.Text.Length;
                btnSearchID_Click(null, null);
            }
            else if (sender == tbCID)
            {
                keyStroke = tbCID.Text.Length;
            }
        }

        private void key_pressed_ConsumerID(object sender, KeyPressEventArgs e)
        {
            if (sender == tbConsumerID || sender == tbID || sender == tbCID)
            {
                if (!(e.KeyChar == 8))
                {
                    if (sender == tbID && e.KeyChar == 13)
                    {
                        btnSearchID_Click(null, null);
                    }

                    if(sender == tbCID && e.KeyChar == 13)
                    {
                        btnDelete_Click(null, null);
                    }

                    if (keyStroke < 11)
                    {
                        e.Handled = !char.IsDigit(e.KeyChar);
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void key_press_name(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                e.Handled = !char.IsLetter(e.KeyChar);
            }
        }

        private void key_press_billamount(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (e.KeyChar != 46 || decimalUsed)
                {
                    if (sender == txtBA && e.KeyChar == 13 && txtBA.Text != "")
                    {
                        button1_Click(null, null);

                    }
                    e.Handled = !char.IsDigit(e.KeyChar);
                }
            }
        }

        private void tbBillAmount_TextChanged(object sender, EventArgs e)
        {
            if (sender == tbBillAmount)
            {
                decimalUsed = tbBillAmount.Text.IndexOf(".") >= 0;
            }
            else if (sender == txtBA)
            {
                decimalUsed = txtBA.Text.IndexOf(".") >= 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbConsumerID.Text != "" && tbFirstName.Text != "" &&
                tbLastName.Text != "" && tbCity.Text != "" && tbBillAmount.Text != "")
            {
                Consumer consumer = new Consumer();
                try
                {
                    consumer.setConsumerID(Convert.ToInt64(tbConsumerID.Text));
                    consumer.FirstName = tbFirstName.Text.ToUpper();
                    consumer.LastName = tbLastName.Text.ToUpper();
                    consumer.City = tbCity.Text.ToUpper();
                    consumer.BillAmount = Convert.ToDouble(tbBillAmount.Text);
                    DateTime date = dateTimePicker1.Value.Date;
                    consumer.DueDate = date;
                    ConsumerDB.add(consumer);
                    DialogResult result = MessageBox.Show("Record added to database", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        clearConsumerForm();
                    }

                }
                catch (ConsumerIDException)
                {
                    MessageBox.Show("consumer ID should be 11 digits");
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Consumer ID field cannot be empty");
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Consumer ID must be unique");
                }
                DBUtil.closeSqlConnection();
            }
            else
            {
                MessageBox.Show("No field should be empty", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearConsumerForm()
        {
            tbConsumerID.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbCity.Text = "";
            tbBillAmount.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearConsumerForm();
        }

        private void keypress_date(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAdd_Click(null, null);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consumerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearConsumerForm();
            dataGridConsumerID.DataSource = null;
            panelConsumerID.Visible = true;
            panelNameCity.Visible = false;
            panelDeleteID.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            panelConsumerID.Visible = false;
            panelDeleteID.Visible = false;
            //panelNameCity.Visible = false;
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "")
            {
                sda = ConsumerDB.getConsumerID(tbID.Text);
                dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridConsumerID.DataSource = dataTable;
                DBUtil.closeSqlConnection();
            }
            else
            {
                dataGridConsumerID.DataSource = null;
            }
        }
        private void keyPress_id(object sender, KeyPressEventArgs e)
        {
            key_pressed_ConsumerID(null, null);
        }

        private void btnUpdateID_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dataTable);
        }

        private void Hydro_Load(object sender, EventArgs e)
        {
        }

        private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDeleteID.Visible = false;
            cbNameCity.SelectedIndex = 0;
            panelConsumerID.Visible = true;
            panelNameCity.Visible = true;
            panelDueDate.Visible = false;
        }

        private void btnUpdateCityName_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dataTable);
        }

        private void btnSearchCityName_Click(object sender, EventArgs e)
        {
            if (tbCityName.Text != "")
            {
                if (cbNameCity.SelectedIndex == 0)
                {
                    sda = ConsumerDB.getConsumerFirstName(tbCityName.Text);
                }
                else if (cbNameCity.SelectedIndex == 1)
                {
                    sda = ConsumerDB.getConsumerLastName(tbCityName.Text);
                }
                else if (cbNameCity.SelectedIndex == 2)
                {
                    sda = ConsumerDB.getConsumerCity(tbCityName.Text);
                }

                dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridCityName.DataSource = dataTable;
                DBUtil.closeSqlConnection();
            }
            else
            {
                dataGridCityName.DataSource = null;
            }
        }

        private void tbCityName_TextChanged(object sender, EventArgs e)
        {
            if (tbCityName.Text != "")
            {
                if (cbNameCity.SelectedIndex == 0)
                {
                    sda = ConsumerDB.getConsumerFirstNameLike(tbCityName.Text);
                }
                else if (cbNameCity.SelectedIndex == 1)
                {
                    sda = ConsumerDB.getConsumerLastNameLike(tbCityName.Text);
                }
                else if (cbNameCity.SelectedIndex == 2)
                {
                    sda = ConsumerDB.getConsumerCityLike(tbCityName.Text);
                }

                dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridCityName.DataSource = dataTable;
                DBUtil.closeSqlConnection();
            }
            else
            {
                dataGridCityName.DataSource = null;
            }
        }

        private void cbNameCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNameCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbCityName_TextChanged(null, null);
        }

        private void dueDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDeleteID.Visible = false;
            panelConsumerForm.Visible = true;
            panelConsumerID.Visible = true;
            panelNameCity.Visible = true;
            panelDueDate.Visible = true;
            panelBillAmount.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void duedate_change(object sender, EventArgs e)
        {
            if (rbDefaulter.Checked)
            {
                sda = ConsumerDB.getDefaulter(DateTime.Now.Date);
            }
            else if (rbRegular.Checked)
            {
                sda = ConsumerDB.getRegular(DateTime.Now.Date);
            }
            dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridDueDate.DataSource = dataTable;
            DBUtil.closeSqlConnection();
        }

        private void billAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDeleteID.Visible = false;
            panelConsumerID.Visible = true;
            panelNameCity.Visible = true;
            panelDueDate.Visible = true;
            panelBillAmount.Visible = true;
            cbBillAmount.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = cbBillAmount.SelectedIndex;
            switch (index)
            {
                case 0:
                    sda = ConsumerDB.getBAGT(Convert.ToDouble(txtBA.Text));
                    break;
                case 1:
                    sda = ConsumerDB.getBALT(Convert.ToDouble(txtBA.Text));
                    break;
                case 2:
                    sda = ConsumerDB.getBAGTE(Convert.ToDouble(txtBA.Text));
                    break;
                case 3:
                    sda = ConsumerDB.getBALTE(Convert.ToDouble(txtBA.Text));
                    break;
                case 4:
                    sda = ConsumerDB.getBAE(Convert.ToDouble(txtBA.Text));
                    break;
            }
            dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridBillAmount.DataSource = dataTable;
            DBUtil.closeSqlConnection();
        }

        private void cbBillAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBA.Text != "")
            {
                button1_Click(null, null);
            }
        }

        private void consumerForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDeleteID.Visible = true;
            panelConsumerID.Visible = true;
            panelNameCity.Visible = true;
            panelDueDate.Visible = true;
            panelBillAmount.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbCID.Text.Length == 11)
            {
                ConsumerDB.deleteID(tbCID.Text);
                DBUtil.closeSqlConnection();
                btnDisplayAll_Click(null, null);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            sda = ConsumerDB.getAll();
            dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridViewAll.DataSource = dataTable;
            DBUtil.closeSqlConnection();

        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New n = new New();
            n.Show();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, you'll be logged off?", "Logg off", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                login.Show();
            }
        }

        private void Hydro_Activated(object sender, EventArgs e)
        {
            admin = login.admin;
            if (!admin)
            {
                dateTimePicker1.MinDate = DateTime.Today;
                newAccountToolStripMenuItem.Visible = false;

            }
        }
    }
}
