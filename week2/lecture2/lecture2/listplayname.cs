using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace lecture2
{
    public partial class lb1 : Form
    {
        public lb1()
        {
            InitializeComponent();
        }

        private void lb6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb1_Load(object sender, EventArgs e)
        {
            
        }

        private void lb5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void listbox_display(Boolean d)
        {
            lb_1.Visible = !d;
            lb2.Visible = !d;
            lb3.Visible = !d;
            lb4.Visible = !d;
            lb5.Visible = !d;
            col1.Visible = !d;
            col2.Visible = !d;
            col3.Visible = !d;
            col4.Visible = !d;
            col5.Visible = !d;
            

            lb6.Visible = d;
            lb7.Visible = d;
            lb8.Visible = d;
            lb9.Visible = d;
            lb10.Visible = d;
            lb11.Visible = d;
            col1_1.Visible = d;
            col1_2.Visible = d;
            col1_3.Visible = d;
            col1_4.Visible = d;
            col1_5.Visible = d;
            col1_6.Visible = d;
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            listbox_display(false);
            MessageBox.Show("Let me guess your name!!");
            int count = int.Parse(Interaction.InputBox("How many letters your name has?"));
            int[] pos = new int[count];

            for (int i = 0; i < count; i++)
            {
                pos[i] = int.Parse(Interaction.InputBox("Which column has letter no. " + (i + 1)));
            }

            

            for (int i = 0; i < count; i++)
            {
                switch (pos[i])
                {
                    case 1:
                        lb6.Items.Add(lb_1.Items[0]);
                        lb7.Items.Add(lb_1.Items[1]);
                        lb8.Items.Add(lb_1.Items[2]);
                        lb9.Items.Add(lb_1.Items[3]);
                        lb10.Items.Add(lb_1.Items[4]);
                        lb11.Items.Add(lb_1.Items[5]);
                        break;
                    case 2:
                        lb6.Items.Add(lb2.Items[0]);
                        lb7.Items.Add(lb2.Items[1]);
                        lb8.Items.Add(lb2.Items[2]);
                        lb9.Items.Add(lb2.Items[3]);
                        lb10.Items.Add(lb2.Items[4]);
                        break;
                    case 3:
                        lb6.Items.Add(lb3.Items[0]);
                        lb7.Items.Add(lb3.Items[1]);
                        lb8.Items.Add(lb3.Items[2]);
                        lb9.Items.Add(lb3.Items[3]);
                        lb10.Items.Add(lb3.Items[4]);
                        break;
                    case 4:
                        lb6.Items.Add(lb4.Items[0]);
                        lb7.Items.Add(lb4.Items[1]);
                        lb8.Items.Add(lb4.Items[2]);
                        lb9.Items.Add(lb4.Items[3]);
                        lb10.Items.Add(lb4.Items[4]);
                        break;
                    case 5:
                        lb6.Items.Add(lb5.Items[0]);
                        lb7.Items.Add(lb5.Items[1]);
                        lb8.Items.Add(lb5.Items[2]);
                        lb9.Items.Add(lb5.Items[3]);
                        lb10.Items.Add(lb5.Items[4]);
                        break;
                }
            }

            listbox_display(true);
            

            String name = "";

            for (int i = 0; i < count; i++)
            {
                pos[i] = int.Parse(Interaction.InputBox("Which column has letter no. " + (i + 1)));

                switch (pos[i])
                {
                    case 1:
                        name += lb6.Items[i];
                        break;
                    case 2:
                        name += lb7.Items[i];
                        break;
                    case 3:
                        name += lb8.Items[i];
                        break;
                    case 4:
                        name += lb9.Items[i];
                        break;
                    case 5:
                        name += lb10.Items[i];
                        break;
                    case 6:
                        name += lb11.Items[i];
                        break;
                }
            }
            DialogResult result = MessageBox.Show("Your name is " + name,"Result",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("hurrah! you won");
            }
            else
            {
                MessageBox.Show("Alas! You loose");
            }
            listbox_display(false);
        }
    }
}
