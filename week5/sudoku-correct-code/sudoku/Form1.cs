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
        int noofhints = 0;
        public Form1()
        {
            InitializeComponent();
            setBoard();
        }
        int[,] solution = { {6,8,5,2,1,9,4,3,7 }, 
            { 4,1,3,7,6,8,5,2,9},
        {2,7,9,5,4,3,1,8,6}, 
        {7,2,4,9,8,6,3,5,1}, 
        {3,6,8,1,5,4,9,7,2}, 
        {5,9,1,3,2,7,8,6,4},
        { 9,4,2,8,7,5,6,1,3}, 
        {1,5,6,4,3,2,7,9,8 },
        {8,3,7,6,9,1,2,4,5} };
        private void cellCheck(object sender, EventArgs e)
        {
            
          
        }

        private void key_check(object sender, KeyEventArgs e)
        {
           
        }
    
      

        private void button1_Click(object sender, EventArgs e)
        {
            win=solutioncheck();
            if(win)
            {
                MessageBox.Show("You Win");
                setBoard();
            }
            else
            {
                MessageBox.Show("You Loose");
            }
            
        }

        private void key_check(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
           
        }
        private bool solutioncheck()
        {
             for (int row = 0; row < sudokulayout.RowCount; row++)
            {
                for (int col = 0; col < sudokulayout.ColumnCount; col++)
                {
                    Control control = this.sudokulayout.GetControlFromPosition(col, row);
                    TextBox t = (TextBox)control;
                    if (!t.Text.Equals(Convert.ToString(solution[row,col])))
                    {
                       // win = false;
                        return false;
                    }
                    
                }

            }
            return true;

        }
        private void setBoard()
        {
            sudokulayout.Controls.Clear();
            win = true;
            for(int row=0;row<sudokulayout.RowCount;row++)
            {
                for(int col=0;col<sudokulayout.ColumnCount;col++)
                {
                    TextBox t = new TextBox();
                    sudokulayout.Controls.Add(t, col, row);
                    t.TextAlign = HorizontalAlignment.Center;
                    t.KeyPress += (sender, e) =>
                      {
                          t.Text = "";
                          if (!Char.IsDigit((char)e.KeyChar) || (char)e.KeyChar == '0')
                          {
                              e.Handled = true;

                          }
                          t.ForeColor = Color.Black;
                      };
                    t.KeyUp += (sender, e) =>
                      {
                          int r1 = this.sudokulayout.GetRow(t);
                          int c1 = this.sudokulayout.GetColumn(t);
                          checkMaster(t, r1, c1);
                      };
                }
               // if(list1.selected())
                //{
                 //   noofhints = 20;
                //}
            }
            Random rand = new Random();
            for(int hint=0;hint<noofhints;hint++)
            {
               
                int r = rand.Next(0, 9);
                int c = rand.Next(0, 9);
                Control control = this.sudokulayout.GetControlFromPosition(c, r);
                TextBox t = (TextBox)control;
                t.Text = Convert.ToString(solution[r,c]);
                t.Enabled = false;
            }

        }
        private void checkMaster(TextBox t,int r1,int c1)
        {
            //check vertical all rows
            for(int r11=0;r11<9;r11++)
            {
                Control control = this.sudokulayout.GetControlFromPosition(r11, c1);
                TextBox textbox = (TextBox)control;
                if(r11==r1)
                {
                    //do nothing for same textbox where entering data
                }
                else
                {
                    if(t.Text.Equals(textbox.Text))
                    {
                        t.ForeColor = Color.Red;
                    }
                    else
                    {
                        t.ForeColor = Color.Black;
                    }
                }
           
            }
            //check horizontally
            for (int c11 = 0; c11 < 9; c11++)
            {
                Control control = this.sudokulayout.GetControlFromPosition(r1, c11);
                TextBox textbox = (TextBox)control;
                if (c11 == c1)
                {
                    //do nothing for same textbox where entering data
                }
                else
                {
                    if (t.Text.Equals(textbox.Text))
                    {
                        t.ForeColor = Color.Red;
                    }
                    else
                    {
                        t.ForeColor = Color.Black;
                    }
                }

            }
            //check one box-grid
            int r, c;
            if (r1 < 3)
                r = 0;
            else if (r1 >= 3 && r1 < 6)
                r = 3;
            else
                r = 6;
            if (c1 < 3)
                c = 0;
            else if (c1 >= 3 && c1 < 6)
                 c= 3;
            else
                c = 6;
            for(int a=r;a<r+3;a++)
            {
                for(int b=c;b<c+3;b++)
                {
                    Control control = this.sudokulayout.GetControlFromPosition(b,a);
                    TextBox textbox = (TextBox)control;
                    if (a==r1 && b == c1)
                    {
                        //do nothing for same textbox where entering data
                    }
                    else
                    {
                        if (t.Text.Equals(textbox.Text))
                        {
                            t.ForeColor = Color.Red;
                        }
                        
                    }
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            setBoard();
        }
    }
}
