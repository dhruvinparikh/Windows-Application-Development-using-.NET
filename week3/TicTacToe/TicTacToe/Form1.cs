using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        bool[] isBoxChecked = new bool[9];
        int numOfTurns = 0;
        bool win = false;

        private void displayMessage(String strMsg)
        {
            DialogResult result = MessageBox.Show(strMsg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                clear_all();
                setPower(false);
            }
        }

        private bool isWinner(int[] n)
        {
            
            if(numOfTurns > 4)
            {
                if(isBoxChecked[0] && isBoxChecked[1] && isBoxChecked[2] && lbl_1.Text == lbl_2.Text && lbl_2.Text == lbl_3.Text)
                {
                        win = true;
                        if(lbl_1.Text == "0")
                        {
                        n[0] = 1;
                        }
                        else
                        {
                        n[0] = 2;
                        }
                }
                else if (isBoxChecked[3] && isBoxChecked[4] && isBoxChecked[5] && lbl_4.Text == lbl_5.Text && lbl_5.Text == lbl_6.Text)
                {
                        win = true;
                        if (lbl_4.Text == "0")
                        {
                        n[0] = 1;
                    }
                        else
                        {
                        n[0] = 2;
                    }
                }
                else if (isBoxChecked[6] && isBoxChecked[7] && isBoxChecked[8] && lbl_7.Text == lbl_8.Text && lbl_8.Text == lbl_9.Text)
                {
                        win = true;
                        if (lbl_7.Text == "0")
                        {
                        n[0] = 1;
                    }
                        else
                        {
                        n[0] = 2;
                    }
                }
                else if (isBoxChecked[0] && isBoxChecked[3] && isBoxChecked[6] && lbl_1.Text == lbl_4.Text && lbl_4.Text == lbl_7.Text)
                {
                        win = true;
                        if (lbl_1.Text == "0")
                        {
                        n[0] = 1;
                    }
                        else
                        {
                        n[0] = 2;
                    }
                }
                else if (isBoxChecked[1] && isBoxChecked[4] && isBoxChecked[7] && lbl_2.Text == lbl_5.Text && lbl_5.Text == lbl_8.Text)
                {
                        win = true;
                        if (lbl_2.Text == "0")
                        {
                        n[0] = 1;
                    }
                        else
                        {
                        n[0] = 2;
                    }
                }
                else if (isBoxChecked[2] && isBoxChecked[5] && isBoxChecked[8] && lbl_3.Text == lbl_6.Text && lbl_6.Text == lbl_9.Text)
                {
                        win = true;
                        if (lbl_3.Text == "0")
                        {
                        n[0] = 1;
                    }
                        else
                        {
                        n[0] = 2;
                    }
                }
                else if (isBoxChecked[0] && isBoxChecked[4] && isBoxChecked[8] && lbl_1.Text == lbl_5.Text && lbl_5.Text == lbl_9.Text)
                {
                        win = true;
                        if (lbl_1.Text == "0")
                        {
                        n[0] = 1;
                    }
                        else
                        {
                        n[0] = 2;
                    }
                }
                else if (isBoxChecked[2] && isBoxChecked[4] && isBoxChecked[6] && lbl_3.Text == lbl_5.Text && lbl_5.Text == lbl_7.Text)
                {
                        win = true;
                        if (lbl_3.Text == "0")
                        {
                        n[0] = 1;
                    }
                        else
                        {
                        n[0] = 2;
                    }
                }
                else
                {
                    if(numOfTurns == 9 && !win)
                    {
                        n[0] = 0;
                    }
                }
            }
            return win;
        }

        private void box_check(int a)
        {
            switch (a)
            {
                case 1:
                    lbl_1.Text = "X";
                    break;
                case 2:
                    lbl_2.Text = "X";
                    break;
                case 3:
                    lbl_3.Text = "X";
                    break;
                case 4:
                    lbl_4.Text = "X";
                    break;
                case 5:
                    lbl_5.Text = "X";
                    break;
                case 6:
                    lbl_6.Text = "X";
                    break;
                case 7:
                    lbl_7.Text = "X";
                    break;
                case 8:
                    lbl_8.Text = "X";
                    break;
                case 9:
                    lbl_9.Text = "X";
                    break;
            }
        }

        private void playPC()
        {
            Random rand = new Random();
            int a = rand.Next(0, 8);
            int[] n = new int[1];
            n[0] = 0;
            if (numOfTurns != 9 && !isWinner(n))
            {
                do
                {
                    if (isBoxChecked[a])
                    {
                        a = rand.Next(0, 8);
                    }
                    else
                    {
                        isBoxChecked[a] = true;
                        numOfTurns++;
                        box_check(a+1);
                        break;
                    }
                } while (true);
            }
            n[0] = 0;
            if (isWinner(n))
            {
                switch (n[0])
                {
                    case 0:
                        displayMessage("Tie");
                        break;
                    case 1:
                        displayMessage("Bingo! YOU won");
                        break;
                    case 2:
                        displayMessage("Bingo! PC won");
                        break;
                }
            }
           
        }

        private void TicTacToe_ClickEvent(object sender, MouseEventArgs e)
        {
            if(sender == lbl_1)
            {
                if (!isBoxChecked[0])
                {
                    lbl_1.Text = "0";
                    isBoxChecked[0] = true;
                    numOfTurns++;
                    playPC();
                }
            }
            else if(sender == lbl_2)
            {
                if (!isBoxChecked[1])
                {
                    lbl_2.Text = "0";
                    isBoxChecked[1] = true;
                    numOfTurns++;
                    playPC();
                }
            }
            else if(sender == lbl_3)
            {
                if (!isBoxChecked[2])
                {
                    lbl_3.Text = "0";
                    isBoxChecked[2] = true;
                    numOfTurns++;
                    playPC();
                }
            }
            else if(sender == lbl_4)
            {
                if (!isBoxChecked[3])
                {
                    lbl_4.Text = "0";
                    isBoxChecked[3] = true;
                    numOfTurns++;
                    playPC();
                }
            }
            else if(sender == lbl_5)
            {
                if (!isBoxChecked[4])
                {
                    lbl_5.Text = "0";
                    isBoxChecked[4] = true;
                    numOfTurns++;
                    playPC();
                }
            }
            else if (sender == lbl_6)
            {
                if (!isBoxChecked[5])
                {
                    lbl_6.Text = "0";
                    isBoxChecked[5] = true;
                    numOfTurns++;
                    playPC();
                }
            }
            else if (sender == lbl_7)
            {
                if (!isBoxChecked[6])
                {
                    lbl_7.Text = "0";
                    isBoxChecked[6] = true;
                    numOfTurns++;
                    playPC();
                }
            }
            else if (sender == lbl_8)
            {
                if (!isBoxChecked[7])
                {
                    lbl_8.Text = "0";
                    isBoxChecked[7] = true;
                    numOfTurns++;
                    playPC();
                }
            }
            else if (sender == lbl_9)
            {
                if (!isBoxChecked[8])
                {
                    lbl_9.Text = "0";
                    isBoxChecked[8] = true;
                    numOfTurns++;
                    playPC();
                }
            }
        }

        private void lbl_1_Click(object sender, EventArgs e)
        {

        }
 
        private void clear_all()
        {
            lbl_1.Text = "-";
            lbl_2.Text = "-";
            lbl_3.Text = "-";
            lbl_4.Text = "-";
            lbl_5.Text = "-";
            lbl_6.Text = "-";
            lbl_7.Text = "-";
            lbl_8.Text = "-";
            lbl_9.Text = "-";

            for(int j = 0; j < isBoxChecked.Length; j++)
            {
                isBoxChecked[j] = false;
            }
            win = false;
            numOfTurns = 0;
        }

        private void setPower(bool b)
        {
            lbl_1.Enabled = b;
            lbl_2.Enabled = b;
            lbl_3.Enabled = b;
            lbl_4.Enabled = b;
            lbl_5.Enabled = b;
            lbl_6.Enabled = b;
            lbl_7.Enabled = b;
            lbl_8.Enabled = b;
            lbl_9.Enabled = b;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            setPower(true);
            clear_all();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setPower(false);
            clear_all();
        }
    }
}
