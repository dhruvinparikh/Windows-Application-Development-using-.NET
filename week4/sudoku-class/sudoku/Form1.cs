using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    public partial class Form1 : Form
    {
        bool win;
        int hints = 40;
        public Form1()
        {
            InitializeComponent();
            if (rbtnbeginner.Checked)
            {
                hints = 40;
            }
            else if (rbtnintermediate.Checked)
            {
                hints = 20;
            }
            else if (rbtnExpert.Checked)
            {
                hints = 8;
            }
            else if (rbtnMaster.Checked)
            {
                hints = 0;
            }
            setBoard();
        }
        int[,] solution = { {6,8,5,2,1,9,4,3,7 },
            {4,1,3,7,6,8,5,2,9},
        {2,7,9,5,4,3,1,8,6},
        {7,2,4,9,8,6,3,5,1},
        {3,6,8,1,5,4,9,7,2},
        {5,9,1,3,2,7,8,6,4},
        {9,4,2,8,7,5,6,1,3},
        {1,5,6,4,3,2,7,9,8 },
        {8,3,7,6,9,1,2,4,5} };
        private void cellCheck(object sender, EventArgs e)
        {


        }

        private void key_check(object sender, KeyEventArgs e)
        {

        }

        private bool solutioncheck()
        {
            for (int row = 0; row < sudokulayout.RowCount; row++)
            {
                for (int col = 0; col < sudokulayout.ColumnCount; col++)
                {
                    Control control = this.sudokulayout.GetControlFromPosition(row, col);
                    TextBox t = (TextBox)control;
                    if (!t.Text.Equals(Convert.ToString(solution[row, col])))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            win = solutioncheck();
            if (win)
            {
                MessageBox.Show("You win");
                setBoard();
            }
            else
            {
                MessageBox.Show("You loose");
            }
        }

        private void key_check(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Text = "";
            if (!Char.IsDigit((char)e.KeyChar) || (char)e.KeyChar == '0')
            {
                e.Handled = true;

            }
        }

        private void setBoard()
        {
            sudokulayout.Controls.Clear();
            win = true;
            for (int row = 0; row < sudokulayout.RowCount; row++)
            {
                for (int col = 0; col < sudokulayout.ColumnCount; col++)
                {
                    TextBox t = new TextBox();
                    sudokulayout.Controls.Add(t, row, col);
                    t.TextAlign = HorizontalAlignment.Center;
                    if (hints == 0)
                    {
                        t.KeyPress += (sender, e) =>
                        {
                            t.Text = "";
                            if (!Char.IsDigit((char)e.KeyChar) || (char)e.KeyChar == '0')
                            {
                                e.Handled = true;
                            }
                        };
                        t.KeyUp += (sender, e) =>
                        {
                            int c = sudokulayout.GetColumn(t);
                            int r = sudokulayout.GetRow(t);


                            for (int i = 0; i < sudokulayout.RowCount; i++)
                            {
                                Control control = this.sudokulayout.GetControlFromPosition(i, r);
                                TextBox t1 = (TextBox)control;
                                if (!t1.Text.Equals("") && !t1.Equals(t))
                                {
                                    if (t1.Text.Equals(t.Text))
                                    {
                                        t.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        t.BackColor = Color.White;
                                    }
                            
                                }
                            }

                            for (int i = 0; i < sudokulayout.ColumnCount; i++)
                            {
                                Control control = this.sudokulayout.GetControlFromPosition(c, i);
                                TextBox t1 = (TextBox)control;
                                if (!t1.Text.Equals("") && !t1.Equals(t))
                                {
                                    if (t1.Text.Equals(t.Text))
                                    {
                                        t.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        t.BackColor = Color.White;
                                    }
                                }
                            }

                            int tr = 0, tc = 0;

                            if (c % 3 == 0)
                            {
                                tc = c;
                            }
                            else if (c % 3 == 1)
                            {
                                tc = c - 1;
                            }
                            else if (c % 3 == 2)
                            {
                                tc = c - 2;
                            }
                            if (r % 3 == 0)
                            {
                                tr = r;
                            }
                            else if (r % 3 == 1)
                            {
                                tr = r - 1;
                            }
                            else if (r % 3 == 2)
                            {
                                tr = r - 2;
                            }

                            for (int i = tr; i <= tr + 2; i++)
                            {
                                for (int j = tc; j <= tc + 2; j++)
                                {
                                    Control control = this.sudokulayout.GetControlFromPosition(j, i);
                                    TextBox t1 = (TextBox)control;
                                    if (!t1.Text.Equals("") && !t1.Equals(t))
                                    {
                                        if (t1.Text.Equals(t.Text))
                                        {
                                            t.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            t.BackColor = Color.White;
                                        }
                                    }
                                }
                            }

                        };

                        //beginner : 40 hints
                        //intermediate : 20 hints
                        //expert : 8 hints
                        //master : 0 hints
                        
                    }
                }
            }
            if (hints != 0)
            {
                Random rand = new Random();
                for (int hint = 0; hint < hints; hint++)
                {
                    int r = rand.Next(0, 9);
                    int c = rand.Next(0, 9);
                    Control control = this.sudokulayout.GetControlFromPosition(c, r);
                    TextBox tt = (TextBox)control;
                    tt.Text = Convert.ToString(solution[c, r]);
                    tt.Enabled = false;
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bgtnReset_Click(object sender, EventArgs e)
        {
            if (rbtnbeginner.Checked)
            {
                hints = 40;
            }
            else if (rbtnintermediate.Checked)
            {
                hints = 20;
            }
            else if (rbtnExpert.Checked)
            {
                hints = 8;
            }
            else if (rbtnMaster.Checked)
            {
                hints = 0;
            }
            setBoard();
        }

        private void rbtnCheckedChanged(object sender, EventArgs e)
        {
            bgtnReset_Click(null, null);
        }
    }
}
