using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EightQueen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setboard();
            count = 0;
        }

        private void checkMaster(int row, int col)
        {
            //col above
            for (int i = row - 1; i >= 0; i--)
            {
                Control control = this.eightQueenLayout.GetControlFromPosition(col, i);
                PictureBox p = (PictureBox)control;
                if (p.Enabled)
                {
                    p.Image = imageList1.Images[1];
                }
                p.Enabled = false;
            }
            //col below
            for (int i = row + 1; i < 8; i++)
            {
                Control control = this.eightQueenLayout.GetControlFromPosition(col, i);
                PictureBox p = (PictureBox)control;
                if (p.Enabled)
                {
                    p.Image = imageList1.Images[1];
                }
                p.Enabled = false;
            }
            //row left
            for (int i = col - 1; i >= 0; i--)
            {
                Control control = this.eightQueenLayout.GetControlFromPosition(i, row);
                PictureBox p = (PictureBox)control;
                if (p.Enabled)
                {
                    p.Image = imageList1.Images[1];
                }
                p.Enabled = false;
            }
            //row right
            for (int i = col + 1; i < 8; i++)
            {
                Control control = this.eightQueenLayout.GetControlFromPosition(i, row);
                PictureBox p = (PictureBox)control;
                if (p.Enabled)
                {
                    p.Image = imageList1.Images[1];
                }
                p.Enabled = false;
            }
            int c = col; int r = row;
            //diagonal top left
            if (row != 0)
            {

                for (int i = 0; i < col; i++)
                {
                    c--;
                    r--;
                    if (c >= 0 && r >= 0)
                    {
                        Control control = this.eightQueenLayout.GetControlFromPosition(c, r);
                        PictureBox p = (PictureBox)control;
                        if (p.Enabled)
                        {
                            p.Image = imageList1.Images[1];
                        }
                        p.Enabled = false;
                    }
                }
            }
            //diagonal bottom left
            c = col; r = row;
            if (row != 7)
            {
                for (int i = 0; i < col; i++)
                {
                    c--; r++;
                    if (c >= 0 && r < 8)
                    {
                        Control control = this.eightQueenLayout.GetControlFromPosition(c, r);
                        PictureBox p = (PictureBox)control;
                        if (p.Enabled)
                        {
                            p.Image = imageList1.Images[1];
                        }
                        p.Enabled = false;
                    }
                }
            }
            //diagonal top right
            c = col; r = row;
            if (row != 0)
            {
                for (int i = 7; i > col; i--)
                {
                    r--; c++;
                    if (r >= 0 && c < 8)
                    {
                        Control control = this.eightQueenLayout.GetControlFromPosition(c, r);
                        PictureBox p = (PictureBox)control;
                        if (p.Enabled)
                        {
                            p.Image = imageList1.Images[1];
                        }
                        p.Enabled = false;
                    }
                }
            }
            //diagonal bottom right
            c = col; r = row;
            if (r != 7)
            {
                for (int i = 7; i > col; i--)
                {
                    r++; c++;
                    if (r < 8 && c < 8)
                    {
                        Control control = this.eightQueenLayout.GetControlFromPosition(c, r);
                        PictureBox p = (PictureBox)control;
                        if (p.Enabled)
                        {
                            p.Image = imageList1.Images[1];
                        }
                        p.Enabled = false;
                    }
                }
            }
            bool validate = true;
            if(count == 8)
            {
                DialogResult result = MessageBox.Show("You nailed it","Result", MessageBoxButtons.OK,MessageBoxIcon.Information );
                if(result == DialogResult.OK)
                {
                    setboard();
                    count = 0;
                }
            }
            else
            {
                for(int i = 0; i < 8; i++)
                {
                    for(int j = 0; j < 8; j++)
                    {
                        Control control = this.eightQueenLayout.GetControlFromPosition(j, i);
                        PictureBox p = (PictureBox)control;
                        if (p.Enabled)
                        {
                            validate = false;
                            break;
                        }
                    }
                    if (!validate)
                    {
                        break;
                    }
                }
                if (validate)
                {
                    DialogResult result = MessageBox.Show("You loose", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        setboard();
                        count = 0;
                    }
                }
            }
        }

        private void setboard()
        {
            eightQueenLayout.Controls.Clear();
            for (int row = 0; row < eightQueenLayout.ColumnCount; row++)
            {
                for (int col = 0; col < eightQueenLayout.RowCount; col++)
                {
                    PictureBox pb = new PictureBox();
                    eightQueenLayout.Controls.Add(pb, row, col);
                    pb.SizeMode = PictureBoxSizeMode.CenterImage;
                    pb.Enabled = true;
                    pb.Click += (sender, e) =>
                    {
                        int r = this.eightQueenLayout.GetRow(pb);
                        int c = this.eightQueenLayout.GetColumn(pb);
                        pb.Image = imageList1.Images[0];
                        pb.Enabled = false;
                        count++;
                        checkMaster(r, c);
                    };
                }
            }

            for (int i = 0; i < eightQueenLayout.RowCount; i++)
            {
                for (int j = 0; j < eightQueenLayout.ColumnCount; j++)
                {
                    Control c = this.eightQueenLayout.GetControlFromPosition(j, i);
                    PictureBox pb = (PictureBox)c;
                }
            }
        }
        int count = 0;
        private void btnClear_Click(object sender, EventArgs e)
        {
            setboard();
            count = 0;
        }
    }
}
